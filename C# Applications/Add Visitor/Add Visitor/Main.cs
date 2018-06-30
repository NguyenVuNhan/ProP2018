using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Phidget22;
using Phidget22.Events;

namespace Add_Visitor
{
    public partial class Main : Form
    {
        LoginWindow LoginPage;
        RFID myRFIDReader;
        MySqlConnection connection;
        string tag;
        int camp;
        List<string> friendscampings;
        List<string> campingspots;

        public Main()
        {
            InitializeComponent();
            string connectionInfo = "server=studmysql01.fhict.local;" + "database=dbi396210;" + "user id=dbi396210;" + "password=cvezQ2iLsb4ERq5g;" + "connect timeout=30;" + "SslMode = none;";
            connection = new MySqlConnection(connectionInfo);
            LoginPage = new LoginWindow();
            myRFIDReader = new RFID();
            myRFIDReader.Tag += MyRFIDReader_Tag;
            LoadingLoginWindow();
            LoginPage.LogInSuccessfull += this.OnLoginSuccess;
            friendscampings = new List<string>();
            campingspots = new List<string>();
            tag = null;
            RbNoSpot.Checked = true;
        }

        public void LoadingLoginWindow()
        {
            LoginPage.PreppingLoginForm();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        public void OnLoginSuccess(object source, LoginEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
            myRFIDReader.Open();
        }
        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            tag = e.Tag;
            lblInfo.ForeColor = Color.Green;
            lblInfo.Text = "RFID chip has been scanned.";
        }

        private int CheckIfIDExist(int customerid)
        {
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) FROM customer WHERE CustomerID='{customerid}'", connection);
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

        private int CheckIfRFIDExist(string rfid)
        {
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) FROM customer WHERE RFID='{rfid}'", connection);
            int returnvalue = 0;
            returnvalue = Convert.ToInt32(command.ExecuteScalar());
            return returnvalue;
        }

        private int CheckIfEmailExist(string email)
        {
            MySqlCommand command = new MySqlCommand($"SELECT COUNT(*) FROM customer WHERE Email='{email}'", connection);
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

        public static string md5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data 
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            friendscampings.Clear();
            campingspots.Clear();
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string firstname = tbFirstName.Text;
            string lastname = tbLastName.Text;
            string Date = tbDOB.Text;
            double balance;
            int nrofpeople = 0;
            int CustomerID = 1;
            if(email == "" || password == "" || firstname == "" || lastname == "")
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Please fill in all fields.";
                return;
            }

