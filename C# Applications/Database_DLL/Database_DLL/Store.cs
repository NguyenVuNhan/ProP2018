using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Database_DLL
{
    public class Store
    {
        private string connectionInfo;
        MySqlConnection connection;
        MySqlCommand command;
        MySqlCommand command1;
        MySqlCommand command2;
        MySqlDataReader myReader;

        public Store()
        {
            connectionInfo = "server=studmysql01.fhict.local;" + "database=dbi396210;" + "user id=dbi396210;"
                           + "password=cvezQ2iLsb4ERq5g;" + "connect timeout=30;" + "SslMode = none;";

            connection = new MySqlConnection(connectionInfo);
        }

        public string GetStoreImagesPath(string table, int productid)
        {
            command = new MySqlCommand($"SELECT ImagePath FROM {table} WHERE ProductId='{productid}'", connection);

            string ImagePath = "";

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    ImagePath = (myReader["ImagePath"]).ToString();
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return ImagePath;
        }

        public int CheckEmployee(string username, string password)
        {
            command = new MySqlCommand($"SELECT COUNT(*) FROM employee WHERE User_name='{username}' AND Password='{password}'", connection);

            int returnvalue = 0;

            try
            {
                connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnvalue;
        }

        public string GetEmployeeJob(string username, string password)
        {
            command = new MySqlCommand($"SELECT Job FROM employee WHERE User_name='{username}' AND Password='{password}'", connection);

            string job = "";

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    job = (myReader["Job"]).ToString();
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return job;
        }

        public List<string> GetEmployeeData(string username, string password)
        {
            command = new MySqlCommand($"SELECT * FROM employee WHERE User_name='{username}' AND Password='{password}'", connection);

            List<string> returnedData = new List<string>();

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    for (int i = 0; i < 9; i++)
                    {
                        returnedData.Add(myReader[i].ToString());
                    }
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnedData;
        }

        public List<string> GetCostumerData(string rfid)
        {
            command = new MySqlCommand($"SELECT * FROM customer WHERE RFID='{rfid}'", connection);

            List<string> returnedData = new List<string>();

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    for (int i = 0; i < 14; i++)
                    {
                        returnedData.Add(myReader[i].ToString());
                    }
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnedData;
        }

        public int CheckIfPurchaseIDExist(int customerid, int purchaseid)
        {
            command = new MySqlCommand($"SELECT COUNT(*) FROM purchase WHERE CustomerID='{customerid}' AND PurchaseID='{purchaseid}'", connection);

            int returnvalue = 0;

            try
            {
                connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnvalue;
        }

        public List<string> GetItem(string table, int id)
        {
            int indexarray = 6;

            command = new MySqlCommand($"SELECT * FROM {table} WHERE ProductId='{id}'", connection);

            if(table == "product")
            {
                indexarray = 7;
            }

            List<string> returnedData = new List<string>();

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    for (int i = 0; i < indexarray; i++)
                    {
                        returnedData.Add(myReader[i].ToString());
                    }
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnedData;
        }

        public void ProcessOrder(int customerid, int purchaseid, double newbalance)
        {
            string SqlDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            command = new MySqlCommand($"INSERT INTO purchase VALUES ({purchaseid},{customerid},'{SqlDateTime}')", connection);
            command1 = new MySqlCommand($"UPDATE customer SET Balance='{newbalance}' WHERE CustomerID={customerid}", connection);

            try
            {
                connection.Open();
                int processOrder;
                processOrder = command.ExecuteNonQuery();
                processOrder = command1.ExecuteNonQuery();
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void ProcessItem(int purchaseid, int productid, int customerid, int quantity, int leftinstock)
        {
            command = new MySqlCommand($"INSERT INTO productquantity VALUES ({productid},{purchaseid},{customerid},{quantity})", connection);
            command1 = new MySqlCommand($"UPDATE product SET Stock='{leftinstock}' WHERE ProductId={productid}", connection);

            try
            {
                connection.Open();
                int processitem;
                processitem = command.ExecuteNonQuery();
                processitem = command1.ExecuteNonQuery();
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public int CheckForExistingLoan(int customerid, int itemid)
        {
            command = new MySqlCommand($"SELECT COUNT(*) FROM borrowing WHERE CustomerID='{customerid}' AND ItemID='{itemid}'", connection);

            int returnvalue = 0;

            try
            {
                connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnvalue;
        }

        public void ProcessLoanOrder(int customerid, int itemid, int quantity, int leftinstock, double newbalance)
        {
            int quantityOnDB = CheckForExistingLoan(customerid, itemid);
            int itemnumber = quantityOnDB + 1;
            string SqlDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            command1 = new MySqlCommand($"UPDATE customer SET Balance='{newbalance}' WHERE CustomerID={customerid}", connection);
            command2 = new MySqlCommand($"UPDATE borrowable SET Quantity='{leftinstock}' WHERE ProductId={itemid}", connection);

            try
            {
                connection.Open();
                int processorder;
                processorder = command1.ExecuteNonQuery();
                processorder = command2.ExecuteNonQuery();
                for (int i = 0; i < quantity; i++)
                {
                    command = new MySqlCommand($"INSERT INTO borrowing (CustomerID, ItemID, ItemNumber, DateBorrowed, Status) VALUES ({customerid},{itemid},{itemnumber},'{SqlDateTime}','BORROWED')", connection);
                    processorder = command.ExecuteNonQuery();
                    itemnumber++;
                }                
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public int GetItemsToReturn(int customerid)
        {
            command = new MySqlCommand($"SELECT COUNT(*) FROM borrowing WHERE CustomerID='{customerid}' AND Status='BORROWED'", connection);

            int returnvalue = 0;

            try
            {
                connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnvalue;
        }

        public List<string> GetBorrowingData(int customerid)
        {
            command = new MySqlCommand($"SELECT ItemID, ItemNumber FROM borrowing WHERE CustomerID='{customerid}' AND Status='BORROWED'", connection);

            List<string> returnedData = new List<string>();

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    returnedData.Add(myReader["ItemID"].ToString() + "," + myReader["ItemNumber"].ToString());
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnedData;
        }

        public string GetItemName(int itemid)
        {
            command = new MySqlCommand($"SELECT Name, Penalty FROM borrowable WHERE ProductId='{itemid}'", connection);

            string Name = "";

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    Name = (myReader["Name"]).ToString() + "-" + (myReader["Penalty"]).ToString();
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return Name;
        }

        public void ProcessReturnItem(int customerid, int itemid, int itemnumber, string returnstatus)
        {
            string SqlDateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            command = new MySqlCommand($"UPDATE borrowing SET DateReturned='{SqlDateTime}', Status='RETURNED', ReturnStatus='{returnstatus}' WHERE CustomerID='{customerid}' AND ItemID='{itemid}' AND ItemNumber='{itemnumber}'", connection);

            try
            {
                connection.Open();
                int processorder;
                processorder = command.ExecuteNonQuery();
            }

            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        public void ProcessReturnStockBalance(int customerid, double balance, int itemid, int quantity)
        {
            command = new MySqlCommand($"UPDATE customer SET Balance='{balance}' WHERE CustomerID={customerid}", connection);
            command1 = new MySqlCommand($"UPDATE borrowable SET Quantity='{quantity}' WHERE ProductId={itemid}", connection);

            try
            {
                connection.Open();
                int processorder;
                processorder = command.ExecuteNonQuery();
                processorder = command1.ExecuteNonQuery();

            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

        }

        public int GetQuantity(int itemid, string table)
        {
            command = new MySqlCommand($"SELECT Quantity FROM {table} WHERE ProductId='{itemid}'", connection);

            int returnedint = 0;

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    returnedint = Convert.ToInt32(myReader["Quantity"]);
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnedint;

        }

        public byte[] GetImage(int itemid, string table)
        {
            byte[] returnarray = new byte[0];
            if(table == "borrowable")
            {
                command = new MySqlCommand($"SELECT Image FROM borrowable WHERE ProductId='{itemid}'", connection);
            }

            else
            {
                command = new MySqlCommand($"SELECT Image FROM product WHERE ProductId='{itemid}'", connection);
            }

            try
            {
                connection.Open();
                myReader = null;
                myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    returnarray = null;
                    returnarray = (byte[])(myReader["Image"]);
                }
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnarray;

        }

        public int GetNumberOfBorrowables()
        {
            command = new MySqlCommand($"SELECT COUNT(*) FROM borrowable", connection);

            int returnvalue = 0;

            try
            {
                connection.Open();
                returnvalue = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            return returnvalue;
        }

        public string GetNumberOfProducts()
        {
            int returnvalue1 = 0;
            int returnvalue2 = 0;
            int returnvalue3 = 0;

            command = new MySqlCommand($"SELECT COUNT(*) FROM product WHERE Category='Food'", connection);

            try
            {
                connection.Open();
                returnvalue1 = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            command = new MySqlCommand($"SELECT COUNT(*) FROM product WHERE Category='Drink'", connection);

            try
            {
                connection.Open();
                returnvalue2 = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            command = new MySqlCommand($"SELECT COUNT(*) FROM product WHERE Category='Souvenir'", connection);

            try
            {
                connection.Open();
                returnvalue3 = Convert.ToInt32(command.ExecuteScalar());
            }

            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }

            string returnstring = $"{returnvalue1},{returnvalue2},{returnvalue3}";

            return returnstring;
        }
    }
}

