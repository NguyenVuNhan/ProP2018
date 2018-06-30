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

namespace Camping_CheckIn_CheckOut
{
    public partial class Main : Form
    {
        LoginWindow LoginPage;
        RFID myRFIDReader;
        MySqlConnection connection;

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
            pbMain.Hide();
            pbMain.SizeMode = PictureBoxSizeMode.StretchImage;
            timer1.Enabled = true;
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
                connection.Open();
                //Checking if visitor has Camping Spot
                string sqlCmd1 = "SELECT COUNT(*) FROM customer WHERE RFID = '" + e.Tag + "' AND Camping_Spot_Nr IS NOT NULL";
                MySqlCommand CommandCheck1 = new MySqlCommand(sqlCmd1, connection);
                int Exist1 = Convert.ToInt32(CommandCheck1.ExecuteScalar());
                if (Exist1 == 1)
                {
                    // Checking if visitor needs to check in or out 
                    string sqlCmd2 = "SELECT COUNT(*) FROM customer WHERE RFID = '" + e.Tag + "' AND CheckInCamping='0'";
                    MySqlCommand CommandCheck2 = new MySqlCommand(sqlCmd2, connection);
                    int Exist2 = Convert.ToInt32(CommandCheck2.ExecuteScalar());
                    if (Exist2 == 1)
                    {
                        string sqlCmd3 = "UPDATE customer SET CheckInCamping='1' WHERE RFID ='" + e.Tag + "'";
                        MySqlCommand CommandCheck3 = new MySqlCommand(sqlCmd3, connection);
                        int Exist3 = Convert.ToInt32(CommandCheck3.ExecuteScalar());
                        Lbinfo.ForeColor = Color.Green;
                        Lbinfo.Text = "Camp checked in successfully";
                        playaudiosucces();
                        pbMain.Image = Properties.Resources.Check;
                        pbMain.Show();
                        timer1.Start();
                    }
                    else
                    {
                            string sqlCmd4 = "UPDATE customer SET CheckInCamping='0' WHERE RFID ='" + e.Tag + "'";
                            MySqlCommand CommandCheck4 = new MySqlCommand(sqlCmd4, connection);
                            int Exist4 = Convert.ToInt32(CommandCheck4.ExecuteScalar());
                            Lbinfo.ForeColor = Color.Green;
                            Lbinfo.Text = "Camp checked out successfully";
                            playaudiosucces();
                            pbMain.Image = Properties.Resources.Check;
                            pbMain.Show();
                            timer1.Start();
                    }
                }
                else
                {
                    Lbinfo.ForeColor = Color.Red;
                    Lbinfo.Text = "No camping spot registered for customer.";
                    pbMain.Image = Properties.Resources.Error;
                    pbMain.Show();
                    playaudiofail();
                    timer1.Start();
                }
            }

            catch(MySqlException)
            {
                MessageBox.Show("Unable to reach the database. Please check your connection.");
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
            Lbinfo.ForeColor = Color.Green;
            Lbinfo.Text = "";
            pbMain.Hide();
            timer1.Enabled = false;
        }
    }
}
