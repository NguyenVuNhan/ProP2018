using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Manager_Apps
{
    public partial class Employee : UserControl
    {
        private MySqlConnection conn;
        private Timer time;
        private int id;
        public Employee()
        {
            InitializeComponent();

            string user_name = "dbi396210";
            string user_password = "cvezQ2iLsb4ERq5g";
            string database = "dbi396210";
            string server = "studmysql01.fhict.local";
            conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none;");

            time = new Timer();
            time.Enabled = false;
            time.Tick += (e, o) =>
            {
                UpdateControlForm();
            };
        }

        public void UpdateControlForm()
        {
            //Update borrowing
            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM `employee`;", conn);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dataSet = new DataTable();
                sda.Fill(dataSet);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dataSet;
                data_Employee.DataSource = bSource;
                sda.Update(dataSet);
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        private void data_Employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit this employee?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (e.RowIndex >= 0)
                {
                    this.bt_Edit.Enabled = true;
                    bt_Add.Enabled = false;
                    DataGridViewRow row = this.data_Employee.Rows[e.RowIndex];

                    this.tb_firstName.Text = row.Cells["FirstName"].Value.ToString();
                    this.tb_lastName.Text = row.Cells["LastName"].Value.ToString();
                    this.tb_UserName.Text = row.Cells["User_name"].Value.ToString();
                    this.tb_Email.Text = row.Cells["Email"].Value.ToString();
                    this.tb_Job.Text = row.Cells["Job"].Value.ToString();
                    id = Convert.ToInt32(row.Cells["EmployeeID"].Value);
                }
                else
                {
                    this.bt_Edit.Enabled = false;
                    bt_Add.Enabled = true;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                data_Employee.ClearSelection();
                tb_UserName.Text = "";
                tb_Password.Text = "";
                tb_lastName.Text = "";
                tb_Job.Text = "";
                tb_firstName.Text = "";
                tb_Email.Text = "";
                tb_ConfirmPassword.Text = "";
                id = 0;
                this.bt_Edit.Enabled = false;
                bt_Add.Enabled = true;
                UpdateControlForm();
            }
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (tb_Email.Text == "" || tb_firstName.Text == "" || tb_Job.Text == "" || tb_lastName.Text == "" || tb_UserName.Text == "" || tb_Password.Text == "" || tb_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (tb_Password.Text != tb_ConfirmPassword.Text)
            {
                MessageBox.Show("Password and confirm password field are different!");
                return;
            }

            try
            {
                //Refresh data
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO `employee` (`EventID`, `FirstName`, `LastName`, `User_name`, `Password`, `Email`, `Job`) " +
                                    $"VALUES ('1', '{tb_firstName.Text}', '{tb_lastName.Text}', '{tb_UserName.Text}', '{md5(tb_Password.Text)}', '{tb_Email.Text}', '{tb_Job.Text}');";

                int rowCount = cmd.ExecuteNonQuery();

                if (rowCount < 1)
                {
                    throw new Exception("Failed");
                }

                else
                {
                    data_Employee.ClearSelection();
                    tb_UserName.Text = "";
                    tb_Password.Text = "";
                    tb_lastName.Text = "";
                    tb_Job.Text = "";
                    tb_firstName.Text = "";
                    tb_Email.Text = "";
                    tb_ConfirmPassword.Text = "";
                    id = 0;
                    this.bt_Edit.Enabled = false;
                    bt_Add.Enabled = true;
                    UpdateControlForm();
                }
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
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

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (bt_Edit.Enabled)
            {
                if (tb_Email.Text == "" || tb_firstName.Text == "" || tb_Job.Text == "" || tb_lastName.Text == "" || tb_UserName.Text == "" || tb_Password.Text == "" || tb_ConfirmPassword.Text == "")
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (tb_Password.Text != tb_ConfirmPassword.Text)
                {
                    MessageBox.Show("Password and confirm password field are different!");
                    return;
                }
                try
                {
                    //Refresh data
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = $"UPDATE `employee`" +
                                        $"SET `EventID` = '1', `FirstName`='{tb_firstName.Text}', `LastName`='{tb_lastName.Text}', `User_name`= '{tb_UserName.Text}', `Password`='{md5(tb_Password.Text)}', `Email`='{tb_Email.Text}', `Job`='{tb_Job.Text}'" + 
                                        $"WHERE `EmployeeID` LIKE '{id}';";
                    Console.WriteLine($"UPDATE `employee`" +
                                        $"SET `EventID` = '1', `FirstName`='{tb_firstName.Text}', `LastName`='{tb_lastName.Text}', `User_name`= '{tb_UserName.Text}', `Password`='{md5(tb_Password.Text)}', `Email`='{tb_Email.Text}', `Job`='{tb_Job.Text}'" +
                                        $"WHERE `EmployeeID` LIKE '{id}';");
                    int rowCount = cmd.ExecuteNonQuery();

                    if (rowCount < 1)
                    {
                        throw new Exception("Failed to update employee.");
                    }

                    else
                    {
                        data_Employee.ClearSelection();
                        tb_UserName.Text = "";
                        tb_Password.Text = "";
                        tb_lastName.Text = "";
                        tb_Job.Text = "";
                        tb_firstName.Text = "";
                        tb_Email.Text = "";
                        tb_ConfirmPassword.Text = "";
                        id = 0;
                        this.bt_Edit.Enabled = false;
                        bt_Add.Enabled = true;
                        UpdateControlForm();
                    }
                }
                catch (MySqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void bt_refreshAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.time.Enabled)
                {
                    this.time.Enabled = false;
                    this.bt_refreshAuto.Text = "Enable Auto Refresh";
                }
                else
                {
                    this.time.Enabled = true;
                    this.time.Interval = Convert.ToInt32(this.tb_fequency.Text)*1000;
                    this.bt_refreshAuto.Text = $"Disable Auto Refresh ({(this.time.Interval/1000).ToString()}s)";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please check the interval data again");
            }
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            UpdateControlForm();
        }

        private void data_Employee_SelectionChanged(object sender, EventArgs e)
        {
           
        }
    }
}