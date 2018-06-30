using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ATM_Apps
{
    public class User
    {
        //field
        private int id;
        private double money;

        //properties
        public int Id
        {
            get => id;
        }
        public double Money
        {
            get => money;
        }

        //Constructor
        public User(int id, double money)
        {
            this.id = id;
            this.money = money;
        }

        //method
        public override string ToString()
        {
            string user_name = "dbi396210";
            string user_password = "cvezQ2iLsb4ERq5g";
            string database = "dbi396210";
            string server = "studmysql01.fhict.local";
            using (MySqlConnection conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none"))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `customer` WHERE `CustomerID` = {id.ToString()} LIMIT 1", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    try
                    {
                        string name = "not found", email = "not found";
                        double balance = -1;
                        if (reader.Read())
                        {
                            name = Convert.ToString(reader["First_name"]) + " " + Convert.ToString(reader["Last_name"]);
                            email = Convert.ToString(reader["Email"]);
                            balance = Convert.ToDouble(reader["Balance"]);
                            conn.Close();
                        }
                        return $"{name}, email: {email}, deposit: {Money.ToString("N2")} balance: {balance}";
                    }
                    catch (Exception ex)
                    {
                        conn.Close();
                        return ex.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 4060:
                            return "Invalid Database";
                        case 18456:
                            return "Login Failed";
                        default:
                            return ex.ToString();
                    }
                }
            }
        }
    }
}
