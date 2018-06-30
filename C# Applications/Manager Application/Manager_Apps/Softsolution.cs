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
    public partial class Softsolution : Form
    {
        public static Manager manager;
        private Timer timer;

        public Softsolution()
        {
            manager = new Manager();
            InitializeComponent();

            //update data
            this.UpdateControlForm();
            employee.UpdateControlForm();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += (o, e) =>
            {
                try
                {
                    this.UpdateControlForm();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            };

            login.login += (s, m) =>
            {
                MessageBox.Show(m);
                if (s.IsLoggedIn)
                {
                    this.bt_camping.Enabled = true;
                    this.bt_StockManager.Enabled = true;
                    this.bt_visitor.Enabled = true;
                    this.bt_employee.Enabled = true;
                    this.bt_Login.Text = "Logout";

                    this.login.Visible = false;

                    this.bt_camping_Click(this, null);

                    this.lbl_status.Text = login.managerName;

                    timer.Enabled = true;
                }
                else
                {
                    this.Form1_Load(this, null);
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.campingSpot.Visible = false;
            this.stockManager.Visible = false;
            this.visitor.Visible = false;
            this.employee.Visible = false;

            this.bt_camping.Enabled = false;
            this.bt_StockManager.Enabled = false;
            this.bt_visitor.Enabled = false;
            this.bt_employee.Enabled = false;

            //Set cursor position
            this.panel3.Height = bt_Login.Height;
            this.panel3.Top = bt_Login.Top;

            this.login.Visible = true;
        }

        private void UpdateControlForm()
        {
            manager.loadAllSpot();
            manager.loadAllUser();
            stockManager.UpdateControlForm(manager);
            campingSpot.UpdateControlForm(manager);
            visitor.UpdateControlForm(manager);
        }

        private void bt_camping_Click(object sender, EventArgs e)
        {
            //Update form control
            this.campingSpot.Visible = true;
            this.stockManager.Visible = false;
            this.visitor.Visible = false;
            this.employee.Visible = false;

            //Set cursor position
            this.panel3.Height = bt_camping.Height;
            this.panel3.Top = bt_camping.Top;
        }

        private void bt_StockManager_Click(object sender, EventArgs e)
        {
            //Updata form control
            this.campingSpot.Visible = false;
            this.stockManager.Visible = true;
            this.visitor.Visible = false;
            this.employee.Visible = false;

            //Set cursor position
            this.panel3.Height = bt_StockManager.Height;
            this.panel3.Top = bt_StockManager.Top;
        }

        private void bt_visitor_Click(object sender, EventArgs e)
        {
            //Updata form control
            this.campingSpot.Visible = false;
            this.stockManager.Visible = false;
            this.visitor.Visible = true;
            this.employee.Visible = false;

            //Set cursor position
            this.panel3.Height = bt_visitor.Height;
            this.panel3.Top = bt_visitor.Top;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_employee_Click(object sender, EventArgs e)
        {
            //Updata form control
            this.campingSpot.Visible = false;
            this.stockManager.Visible = false;
            this.visitor.Visible = false;
            this.employee.Visible = true;

            //Set cursor position
            this.panel3.Height = bt_employee.Height;
            this.panel3.Top = bt_employee.Top;
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (login.IsLoggedIn)
            {
                this.bt_Login.Text = "Login";
                this.lbl_status.Text = "Softsolution";
                login.Logout();
                this.Form1_Load(this, null);
            }
            else
            {
                timer.Enabled = true;
                this.bt_Login.Text = "Logout";
                this.lbl_status.Text = "Manager application";
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
