using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_DLL;

namespace Loan_Application
{
    class LoanOrder
    {
        public delegate void ErrorEventHandeler(string message);

        public event ErrorEventHandeler Error;

        public void OnError(string message)
        {
            if (Error != null)
            {
                Error(message);
            }
        }

        Store OrderDataBase = new Store();
        public List<LoanItem> OrderList { get; private set; }

        public int CustomerID { get; private set; }

        public double Total { get; private set; }

        public LoanOrder(int customerid)
        {
            OrderList = new List<LoanItem>();
            CustomerID = customerid;
            Total = 0;
        }

        public void Add(int itemid, ref double balanceleft)
        {
            try
            {
                List<string> ItemData = OrderDataBase.GetItem("borrowable", itemid);
                bool InOrder = false;
                int LeftInStock = Convert.ToInt32(ItemData[3]);

                if (OrderList.Count() != 0)
                {
                    foreach (LoanItem p in OrderList)
                    {
                        if (p.ID == itemid)
                        {
                            LeftInStock = p.LeftInStock;
                        }
                    }
                }

                if (balanceleft >= Convert.ToDouble(ItemData[2]))
                {
                    if (1 <= LeftInStock)
                    {
                        if (OrderList.Count() != 0)
                        {
                            foreach (LoanItem p in OrderList)
                            {
                                if (p.ID == itemid)
                                {
                                    p.UpdateQuantity(1);
                                    InOrder = true;
                                    p.LeftInStock = p.LeftInStock - 1;
                                    balanceleft = balanceleft - Convert.ToDouble(ItemData[2]);
                                }
                            }
                        }

                        else
                        {
                            OrderList.Add(new LoanItem(itemid, ItemData[1], Convert.ToDouble(ItemData[2]), Convert.ToInt32(ItemData[3]), Convert.ToDouble(ItemData[4])));
                            foreach (LoanItem p in OrderList)
                            {
                                if (p.ID == itemid)
                                {
                                    p.UpdateQuantity(1);
                                    InOrder = true;
                                    p.LeftInStock = p.LeftInStock - 1;
                                    balanceleft = balanceleft - Convert.ToDouble(ItemData[2]);
                                }
                            }
                        }

                        if (InOrder == false)
                        {
                            OrderList.Add(new LoanItem(itemid, ItemData[1], Convert.ToDouble(ItemData[2]), Convert.ToInt32(ItemData[3]), Convert.ToDouble(ItemData[4])));
                            foreach (LoanItem p in OrderList)
                            {
                                if (p.ID == itemid)
                                {
                                    p.UpdateQuantity(1);
                                    p.LeftInStock = p.LeftInStock - 1;
                                    balanceleft = balanceleft - Convert.ToDouble(ItemData[2]);
                                }
                            }
                        }

                        CalculateTotal();
                    }

                    else
                    {
                        OnError("Not enough products in stock.");
                    }
                }

                else
                {
                    OnError("Balance not enough to add product.");
                }
            }

            catch
            {
                OnError("Check your connection. Unable to reach the database.");
            }            
        }

        private void CalculateTotal()
        {
            Total = 0;
            if (OrderList.Count() != 0)
            {
                foreach (LoanItem p in OrderList)
                {
                    Total = Total + ((double)p.Quantity * p.Price);
                }
            }
        }

        public void Deduct(int itemid, ref double balanceleft)
        {
            int index = -1;
            double price = 0;

            if (OrderList.Count() != 0)
            {
                foreach (LoanItem p in OrderList)
                {
                    if (p.ID == itemid)
                    {
                        price = p.Price;

                        if (p.Quantity > 1)
                        {
                            p.UpdateQuantity(-1);
                            p.LeftInStock = p.LeftInStock + 1;
                            balanceleft = balanceleft + p.Price;
                        }

                        else
                        {
                            index = OrderList.IndexOf(p);
                        }
                    }
                }

                if (index != -1)
                {
                    OrderList[index].LeftInStock = OrderList[index].LeftInStock + 1;
                    OrderList.RemoveAt(index);
                    balanceleft = balanceleft + price;
                }
            }

            CalculateTotal();
        }

        public void ClearList(ref double balanceleft)
        {
            if (OrderList.Count() != 0)
            {
                foreach(LoanItem p in OrderList)
                {
                    balanceleft = balanceleft + ((double)(p.Quantity)) * p.Price;
                }

                OrderList.Clear();
            }

            CalculateTotal();
        }

        public void ProcessLoanOrder(double newbalance)
        {
            if(OrderList.Count() != 0)
            {
                foreach(LoanItem p in OrderList)
                {
                    OrderDataBase.ProcessLoanOrder(CustomerID, p.ID, p.Quantity, p.LeftInStock, newbalance);
                }
            }
        }

    }
}
