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
using System.Media;

namespace Event_CheckInOut
{
    public partial class Main : Form
    {
        LoginWindow LoginPage;
        RFID myRFIDReader;
        MySqlConnection connection;
        Color controlBackColor;

        public Main()
        {
            InitializeComponent();
            string connectionInfo = "server=studmysql01.fhict.local;" + "database=dbi396210;" + "user id=dbi396210;" + "password=cvezQ2iLsb4ERq5g;" + "connect timeout=30;" + "SslMode = none;";
            connection = new MySqlConnection(connectionInfo);
            LoginPage = new LoginWindow();
            myRFIDReader = new RFID();
            LoadingLoginWindow();
            myRFIDReader.Tag += MyRFIDReader_Tag;
            LoginPage.LogInSuccessfull += this.OnLoginSuccess;
            controlBackColor = BackColor;
            pbMain.Hide();
            pbMain.SizeMode = PictureBoxSizeMode.StretchImage;
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

        public int CheckForBorrowable(string rfid)
        {
            string sqlCmd = "SELECT CustomerID FROM customer WHERE RFID = '" + rfid + "'";
            MySqlCommand CommandCheck = new MySqlCommand(sqlCmd, connection);
            MySqlDataReader reader = CommandCheck.ExecuteReader();
            List<int> customerid = new List<int>();
            while (reader.Read())
            {
                customerid.Add(Convert.ToInt32(reader["CustomerID"]));
            }
            reader.Close();

            string cmd = $"SELECT COUNT(*) FROM borrowing WHERE CustomerID='{customerid[0]}' AND Status='BORROWED'";
            MySqlCommand CommandCheck1 = new MySqlCommand(cmd, connection);
            int Exist = 0;
            Exist = Convert.ToInt32(CommandCheck1.ExecuteScalar());
            return Exist;
        }

        public double CheckBalance(string rfid)
        {
            string sqlCmd = "SELECT Balance FROM customer WHERE RFID = '" + rfid + "'";
            MySqlCommand CommandCheck = new MySqlCommand(sqlCmd, connection);
            MySqlDataReader reader = CommandCheck.ExecuteReader();
            List<double> balance = new List<double>();
            while (reader.Read())
            {
                balance.Add(Convert.ToDouble(reader["Balance"]));
            }
            reader.Close();

            return balance[0];
        }

        public int CheckBarcode(string barcode)
        {
            string sqlCmd = "SELECT COUNT(*) FROM customer WHERE Barcode='" + barcode + "'";
            MySqlCommand CommandCheck = new MySqlCommand(sqlCmd, connection);
            int Exist1 = Convert.ToInt32(CommandCheck.ExecuteScalar());
            return Exist1;
        }

        private void playaudiosucces()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources._1);
            audio.Play();
        }
        private void playaudiofail()
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources._2);
            audio.Play();
        }

        private void MyRFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            try
            {
                string sqlCmd = "SELECT COUNT(*) FROM customer WHERE RFID = '" + e.Tag + "'";
                connection.Open();
                MySqlCommand CommandCheck = new MySqlCommand(sqlCmd, connection);
                int Exist = Convert.ToInt32(CommandCheck.ExecuteScalar());
                if (Exist == 1)
                {
                    string sqlCmd1 = "SELECT COUNT(*) FROM customer WHERE RFID = '" + e.Tag + "' AND CheckInEvent = '1'";
                    MySqlCommand CommandCheck1 = new MySqlCommand(sqlCmd1, connection);
                    int Exist1 = Convert.ToInt32(CommandCheck1.ExecuteScalar());
                    if (Exist1 == 1)
                    {
                        if(CheckForBorrowable(e.Tag) == 0)
                        {
                            double balance = CheckBalance(e.Tag);
                            if(balance > 0)
                            {
                                string sqlCmd2 = "UPDATE customer SET CheckInEvent = " + 0 + " WHERE RFID = '" + e.Tag + "'";
                                string sqlCmd3 = "UPDATE customer SET Balance ='0' WHERE RFID = '" + e.Tag + "'";
                                MySqlCommand CommandCheck2 = new MySqlCommand(sqlCmd2, connection);
                                int Exist2 = Convert.ToInt32(CommandCheck2.ExecuteScalar());
                                MySqlCommand CommandCheck3 = new MySqlCommand(sqlCmd3, connection);
                                int Exist3 = Convert.ToInt32(CommandCheck3.ExecuteScalar());
                                LbInfo.ForeColor = Color.Green;
                                LbInfo.Text = "Checked Out Successfully ";
                                lblReturn.Text = $"Return {balance} euros to the customer.";
                                playaudiosucces();
                                pbMain.Image = Properties.Resources.Check;
                                pbMain.Show();
                                timer2.Enabled = true;
                            }

                            else
                            {
                                string sqlCmd2 = "UPDATE customer SET CheckInEvent = " + 0 + " WHERE RFID = '" + e.Tag + "'";
                                MySqlCommand CommandCheck2 = new MySqlCommand(sqlCmd2, connection);
                                int Exist2 = Convert.ToInt32(CommandCheck2.ExecuteScalar());
                                LbInfo.ForeColor = Color.Green;
                                LbInfo.Text = "Checked Out Successfully ";
                                playaudiosucces();
                                pbMain.Image = Properties.Resources.Check;
                                pbMain.Show();
                                timer1.Enabled = true;
                            }
                        }

                        else
                        {
                            LbInfo.ForeColor = Color.Red;
                            LbInfo.Text = "Has items that needs to be returned.";
                            pbMain.Image = Properties.Resources.Error;
                            pbMain.Show();
                            playaudiofail();
                            timer1.Enabled = true;
                        }
                        
                    }
                    else
                    {
                        string sqlCmd3 = "UPDATE customer SET CheckInEvent ='1' WHERE RFID = '" + e.Tag + "'";
                        MySqlCommand CommandCheck3 = new MySqlCommand(sqlCmd3, connection);
                        int Exist3 = Convert.ToInt32(CommandCheck3.ExecuteScalar());
                        LbInfo.ForeColor = Color.Green;
                        LbInfo.Text = "Checked In Successfully";
                        pbMain.Image = Properties.Resources.Check;
                        pbMain.Show();
                        playaudiosucces();
                        timer1.Enabled = true;
                    }
                }
                else
                {
                    if (LbReturn.Text.Length == 12)
                    {
                        if(CheckBarcode(LbReturn.Text) > 0)
                        {
                            string sqlCmd3 = "UPDATE customer SET RFID = '" + e.Tag + "', CheckInEvent = " + 1 + " WHERE Barcode = '" + LbReturn.Text + "'";
                            MySqlCommand CommandCheck3 = new MySqlCommand(sqlCmd3, connection);
                            int Exist3 = Convert.ToInt32(CommandCheck3.ExecuteScalar());
                            LbInfo.ForeColor = Color.Green;
                            LbInfo.Text = "Checked In Successfully.";
                            lblReturn.Text = "Customer has been assigned an RFID.";
                            LbAlert.Text = "";
                            playaudiosucces();
                            pbMain.Image = Properties.Resources.Check;
                            pbMain.Show();
                            timer1.Enabled = true;
                        }
                    }

                    else
                    {
                        LbAlert.ForeColor = Color.DarkOrange;
                        LbAlert.Text = "New RFID detected. Enter barcode.";
                        timer1.Enabled = true;
                    }
                }
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LbInfo.Text = "";
            LbAlert.Text = "";
            LbReturn.Text = "";
            lblReturn.Text = "";
            pbMain.Hide();
            TbReturnValue.Clear();
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LbInfo.Text = "";
            LbAlert.Text = "";
            LbReturn.Text = "";
            lblReturn.Text = "";
            pbMain.Hide();
            TbReturnValue.Clear();
            timer2.Enabled = false;
        }

        private void TbReturnValue_TextChanged(object sender, EventArgs e)
        {
            if (TbReturnValue.TextLength == 12)
            {
                string sqlCmd = "SELECT COUNT(*) FROM customer WHERE Barcode = '" + TbReturnValue.Text + "'";
                try
                {
                    connection.Open();
                    MySqlCommand CommandCheck = new MySqlCommand(sqlCmd, connection);
                    int Exist = Convert.ToInt32(CommandCheck.ExecuteScalar());
                    if (Exist > 0)
                    {
                        LbReturn.Text = TbReturnValue.Text;
                        LbAlert.ForeColor = Color.Green;
                        LbAlert.Text = "Scan a new RFID.";
                        pbMain.Image = Properties.Resources.Check;
                        pbMain.Show();
                    }
                    else
                    {
                        LbAlert.ForeColor = Color.Red;
                        LbAlert.Text = "Ticket does not exist.";
                        TbReturnValue.Clear();
                        playaudiofail();
                        pbMain.Image = Properties.Resources.Error;
                        pbMain.Show();
                        timer1.Enabled = true;
                    }
                }

                catch (MySqlException)
                {
                    MessageBox.Show("Unable to reach the database. Check your connection.");
                }
                finally
                {
                    if(connection != null)
                    {
                        connection.Close(); connection.Close();
                    }
                }
            }
        }
    }
}
