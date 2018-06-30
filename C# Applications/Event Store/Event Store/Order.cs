using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_DLL;

namespace Event_Store
{
    class Order
    {
        public delegate void ErrorEventHandeler(string message);

        public event ErrorEventHandeler Error;
        public void OnError(string message)
        {
            if(Error != null)
            {
                Error(message);
            }
        }
        Store OrderDataBase = new Store();
        public List<Item> OrderList { get; private set; }
        public int PurchaseID { get; private set; }

        public int CustomerID { get; private set; }

        public double Total { get; private set; }

        public Order(int customerid)
        {
            CustomerID = customerid;
            PurchaseID = 0;
            Total = 0;

            while(OrderDataBase.CheckIfPurchaseIDExist(customerid, PurchaseID) != 0)
            {
                PurchaseID++;
            }

            OrderList = new List<Item>();
        }

        public void Add(int itemid, int quantity, int age, ref double balanceleft)
        {
            try
            {
                List<string> ItemData = OrderDataBase.GetItem("product", itemid);
                bool InOrder = false;
                int IsAdult = 0;
                int OnlyForAdults = 0;
                int LeftInStock = Convert.ToInt32(ItemData[3]);

                if (ItemData[4] == "True")
                {
                    OnlyForAdults = 1;
                }

                if (age >= 18)
                {
                    IsAdult = 1;
                }

                if (OrderList.Count() != 0)
                {
                    foreach (Item p in OrderList)
                    {
                        if (p.ID == itemid)
                        {
                            LeftInStock = p.LeftInStock;
                        }
                    }
                }

                if (IsAdult >= OnlyForAdults)
                {
                    if (balanceleft >= Convert.ToDouble(quantity) * Convert.ToDouble(ItemData[2]))
                    {
                        if (quantity <= LeftInStock)
                        {
                            if (OrderList.Count() != 0)
                            {
                                foreach (Item p in OrderList)
                                {
                                    if (p.ID == itemid)
                                    {
                                        p.UpdateQuantity(quantity);
                                        InOrder = true;
                                        p.LeftInStock = p.LeftInStock - quantity;
                                        balanceleft = balanceleft - (Convert.ToDouble(quantity) * Convert.ToDouble(ItemData[2]));
                                    }
                                }
                            }

                            else
                            {
                                OrderList.Add(new Item(itemid, ItemData[1], Convert.ToDouble(ItemData[2]), Convert.ToInt32(ItemData[3]), Convert.ToBoolean(ItemData[4])));
                                foreach (Item p in OrderList)
                                {
                                    if (p.ID == itemid)
                                    {
                                        p.UpdateQuantity(quantity);
                                        InOrder = true;
                                        p.LeftInStock = p.LeftInStock - quantity;
                                        balanceleft = balanceleft - (Convert.ToDouble(quantity) * Convert.ToDouble(ItemData[2]));
                                    }
                                }
                            }

                            if (InOrder == false)
                            {
                                OrderList.Add(new Item(itemid, ItemData[1], Convert.ToDouble(ItemData[2]), Convert.ToInt32(ItemData[3]), Convert.ToBoolean(ItemData[4])));
                                foreach (Item p in OrderList)
                                {
                                    if (p.ID == itemid)
                                    {
                                        p.UpdateQuantity(quantity);
                                        p.LeftInStock = p.LeftInStock - quantity;
                                        balanceleft = balanceleft - (Convert.ToDouble(quantity) * Convert.ToDouble(ItemData[2]));
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

                else
                {
                    OnError("Product is only available for adults.");
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
                foreach(Item p in OrderList)
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
                foreach (Item p in OrderList)
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

        public void ClearRow(int index, ref double balanceleft)
        {
            if (OrderList.Count() != 0)
            {
                int quantity = OrderList[index].Quantity;
                double price = OrderList[index].Price;
                OrderList[index].LeftInStock = OrderList[index].LeftInStock + quantity;
                OrderList.RemoveAt(index);
                balanceleft = balanceleft + ((double)quantity * price);
            }

            CalculateTotal();
        }
    }
}