            if(tbPassword.TextLength < 8)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Password need to be longer that 8 characters.";
                return;
            }

            if (Double.TryParse(tbBalance.Text, out balance))
            {

            }
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Please enter a valid balance.";
                return;
            }
            
            if(balance < 5)
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Balance needs to be more than 5 euros.";
                return;
            }

            if (tag != null)
            {
                try
                {
                    while(CheckIfIDExist(CustomerID) != 0)
                    {
                        CustomerID++;
                    }

                    if(CheckIfEmailExist(email) != 0)
                    {
                        lblInfo.ForeColor = Color.Red;
                        lblInfo.Text = "Email already exists. Please enter a new email.";
                        return;
                    }

                    connection.Open();

                    // finding empty camping spot
                    if (RbSpot.Checked)
                    {
                        string cmd = "SELECT CampingSpotNr FROM campingspot WHERE numberOfPeople=0";
                        MySqlCommand Command = new MySqlCommand(cmd, connection);
                        MySqlDataReader reader = Command.ExecuteReader();

                        while (reader.Read())
                        {
                            campingspots.Add(reader["CampingSpotNr"].ToString());
                        }

                        reader.Close();

                        if (campingspots.Count != 0)
                        {
                            camp = Convert.ToInt32(campingspots[0]);
                        }

                        else
                        {
                            lblInfo.ForeColor = Color.Red;
                            lblInfo.Text = "No Free Camping Spots. Please select another option.";
                            return;
                        }

                    }
                    // finding number of friend camping spot 
                    if (RbFriendSpot.Checked)
                    {
                        if(tbCode.Text != null)
                        {
                            string cmd = "SELECT CampingSpotNr FROM campingspot WHERE invitationCode='" + tbCode.Text + "'";
                            MySqlCommand Command = new MySqlCommand(cmd, connection);
                            MySqlDataReader reader = Command.ExecuteReader();

                            while (reader.Read())
                            {
                                friendscampings.Add(reader.GetInt32(0).ToString());
                            }

                            reader.Close();

                            if (friendscampings.Count != 0)
                            {
                                camp = Convert.ToInt32(friendscampings[0]);
                                string cmd1 = "SELECT numberOfPeople FROM campingspot WHERE CampingSpotNr='" + camp + "'";
                                MySqlCommand Command1 = new MySqlCommand(cmd1, connection);
                                MySqlDataReader reader1 = Command1.ExecuteReader();
                                while (reader1.Read())
                                {
                                    nrofpeople = Convert.ToInt32(reader1["numberOfPeople"]);
                                }

                                reader1.Close();

                                if(nrofpeople > 5)
                                {
                                    lblInfo.ForeColor = Color.Red;
                                    lblInfo.Text = "That camping spot is already full.";
                                    return;
                                }

                            }

                            else
                            {
                                lblInfo.ForeColor = Color.Red;
                                lblInfo.Text = "No such invitation code exists.";
                                return;
                            }
                        }

                        else
                        {
                            lblInfo.ForeColor = Color.Red;
                            lblInfo.Text = "Please enter the invitation code.";
                            return;
                        }                        
                    }


                    if (RbNoSpot.Checked)
                    {
                        if(CheckIfRFIDExist(tag) == 0)
                        {
                            string send = $"INSERT INTO customer (CustomerID, First_name, Last_name, Balance, Email, Password, DOB, CheckInEvent, EventID, RFID) VALUES " +
                            $"('{CustomerID}', '{firstname}', '{lastname}', '{balance}', '{email}', '{md5(password)}', '{Date}', 1, 1, '{tag}')";
                            MySqlCommand insert = new MySqlCommand(send, connection);
                            int number = insert.ExecuteNonQuery();
                            if (number == 1)
                            {
                                lblInfo.ForeColor = Color.Green;
                                lblInfo.Text = "Visitor has been succesfully added.";

                                timer1.Start();
                            }
                        }

                        else
                        {
                            lblInfo.ForeColor = Color.Red;
                            lblInfo.Text = "There is someone with that RFID already. Please try a new RFID.";
                        }
                        
                    }
                    else
                    {
                        if(CheckIfRFIDExist(tag) == 0)
                        {
                            string send = $"INSERT INTO customer (CustomerID, First_name, Last_name, Balance, Email, Password, DOB, CheckInEvent, Camping_Spot_Nr, EventID, RFID) VALUES " +
                            $"('{CustomerID}', '{firstname}', '{lastname}', '{balance}', '{email}', '{md5(password)}', '{Date}', 1, '{camp}', 1, '{tag}')";
                            MySqlCommand insert = new MySqlCommand(send, connection);

                            string update = $"UPDATE campingspot SET numberOfPeople='{nrofpeople + 1}' WHERE CampingSpotNr='{camp}'";
                            MySqlCommand insert1 = new MySqlCommand(update, connection);
                            int number = insert.ExecuteNonQuery();
                            number = insert1.ExecuteNonQuery();
                            lblInfo.ForeColor = Color.Green;
                            lblInfo.Text = "Visitor has been succesfully added." + "Camping Spot is " + camp;
                            timer1.Start();
                        }

                        else
                        {
                            lblInfo.ForeColor = Color.Red;
                            lblInfo.Text = "There is someone with that RFID already. Please try a new RFID.";
                        }
                    }
                }

                catch(MySqlException)
                {
                    lblInfo.ForeColor = Color.Red;
                    lblInfo.Text = "Unable to connect to the database. Check your connection.";
                }
                finally
                {
                    if(connection != null)
                    {
                        connection.Close();
                    }                    
                }
            }
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "Please scan a RFID to continue.";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            tbEmail.Clear();
            tbPassword.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbCode.Clear();
            tbBalance.Text = "0";
            tag = null;
            timer1.Stop();
        }
    }
}
