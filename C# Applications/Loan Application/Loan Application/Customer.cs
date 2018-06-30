using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loan_Application
{
    class Customer
    {
        public int CostumerID { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public double Balance { get; private set; }

        public double BalanceLeft { get; set; }

        public int Age { get; private set; }

        public Customer(int costumerID, string firstName, string lastName, double balance, string dob)
        {
            CostumerID = costumerID;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
            BalanceLeft = balance;

            DateTime EnteredDOB = DateTime.Parse(dob);
            double ageInDays = ((DateTime.Today - EnteredDOB).Days / 365);
            Age = (int)(Math.Truncate(ageInDays));
        }
    }
}
