using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Manager_Apps
{
    public class User
    {
        //properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public decimal Balance { get; private set; }
        public string Email { get; private set; }
        public DateTime DoB { get; private set; }
        public bool CheckInEvent { get; private set; }
        public bool CheckInCamping { get; private set; }
        public int SpotNr { get; private set; }

        //Constructor
        public User(int id, string name, decimal balance, string email, DateTime dob, 
                            bool checkInEvent, bool checkInCamping, int spotNr)
        {
            this.Id = id;
            this.Name = name;
            this.Balance = balance;
            this.Email = email;
            this.DoB = dob;
            this.CheckInEvent = checkInEvent;
            this.CheckInCamping = checkInCamping;
            this.SpotNr = spotNr;
        }

        //method
        public override string ToString()
        {
            string spot = (SpotNr.ToString() == "-1") ? "No spot" : SpotNr.ToString();
            return $"{Name}, Customer id: {Id}, {DateTime.Now.Year - DoB.Year} years old, Balance: {Balance}, Spot: {spot}";
        }
    }
}
