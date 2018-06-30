using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Manager_Apps
{
    public class Manager
    {
        //Field
        private MySqlConnection conn;

        //Properties
        public List<Spot> Spots { get; private set; }
        public List<User> Customers { get; private set; }

        //Constructor
        public Manager()
        {
            //Connect with database
            string user_name = "dbi396210";
            string user_password = "cvezQ2iLsb4ERq5g";
            string database = "dbi396210";
            string server = "studmysql01.fhict.local";
            conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none;");
            Spots = new List<Spot>();
            Customers = new List<User>();
        }

        //Method

        /// <summary>
        /// Load 20 lowest product from database
        /// </summary>
        /// <returns>Dictionnary[20] </returns>
        public Dictionary<string, int> get20LowestProct()
        {
            Dictionary<string, int> products = new Dictionary<string, int>();

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT `Name`, `Stock` FROM `product` ORDER BY `Stock` ASC LIMIT 20;";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    products.Add(Convert.ToString(reader["Name"]), Convert.ToInt32(reader["Stock"]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return products;
        }

        /// <summary>
        /// Add 500 to stock for this product
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Query result</returns>
        public bool AddProduct(string name)
        {
            try
            {
                //Refresh data
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE `product` SET `Stock` = `Stock` + 100 WHERE `Name` LIKE '" + name + "'; ";

                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount < 1)
                {
                    throw new Exception("Fail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return true;
        }

        /// <summary>
        /// load all user info from database
        /// </summary>
        public void loadAllUser()
        {
            //Retrieve data from data base and create new object
            try
            {
                //Refresh data
                this.Customers.Clear();

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `customer` ORDER BY `CustomerID` ASC";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                User user = null;
                int id, spotNr;
                string name, email;
                DateTime dob;
                decimal balance;
                bool checkInEvent, checkInCamping;
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["CustomerID"]);
                    name = Convert.ToString(reader["First_name"]) + " " + Convert.ToString(reader["Last_name"]);
                    balance = Convert.ToDecimal(reader["Balance"]);
                    email = Convert.ToString(reader["Email"]);
                    dob = DateTime.Parse(Convert.ToString(reader["DOB"]));
                    checkInEvent = Convert.ToInt32(reader["CheckInEvent"]) == 0 ? false : true;
                    checkInCamping = Convert.ToInt32(reader["CheckInCamping"]) == 0 ? false : true;
                    checkInEvent = Convert.ToInt32(reader["CheckInEvent"]) == 0 ? false : true;
                    spotNr = Convert.ToInt32(reader["Camping_Spot_Nr"] is DBNull ? "-1" : reader["Camping_Spot_Nr"]);
                    user = new User(id, name, balance, email, dob, checkInEvent, checkInCamping, spotNr);
                    Customers.Add(user);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Load all spot from database and store in Spot list
        /// </summary>
        public void loadAllSpot()
        {
            //Refresh data

            //Retrieve data from data base and create new object
            try
            {
                this.Spots.Clear();

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM `campingspot` ORDER BY `CampingSpotNr` ASC";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                Spot spot = null;
                while (reader.Read())
                {
                    spot = new Spot(Convert.ToInt32(reader["CampingSpotNr"]), Convert.ToInt32(reader["numberOfPeople"]));
                    Spots.Add(spot);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Get all user of given spot
        /// </summary>
        /// <param name="spot"></param>
        /// <returns>List users of this spot</returns>
        public List<User> getSpotUser(Spot spot)
        {
            List<User> listUser = new List<User>();
            foreach(User user in Customers)
            {
                if(user.SpotNr == spot.Id)
                {
                    listUser.Add(user);
                }
            }
            return listUser;
        }

        /// <summary>
        /// Get the purchase status
        /// </summary>
        /// <returns>Array [nrSpot, eventTicket, product]</returns>
        public int[] Purchase()
        {
            int[] status = new int[3];
            //get nr of spot
            foreach(User user in Customers)
            {
                if(user.SpotNr != -1)
                {
                    status[0]++;
                }
            }
            status[0] *= 20;

            foreach (Spot spot in Spots)
            {
                if (spot.NrOfPeople != 0)
                {
                    status[0] += 10;
                }
            }

            //get event ticket purchase
            try
            {
                this.Spots.Clear();

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT (COUNT(CustomerID)*55) AS Total FROM `customer` WHERE ((RFID IS NOT NULL) OR (Barcode IS NOT NULL));";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status[1] = Convert.ToInt32(reader["Total"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            //get product purchase
            try
            {
                this.Spots.Clear();

                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT SUM(productquantity.Quantity * product.Price) as `Total` FROM productquantity, product WHERE productquantity.ProductID = product.ProductId";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    status[2] = Convert.ToInt32(reader["Total"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return status;
        }

        /// <summary>
        /// Get the camping spot for visitor
        /// </summary>
        /// <returns>Array [notInEvent, noSpot, InSpot, OutSpot]</returns>
        public int[] visitorCampingStatus()
        {
            int[] status = new int[4];
            foreach (User user in Customers)
            {
                if (!user.CheckInEvent)
                {
                    status[0]++;
                }
                else
                {
                    if (user.SpotNr == -1)
                    {
                        status[1]++;
                    }
                    else
                    {
                        if (user.CheckInCamping)
                            status[2]++;
                        else
                            status[3]++;
                    }
                }
            }
            return status;
        }

        /// <summary>
        /// Get the visitor age group
        /// </summary>
        /// <returns>Array ['smaler than 17', '18-39', 'older than 40']</returns>
        public int[] visitorAgeStatus()
        {
            int[] group = new int[3];
            foreach (User user in Customers)
            {
                if((DateTime.Now.Year - user.DoB.Year) <= 17)
                {
                    group[0]++;
                }
                else if ((DateTime.Now.Year - user.DoB.Year) >= 40)
                {
                    group[2]++;
                }
                else
                {
                    group[1]++;
                }
            }
            return group;
        }

        /// <summary>
        /// Search for user by string
        /// </summary>
        /// <param name="search"></param>
        /// <returns>List of user</returns>
        public List<User> findUser(string search)
        {
            List<User> users = new List<User>();
            foreach(User user in Customers)
            {
                if (user.ToString().ToLower().Contains(search))
                {
                    users.Add(user);
                }
            }
            return users;
        }
    }
}
