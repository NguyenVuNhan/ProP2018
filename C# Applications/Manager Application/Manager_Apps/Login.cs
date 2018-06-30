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
    public partial class Login : UserControl
    {
        private MySqlConnection conn;
        public delegate void LoginHandler(Login sender, string message);
        public event LoginHandler login;

        public string managerName { get; private set; }
        public bool IsLoggedIn { get; private set; } = false;
        public Login()
        {
            InitializeComponent();

            string user_name = "dbi396210";
            string user_password = "cvezQ2iLsb4ERq5g";
            string database = "dbi396210";
            string server = "studmysql01.fhict.local";
            conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none;");
        }

        public void Logout()
        {
            this.IsLoggedIn = false;
            this.tb_username.Text = "";
            this.tb_password.Text = "";
            this.tb_password.PasswordChar = '*';
            this.ch_ShowPassword.Checked = false;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            //Retrieve data from data base and create new object
            try
            {
                //Refresh data
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `employee` WHERE (`User_name` LIKE '{tb_username.Text}') AND (`Password` LIKE '{md5(tb_password.Text)}') AND (`Job` = 'Manager');";
                MySqlDataReader reader;

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    this.IsLoggedIn = true;
                    this.managerName = tb_username.Text;
                    login(this, "Login Success");
                }
                else
                {
                    login(this, "Please check your account again, make sure that your password is correct and this is manager account");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                this.tb_username.Text = this.tb_password.Text = "";
                login(this, "Error connecting to the database. Please check your connection.");
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

        private void ch_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_ShowPassword.Checked)
            {
                this.tb_password.PasswordChar = '\0';
            }
            else
            {
                this.tb_password.PasswordChar = '*';
            }
        }
    }
}
