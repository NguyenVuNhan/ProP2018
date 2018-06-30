using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Apps
{
    public class Transaction
    {
        //field
        public static int nrOfTransaction = 1;
        private int id;
        private string bankAccount;
        private DateTime startTime;
        private DateTime endTime;
        private int amount;
        private List<User> users;

        //properties
        public int Id
        {
            get => id;
        }
        public string BankAccount
        {
            get => bankAccount;
        }
        public DateTime StartTime
        {
            get => startTime;
        }
        public DateTime EndTime
        {
            get => endTime;
        }
        public int Amount
        {
            get => amount;
        }
        public List<User> Users
        {
            get => users;
        }

        //Constructor
        public Transaction(string bankAccount, DateTime startTime, DateTime endTime, int amount)
        {
            //create unique id for each transaction
            this.id = nrOfTransaction;
            nrOfTransaction++;
            this.bankAccount = bankAccount;
            this.startTime = startTime;
            this.endTime = endTime;
            this.amount = amount;
            users = new List<User>();
        }

        //method
        public void AddUser(int id, double money)
        {
            this.users.Add(new User(id, money));
        }
        public override string ToString()
        {
            return $"Id: {id}, Bank account: {bankAccount}, Start time: {startTime.ToString()}, End time: {endTime.ToString()}, Amount: {amount}";
        }
    }
}
