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

namespace Manager_Apps
{
    public partial class VisitorInfo : Form
    {
        private MySqlConnection conn;
        private User user;
        public VisitorInfo()
        {
            InitializeComponent();

            string user_name = "dbi396210";
            string user_password = "cvezQ2iLsb4ERq5g";
            string database = "dbi396210";
            string server = "studmysql01.fhict.local";
            conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none;");
        }

        public void Update(User user)
        {
            this.user = user;
            UpdateDataBorrowing();
            UpdateDataPurchase();

            this.tb_Id.Text = user.Id.ToString();
            this.tb_Name.Text = user.Name;
            this.tb_Email.Text = user.Email;
            this.tb_Balance.Text = user.Balance.ToString();
            this.tb_DoB.Text = user.DoB.ToString();
            if (user.CheckInEvent)
            {
                this.cb_event.Checked = true;
            }
            else
            {
                this.cb_event.Checked = false;
            }
            if (user.CheckInCamping)
            {
                this.cb_camping.Checked = true;
            }
            else
            {
                this.cb_camping.Checked = false;
            }
        }

        public void UpdateDataBorrowing()
        {
            //Update borrowing
            MySqlCommand cmd = new MySqlCommand($"SELECT `Name`, `DateBorrowed` FROM `borrowing`, `borrowable` WHERE (`ProductId` = `ItemID`) AND (`CustomerID` = {user.Id});", conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dataSet;
                data_borrowing.DataSource = bSource;
                sda.Update(dataSet);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        public void UpdateDataPurchase()
        {
            //Update borrowing
            MySqlCommand cmd = new MySqlCommand($"SELECT `Name`, `Quantity`, `DateOfPurchase` FROM `purchase`, `product`, `productquantity` WHERE (purchase.PurchaseID = productquantity.PurchaseID) AND (product.ProductId = productquantity.ProductID) AND (purchase.CustomerID = {user.Id});", conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                BindingSource bSource = new BindingSource();

                data_Purchase.DataSource = dataSet;
                sda.Update(dataSet);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        private void bt_barCode_Click(object sender, EventArgs e)
        {
            try
            {
                //Refresh data
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE `customer` SET `Barcode` = {Convert.ToInt64(DateTime.Now.ToString("HHmmssffff"))*1000 + user.Id} WHERE `CustomerID` = {user.Id}; ";

                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount < 1)
                {
                    throw new Exception("Fail");
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

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
