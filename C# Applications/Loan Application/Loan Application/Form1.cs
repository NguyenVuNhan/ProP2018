using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_DLL;
using Phidget22;
using Phidget22.Events;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Loan_Application
{
    public partial class Form1 : Form
    {
        Store StoreDLL;
        LoginWindow LoginPage;
        RFID RFIDReader;
        Customer Customer;
        LoanOrder LoanOrder;
        ReturnOrder ReturnOrder;
        LoanItem SelectedReturnItem;
        int nrOfBorrowables;

        public Form1()
        {
            InitializeComponent();
            StoreDLL = new Store();
            LoginPage = new LoginWindow();
            RFIDReader = new RFID();
            LoginPage.LogInSuccessfull += this.OnLoginSuccess;
            RFIDReader.Tag += RFIDReader_Tag;
            LoadingLoginWindow();
            CreatingGUI();            
        }

        public void OnLoginSuccess(object source, LoginEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
            Customer = null;
            timerDBCheck.Enabled = true;
            LoanOrder = null;
            UpdateCustomerGUI();
            RefreshLoanOrderGUI();
            RFIDReader.Open();

            List<string> temp = StoreDLL.GetEmployeeData(e.Username, e.Password);

            if (temp.Count() > 0)
            {
                string fullname;
                fullname = temp[2] + " " + temp[3];
                lblStaffName.Text = fullname;
                lblStaffLevel.Text = temp[7];
            }
        }

        public void LoadingLoginWindow()
        {
            LoginPage.PreppingLoginForm();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void CreatingGUI()
        {
            try
            {
                List<PictureBox> picBoxList = new List<PictureBox>();
                List<byte[]> ImagesArray = new List<byte[]>();
                List<Image> Images = new List<Image>();
                MemoryStream memoryStream;
                nrOfBorrowables = StoreDLL.GetNumberOfBorrowables();

                //Used for paths - Niet van toepassing
                //List<Bitmap> ImagesList = new List<Bitmap>();
                //List<string> ImagesPathList = new List<string>();
                //Assembly bitmapAssembly;
                //Stream bitmapStream;

                int horizontalposition = 0;
                int horizontalpositionMax;
                int x = 15;
                int y = 15;

                int temp = nrOfBorrowables / 3;
                if ((nrOfBorrowables / 3.00) > (double)temp)
                {
                    horizontalpositionMax = (nrOfBorrowables / 3);
                    groupBoxItems.Width = 18 + (((nrOfBorrowables / 3) + 1) * 140);
                    groupBoxLoanSection.Width = groupBoxItems.Width + 360;
                    this.Width = groupBoxLoanSection.Width + 30;
                }

                else
                {
                    horizontalpositionMax = (nrOfBorrowables / 3) - 1;
                    groupBoxItems.Width = 18 + ((nrOfBorrowables / 3) * 140);
                    groupBoxLoanSection.Width = groupBoxItems.Width + 360;
                    this.Width = groupBoxLoanSection.Width + 30;
                }

                

                for (int i = 0; i < nrOfBorrowables; i++)
                {
                    picBoxList.Add(new PictureBox());
                    picBoxList[i].Name = i.ToString();
                    ImagesArray.Add(StoreDLL.GetImage(i, "borrowable"));
                    //ImagesPathList.Add(StoreDLL.GetStoreImagesPath("borrowable", i));     //Used for paths - Niet van toepassing
                }

                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    groupBoxItems.Controls.Add(picBoxList[i]);
                    picBoxList[i].Height = 125;
                    picBoxList[i].Width = 125;
                    picBoxList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picBoxList[i].Click += new EventHandler(PictureBoxesClick);

                    if (horizontalposition == horizontalpositionMax)
                    {
                        picBoxList[i].Location = new Point(x, y);
                        x = 18;
                        y = y + 140;
                        horizontalposition = 0;
                    }

                    else
                    {
                        picBoxList[i].Location = new Point(x, y);
                        x = x + 140;
                        horizontalposition++;
                    }
                }

                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    memoryStream = new MemoryStream(ImagesArray[i]);
                    Images.Add(Image.FromStream(memoryStream));
                    picBoxList[i].Image = Images[i];
                    picBoxList[i].Refresh();

                    //Used for paths - Niet van toepassing
                    //bitmapAssembly = Assembly.GetExecutingAssembly();
                    //bitmapStream = bitmapAssembly.GetManifestResourceStream(ImagesPathList[i]);
                    //ImagesList.Add(new Bitmap(bitmapStream));
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Check your connection. Unable to reach the database. Application will exit.");
                Environment.Exit(0);
            }

            catch (MySqlException)
            {
                MessageBox.Show("Check your connection. Unable to reach the database. Application will exit.");
                Environment.Exit(0);
            }
        }

        private void PictureBoxesClick(object sender, EventArgs e)
        {
            if(Customer != null && LoanOrder != null)
            {
                double balanceleft = Customer.BalanceLeft;
                LoanOrder.Add(Convert.ToInt32(((PictureBox)sender).Name), ref balanceleft);
                Customer.BalanceLeft = balanceleft;
                RefreshLoanOrderGUI();
            }
        }

        private void UpdateCustomerGUI()
        {
            if(Customer == null)
            {
                lblClientName.Text = "Waiting for client...";
                lblClientAge.Visible = false;
                lblDefaultAge.Visible = false;
                lbldefaultBalance.Visible = false;
                lblBalance.Visible = false;
                btnEndSession.Visible = false;
                groupBoxItems.Enabled = false;
                pnlRemoveItem.Enabled = false;
                pnlClearList.Enabled = false;
                pnlConfirmLoan.Enabled = false;
                pnlNoDamage.Enabled = false;
                pnlDamaged.Enabled = false;
                btnConfirmReturn.Enabled = false;
            }

            else
            {
                string name = Customer.FirstName + " " + Customer.LastName;
                lblClientName.Text = name;
                lblClientAge.Text = Customer.Age.ToString();
                lblBalance.Text = (Customer.BalanceLeft).ToString("N2");

                lblClientAge.Visible = true;
                lblDefaultAge.Visible = true;
                lbldefaultBalance.Visible = true;
                lblBalance.Visible = true;
                btnEndSession.Visible = true;
                groupBoxItems.Enabled = true;
                pnlRemoveItem.Enabled = true;
                pnlClearList.Enabled = true;
                pnlConfirmLoan.Enabled = true;
                pnlNoDamage.Enabled = true;
                pnlDamaged.Enabled = true;
                btnConfirmReturn.Enabled = true;
            }
        }

        private void RFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            if (Customer == null)
            {
                try
                {
                    timerDBCheck.Enabled = false;
                    List<string> temp = StoreDLL.GetCostumerData(e.Tag);

                    Customer = new Customer(Convert.ToInt32(temp[0]), temp[1], temp[2], Convert.ToDouble(temp[3]), temp[6]);
                    LoanOrder = new LoanOrder(Customer.CostumerID);
                    ReturnOrder = new ReturnOrder(Customer.CostumerID);
                    LoanOrder.Error += this.OnError;
                    UpdateCustomerGUI();
                    RefreshLoanOrderGUI();
                }

                catch (MySqlException)
                {
                    MessageBox.Show("Check your connection. Unable to reach database.");
                    Customer = null;
                    LoanOrder = null;
                    UpdateCustomerGUI();
                    RefreshLoanOrderGUI();
                    timerDBCheck.Enabled = true;
                }

                catch (System.ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Tag does not conform with a visitor.");
                    Customer = null;
                    LoanOrder = null;
                    UpdateCustomerGUI();
                    RefreshLoanOrderGUI();
                    timerDBCheck.Enabled = true;
                }
            }
        }

        private void RefreshLoanOrderGUI()
        {
            OrderList.Items.Clear();
            lBoxReturnItems.Items.Clear();
            lblTotal.Text = "0.00";
            lblReturnItem.Text = "";
            lblReturnStatus.Text = "";
            lblPenalty.Text = "0.00";

            if(LoanOrder != null)
            {
                foreach (LoanItem p in LoanOrder.OrderList)
                {
                    OrderList.Items.Add(p.Name).SubItems.AddRange(new string[] { p.Quantity.ToString(), ((double)p.Quantity * p.Price).ToString("N2") });
                }

                lblTotal.Text = LoanOrder.Total.ToString("N2");
            }

            if (ReturnOrder != null)
            {
                foreach (LoanItem p in ReturnOrder.ReturnList)
                {
                    lBoxReturnItems.Items.Add(p.Name);
                }

                if (SelectedReturnItem != null)
                {
                    lblReturnItem.Text = SelectedReturnItem.Name;
                    lblReturnStatus.Text = SelectedReturnItem.ReturnStatus;

                    if(SelectedReturnItem.ReturnStatus == "DAMAGED")
                    {
                        lblPenalty.Text = (SelectedReturnItem.Penalty).ToString("N2");
                    }

                    else
                    {
                        lblPenalty.Text = "0.00";
                    }
                }
            }
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to end the session? Client details will be reset.", "End Session", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer = null;
                LoanOrder = null;
                ReturnOrder = null;
                SelectedReturnItem = null;
                UpdateCustomerGUI();
                RefreshLoanOrderGUI();
                timerDBCheck.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log off? You will be returned to the login page.", "Logg Off", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer = null;
                LoanOrder = null;
                ReturnOrder = null;
                SelectedReturnItem = null;
                UpdateCustomerGUI();
                RefreshLoanOrderGUI();
                RFIDReader.Close();
                LoadingLoginWindow();
                timerDBCheck.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }


        private void pnlRemoveItem_Click(object sender, EventArgs e)
        {
            int itemid;
            int selectedindex;
            int ItemsInOrder;

            if (Customer != null && LoanOrder != null)
            {
                if (OrderList.SelectedIndices.Count > 0)
                {
                    ItemsInOrder = LoanOrder.OrderList.Count();
                    selectedindex = OrderList.SelectedIndices[0];
                    itemid = LoanOrder.OrderList[selectedindex].ID;
                    double balanceleft = Customer.BalanceLeft;
                    LoanOrder.Deduct(itemid, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshLoanOrderGUI();
                    if (ItemsInOrder == LoanOrder.OrderList.Count())
                    {
                        OrderList.Items[selectedindex].Selected = true;
                    }
                }

                else
                {
                    MessageBox.Show("Please select an item from the list.");
                }
            }
        }

        private void pnlClearList_Click(object sender, EventArgs e)
        {
            if(Customer != null && LoanOrder != null)
            {
                double balanceleft = Customer.BalanceLeft;
                LoanOrder.ClearList(ref balanceleft);
                Customer.BalanceLeft = balanceleft;
                RefreshLoanOrderGUI();
            }
        }

        private void pnlConfirmLoan_Click(object sender, EventArgs e)
        {
            if (LoanOrder.OrderList.Count != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Press YES if you want to process order and move to the next client.", "Confirm Loan", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Customer != null && LoanOrder != null)
                    {
                        try
                        {
                            LoanOrder.ProcessLoanOrder(Customer.BalanceLeft);
                            Customer = null;
                            LoanOrder = null;
                            ReturnOrder = null;
                            SelectedReturnItem = null;
                            timerDBCheck.Enabled = true;
                            UpdateCustomerGUI();
                            RefreshLoanOrderGUI();
                        }

                        catch (MySqlException)
                        {
                            MessageBox.Show("Check your connection. Unable to reach the database.");
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }

            else
            {
                MessageBox.Show("No items in order.");
            }
        }

        private void OnError(string message)
        {
            MessageBox.Show(message);
        }

        private void pnlNoDamage_Click(object sender, EventArgs e)
        {
            if(ReturnOrder != null)
            {
                if (SelectedReturnItem != null)
                {
                    SelectedReturnItem.UpdateReturnStatus("NO DAMAGE");
                }
            }

            RefreshLoanOrderGUI();
            UpdateCustomerGUI();
        }

        private void lBoxReturnItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ReturnOrder != null)
            {
                if (lBoxReturnItems.SelectedIndex > -1)
                {
                    SelectedReturnItem = ReturnOrder.ReturnList[lBoxReturnItems.SelectedIndex];
                }
            }

            RefreshLoanOrderGUI();
            UpdateCustomerGUI();
        }

        private void pnlDamaged_Click(object sender, EventArgs e)
        {
            if (ReturnOrder != null)
            {
                if (SelectedReturnItem != null)
                {
                    SelectedReturnItem.UpdateReturnStatus("DAMAGED");
                }
            }

            RefreshLoanOrderGUI();
            UpdateCustomerGUI();
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            if(ReturnOrder != null)
            {
                if (SelectedReturnItem != null)
                {
                    if (SelectedReturnItem.ReturnStatus != null)
                    {
                        try
                        {
                            if (SelectedReturnItem.ReturnStatus == "NO DAMAGE")
                            {
                                StoreDLL.ProcessReturnItem(Customer.CostumerID, SelectedReturnItem.ID, SelectedReturnItem.ItemNumber, SelectedReturnItem.ReturnStatus);
                                int quantity = StoreDLL.GetQuantity(SelectedReturnItem.ID, "borrowable");
                                quantity = quantity + 1;
                                StoreDLL.ProcessReturnStockBalance(Customer.CostumerID, Customer.BalanceLeft, SelectedReturnItem.ID, quantity);
                            }

                            else
                            {
                                if (Customer.BalanceLeft >= SelectedReturnItem.Penalty)
                                {
                                    StoreDLL.ProcessReturnItem(Customer.CostumerID, SelectedReturnItem.ID, SelectedReturnItem.ItemNumber, SelectedReturnItem.ReturnStatus);
                                    Customer.BalanceLeft = Customer.BalanceLeft - SelectedReturnItem.Penalty;
                                    int quantity = StoreDLL.GetQuantity(SelectedReturnItem.ID, "borrowable");
                                    StoreDLL.ProcessReturnStockBalance(Customer.CostumerID, Customer.BalanceLeft, SelectedReturnItem.ID, quantity);
                                }

                                else
                                {
                                    MessageBox.Show("No enough balance left.");
                                }
                            }

                            LoanOrder = null;
                            SelectedReturnItem = null;
                            ReturnOrder = null;
                            ReturnOrder = new ReturnOrder(Customer.CostumerID);
                            LoanOrder = new LoanOrder(Customer.CostumerID);
                        }

                        catch
                        {
                            MessageBox.Show("Check your connection. Unable to reach database.");
                        }
                    }

                    else
                    {
                        MessageBox.Show("No return status selected.");
                    }                    
                }

                else
                {
                    MessageBox.Show("No item selected.");
                }
            }

            RefreshLoanOrderGUI();
            UpdateCustomerGUI();
        }
        
        private void timerDBCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (nrOfBorrowables != StoreDLL.GetNumberOfBorrowables())
                {
                    timerDBCheck.Enabled = false;
                    MessageBox.Show("Updates has been made to the inventory. Please restart the program.");                    
                }
            }

            catch
            {
                //Showing a messagebox here would be annoying. Leave it when the user does something to show a connection error.
            }
        }
    }
}
