using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_DLL;

namespace Loan_Application
{
    class ReturnOrder
    {
        Store OrderDataBase = new Store();
        public List<LoanItem> ReturnList { get; private set; }

        public int CustomerID { get; private set; }

        public int ItemsToReturn { get; private set; }

        public ReturnOrder(int customerid)
        {
            CustomerID = customerid;
            ReturnList = new List<LoanItem>();
            ItemsToReturn = OrderDataBase.GetItemsToReturn(customerid);
            PopulateReturnList();
        }

        private void PopulateReturnList()
        {
            if(ItemsToReturn > 0)
            {
                List<string> temp = OrderDataBase.GetBorrowingData(CustomerID);

                foreach (string p in temp)
                {
                    string[] tempstring = p.Split(',');
                    ReturnList.Add(new LoanItem(Convert.ToInt32(tempstring[0]), Convert.ToInt32(tempstring[1])));
                }

                foreach(LoanItem p in ReturnList)
                {
                    string m = OrderDataBase.GetItemName(p.ID);
                    string[] tempm = m.Split('-');
                    p.UpdateName(tempm[0]);
                    p.UpdatePenalty(Convert.ToDouble(tempm[1]));
                }
            }
        }

        public void UpdateStatus(int index, string status)
        {
            if(ReturnList.Count() != 0)
            {
                ReturnList[index].UpdateReturnStatus(status);
            }
        }


    }
}
