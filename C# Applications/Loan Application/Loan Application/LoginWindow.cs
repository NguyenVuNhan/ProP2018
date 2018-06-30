using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_DLL;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Loan_Application
{
    public partial class LoginWindow : Form
    {
        Store DBLogin;
        public LoginWindow()
        {
            InitializeComponent();
            PreppingLoginForm();
            DBLogin = new Store();
        }

        public void PreppingLoginForm()
        {
            lblError.Text = "";
            lblError.Visible = false;
            tbUsername.Text = "";
            tbPassword.Text = "";
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }

        public delegate void LogInSuccessEventHandler(object source, LoginEventArgs args);

        public event LogInSuccessEventHandler LogInSuccessfull;

        protected virtual void OnLogInSuccess(string username, string password)
        {
            if (LogInSuccessfull != null)
            {
                LogInSuccessfull(this, new LoginEventArgs() { Username = username, Password = password });
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = md5(tbPassword.Text);

            try
            {
                if (DBLogin.CheckEmployee(username, password) == 1)
                {
                    if ((DBLogin.GetEmployeeJob(username, password)).ToLower().Contains("clerk") || (DBLogin.GetEmployeeJob(username, password)).ToLower().Contains("manager"))
                    {
                        OnLogInSuccess(username, password);
                        this.WindowState = FormWindowState.Minimized;
                        this.ShowInTaskbar = false;
                    }

                    else
                    {
                        lblError.Text = "You are not allowed to use this application.";
                        lblError.Visible = true;
                        tbUsername.Text = "";
                        tbPassword.Text = "";
                    }
                }

                else
                {
                    lblError.Text = "Wrong username and password combination.";
                    lblError.Visible = true;
                    tbUsername.Text = "";
                    tbPassword.Text = "";
                }
            }

            catch (MySqlException)
            {
                MessageBox.Show("Check your connection. Unable to reach the database.");
            }

            finally
            {
                tbUsername.Text = "";
                tbPassword.Text = "";
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    public class LoginEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
