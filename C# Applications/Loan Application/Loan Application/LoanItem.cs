using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application
{
    class LoanItem
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public int LeftInStock { get; set; }
        public double Penalty { get; private set; }
        public string Status { get; private set; }
        public int ItemNumber { get; private set; }

        public string ReturnStatus { get; private set; }

        public LoanItem(int id, string name, double price, int leftinstock, double penalty)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = 0;
            LeftInStock = leftinstock;
            Penalty = penalty;
        }

        public LoanItem(int id, int itemnumber)
        {
            ID = id;
            ItemNumber = itemnumber;
        }

        public void UpdateQuantity(int n)
        {
            Quantity = Quantity + n;
        }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public void UpdatePenalty(double penalty)
        {
            Penalty = penalty;
        }

        public void UpdateReturnStatus(string returnstatus)
        {
            ReturnStatus = returnstatus;
        }
    }
}
