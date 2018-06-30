using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_DLL;
using Phidget22;
using Phidget22.Events;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Event_Store
{
    public partial class Form1 : Form
    {
        List<PictureBox> picBoxList;
        List<List<Image>> Images;
        Store StoreDLL;
        LoginWindow LoginPage;
        RFID RFIDReader;
        Customer Customer;
        Order Order;
        string nrOfItems;
        int nrOfFood;
        int nrOfDrink;
        int nrOfSouvenir;
        int nrOfMaxItems;
        //List<List<Bitmap>> ImagesList; //Use when no longer want to download from database.

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
            PreppingGUI();
            Customer = null;
            Order = null;
            UpdateCustomerGUI();
            RefreshOrderGUI();
            RFIDReader.Open();
            timerDBCheck.Enabled = true;

            List<string> temp = StoreDLL.GetEmployeeData(e.Username, e.Password);

            if (temp.Count() > 0)
            {
                string fullname;
                fullname = temp[2] + " " + temp[3];
                lblStaffName.Text = fullname;
                lblStaffLevel.Text = temp[7];
            }
        }

        public void PreppingGUI()
        {
            radiobtnFood.Checked = true;
            groupBoxCategoryRadiobtn.Visible = false;
            ChangingItemsGUI();            
        }

        public void CreatingGUI()
        {
            try
            {
                picBoxList = new List<PictureBox>();
                Images = new List<List<Image>>();
                List<List<byte[]>> ImagesArray = new List<List<byte[]>>();
                MemoryStream memoryStream;
                nrOfItems = StoreDLL.GetNumberOfProducts();
                string[] temp = nrOfItems.Split(',');
                nrOfFood = Convert.ToInt32(temp[0]);
                nrOfDrink = Convert.ToInt32(temp[1]);
                nrOfSouvenir = Convert.ToInt32(temp[2]);
                nrOfMaxItems = Math.Max(nrOfSouvenir, Math.Max(nrOfFood, nrOfDrink));


                //Incase no longer wants to download images from database.
                //ImagesList = new List<List<Bitmap>>();
                //List<List<string>> ImagesPathList = new List<List<string>>();
                //Assembly bitmapAssembly;
                //Stream bitmapStream;

                for (int i = 0; i < 3; i++)
                {
                    Images.Add(new List<Image>());
                    ImagesArray.Add(new List<byte[]>());
                    //ImagesList.Add(new List<Bitmap>());
                    //ImagesPathList.Add(new List<string>());
                }

                int horizontalposition = 0;
                int horizontalpositionMax;
                int x = 4;
                int y = 18;

                int tempColumn = nrOfMaxItems / 4;
                if ((nrOfMaxItems / 4.00) > (double)tempColumn)
                {
                    horizontalpositionMax = (nrOfMaxItems / 4);
                    groupBoxItems.Width = 4 + (((nrOfMaxItems / 4) + 1) * 95);
                    groupBoxCategory.Width = groupBoxItems.Width + 135;
                    this.Width = groupBoxCategory.Width + 460;
                }

                else
                {
                    horizontalpositionMax = (nrOfMaxItems / 4) - 1;
                    groupBoxItems.Width = 4 + ((nrOfMaxItems / 4) * 95);
                    groupBoxCategory.Width = groupBoxItems.Width + 135; 
                    this.Width = groupBoxCategory.Width + 460;
                }

                for (int i = 0; i < nrOfMaxItems; i++)
                {
                    picBoxList.Add(new PictureBox());
                    picBoxList[i].Name = i.ToString();
                    if(i < nrOfFood)
                    {
                        ImagesArray[0].Add(StoreDLL.GetImage(i, "product"));
                    }

                    if(i < nrOfDrink)
                    {
                        ImagesArray[1].Add(StoreDLL.GetImage(100 + i, "product"));
                    }

                    if(i < nrOfSouvenir)
                    {
                        ImagesArray[2].Add(StoreDLL.GetImage(200 + i, "product"));
                    }

                    //ImagesPathList[0].Add(StoreDLL.GetStoreImagesPath("product", i));//
                    //ImagesPathList[1].Add(StoreDLL.GetStoreImagesPath("product", 100 + i));//
                    //ImagesPathList[2].Add(StoreDLL.GetStoreImagesPath("product", 200 + i));//
                }

                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    groupBoxItems.Controls.Add(picBoxList[i]);
                    picBoxList[i].Height = 80;
                    picBoxList[i].Width = 90;
                    picBoxList[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picBoxList[i].Click += new EventHandler(PictureBoxesClick);

                    if (horizontalposition == horizontalpositionMax)
                    {
                        picBoxList[i].Location = new Point(x, y);
                        x = 4;
                        y = y + 85;
                        horizontalposition = 0;
                    }

                    else
                    {
                        picBoxList[i].Location = new Point(x, y);
                        x = x + 95;
                        horizontalposition++;
                    }
                }

                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    if(i < nrOfFood)
                    {
                        memoryStream = new MemoryStream(ImagesArray[0][i]);
                        Images[0].Add(Image.FromStream(memoryStream));
                    }

                    if(i < nrOfDrink)
                    {
                        memoryStream = new MemoryStream(ImagesArray[1][i]);
                        Images[1].Add(Image.FromStream(memoryStream));
                    }

                    if(i < nrOfSouvenir)
                    {
                        memoryStream = new MemoryStream(ImagesArray[2][i]);
                        Images[2].Add(Image.FromStream(memoryStream));
                    }

                    /*                    
                    bitmapAssembly = Assembly.GetExecutingAssembly();
                    bitmapStream = bitmapAssembly.GetManifestResourceStream(ImagesPathList[0][i]);
                    ImagesList[0].Add(new Bitmap(bitmapStream));

                    bitmapAssembly = Assembly.GetExecutingAssembly();
                    bitmapStream = bitmapAssembly.GetManifestResourceStream(ImagesPathList[1][i]);
                    ImagesList[1].Add(new Bitmap(bitmapStream));

                    bitmapAssembly = Assembly.GetExecutingAssembly();
                    bitmapStream = bitmapAssembly.GetManifestResourceStream(ImagesPathList[2][i]);
                    ImagesList[2].Add(new Bitmap(bitmapStream));
                    */
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

        public void ChangingItemsGUI()
        {

            if (radiobtnFood.Checked == true)
            {
                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    if (i < nrOfFood)
                    {
                        picBoxList[i].Enabled = true;
                        picBoxList[i].Visible = true;
                        picBoxList[i].Image = Images[0][i];
                        picBoxList[i].Refresh();
                    }

                    else
                    {
                        picBoxList[i].Enabled = false;
                        picBoxList[i].Visible = false;                        
                    }
                }
            }

            else if (radiobtnDrink.Checked == true)
            {
                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    if(i < nrOfDrink)
                    {
                        picBoxList[i].Enabled = true;
                        picBoxList[i].Visible = true;
                        picBoxList[i].Image = Images[1][i];
                        picBoxList[i].Refresh();
                    }

                    else
                    {
                        picBoxList[i].Enabled = false;
                        picBoxList[i].Visible = false;
                    }
                }
            }

            else
            {
                for (int i = 0; i < picBoxList.Count(); i++)
                {
                    if(i < nrOfSouvenir)
                    {
                        picBoxList[i].Enabled = true;
                        picBoxList[i].Visible = true;
                        picBoxList[i].Image = Images[2][i];
                        picBoxList[i].Refresh();
                    }

                    else
                    {
                        picBoxList[i].Enabled = false;
                        picBoxList[i].Visible = false;
                    }
                }
            }
        }

        private void picBoxFood_Click(object sender, EventArgs e)
        {
            radiobtnFood.Checked = true;
            ChangingItemsGUI();
        }

        private void picBoxDrink_Click(object sender, EventArgs e)
        {
            radiobtnDrink.Checked = true;
            ChangingItemsGUI();
        }

        private void picBoxSouvenir_Click(object sender, EventArgs e)
        {
            radiobtnSouvenir.Checked = true;
            ChangingItemsGUI();
        }

        public void LoadingLoginWindow()
        {
            LoginPage.PreppingLoginForm();
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;            
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log off? You will be returned to the login page.", "Logg Off", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer = null;
                Order = null;
                UpdateCustomerGUI();
                RefreshOrderGUI();
                RFIDReader.Close();
                LoadingLoginWindow();
                timerDBCheck.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void RFIDReader_Tag(object sender, RFIDTagEventArgs e)
        {
            if(Customer == null)
            {
                try
                {
                    List<string> temp = StoreDLL.GetCostumerData(e.Tag);

                    Customer = new Customer(Convert.ToInt32(temp[0]), temp[1], temp[2], Convert.ToDouble(temp[3]), temp[6]);

                    Order = new Order(Customer.CostumerID);
                    Order.Error += this.OnError;
                    UpdateCustomerGUI();
                    RefreshOrderGUI();
                    timerDBCheck.Enabled = false;
                }

                catch(MySqlException)
                {
                    MessageBox.Show("Check your connection. Unable to reach database.");
                    Customer = null;
                    Order = null;
                    UpdateCustomerGUI();
                    RefreshOrderGUI();
                    timerDBCheck.Enabled = true;
                }

                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Tag does not conform with a visitor.");
                    Customer = null;
                    Order = null;
                    UpdateCustomerGUI();
                    RefreshOrderGUI();
                    timerDBCheck.Enabled = true;
                }
            }
        }

        private void UpdateCustomerGUI()
        {
            if(Customer == null)
            {
                lblClientName.Text = "Waiting for client...";
                lblClientAge.Visible = false;
                lblClientAlcohol.Visible = false;
                lblDefaultAge.Visible = false;
                lblDefaultAlcohol.Visible = false;
                lblBalanceDefault.Visible = false;
                lblBalance.Visible = false;
                btnEndSession.Visible = false;
                panelDeduct.Enabled = false;
                panelAdd.Enabled = false;
                panelAdd5.Enabled = false;
                panelClear.Enabled = false;
                btnConfirmPurchase.Enabled = false;
                groupBoxItems.Enabled = false;

            }

            else
            {
                string name = Customer.FirstName + " " + Customer.LastName;
                lblClientName.Text = name;
                lblClientAge.Text = Customer.Age.ToString();
                lblBalance.Text = (Customer.BalanceLeft).ToString("N2");

                if (Customer.Age >= 18)
                {
                    lblClientAlcohol.Text = "YES";
                }

                else
                {
                    lblClientAlcohol.Text = "NO";
                }

                lblClientAge.Visible = true;
                lblClientAlcohol.Visible = true;
                lblDefaultAge.Visible = true;
                lblDefaultAlcohol.Visible = true;
                lblBalanceDefault.Visible = true;
                lblBalance.Visible = true;
                btnEndSession.Visible = true;
                panelDeduct.Enabled = true;
                panelAdd.Enabled = true;
                panelAdd5.Enabled = true;
                panelClear.Enabled = true;
                btnConfirmPurchase.Enabled = true;
                groupBoxItems.Enabled = true;
            }
        }

        private void btnEndSession_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to end the session? Client details will be reset.", "End Session", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Customer = null;
                Order = null;
                UpdateCustomerGUI();
                RefreshOrderGUI();
                timerDBCheck.Enabled = true;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void PictureBoxesClick(object sender, EventArgs e)
        {
            if(Customer != null && Order != null)
            {
                if(radiobtnFood.Checked == true)
                {
                    double balanceleft = Customer.BalanceLeft;
                    Order.Add(Convert.ToInt32(((PictureBox)sender).Name), 1, Customer.Age, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                }

                else if(radiobtnDrink.Checked == true)
                {
                    double balanceleft = Customer.BalanceLeft;
                    Order.Add(100 + Convert.ToInt32(((PictureBox)sender).Name), 1, Customer.Age, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                }

                else
                {
                    double balanceleft = Customer.BalanceLeft;
                    Order.Add(200 + Convert.ToInt32(((PictureBox)sender).Name), 1, Customer.Age, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                }

            }
        }

        private void RefreshOrderGUI()
        {
            OrderList.Items.Clear();
            lblOrderTotal.Text = "0.00";
            if (Order != null)
            {
                foreach (Item p in Order.OrderList)
                {
                    OrderList.Items.Add(p.Name).SubItems.AddRange(new string[] { p.Quantity.ToString(), ((double)p.Quantity * p.Price).ToString("N2")});
                }

                lblOrderTotal.Text = Order.Total.ToString("N2");
            }
        }

        private void panelAdd_Click(object sender, EventArgs e)
        {
            int itemid;
            int selectedindex;

            if (Customer != null && Order != null)
            {
                if (OrderList.SelectedIndices.Count > 0)
                {
                    selectedindex = OrderList.SelectedIndices[0];
                    itemid = Order.OrderList[selectedindex].ID;
                    double balanceleft = Customer.BalanceLeft;
                    Order.Add(itemid, 1, Customer.Age, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                    OrderList.Items[selectedindex].Selected = true;
                }

                else
                {
                    MessageBox.Show("Please select an item from the list.");
                }
            }
        }

        private void panelAdd5_Click(object sender, EventArgs e)
        {
            int itemid;
            int selectedindex;

            if (Customer != null && Order != null)
            {
                if (OrderList.SelectedIndices.Count > 0)
                {
                    selectedindex = OrderList.SelectedIndices[0];
                    itemid = Order.OrderList[selectedindex].ID;
                    double balanceleft = Customer.BalanceLeft;
                    Order.Add(itemid, 5, Customer.Age, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                    OrderList.Items[selectedindex].Selected = true;
                }

                else
                {
                    MessageBox.Show("Please select an item from the list.");
                }
            }
        }

        private void panelDeduct_Click(object sender, EventArgs e)
        {
            int itemid;
            int selectedindex;
            int ItemsInOrder;

            if (Customer != null && Order != null)
            {
                if (OrderList.SelectedIndices.Count > 0)
                {
                    ItemsInOrder = Order.OrderList.Count();
                    selectedindex = OrderList.SelectedIndices[0];
                    itemid = Order.OrderList[selectedindex].ID;
                    double balanceleft = Customer.BalanceLeft;
                    Order.Deduct(itemid, ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                    if(ItemsInOrder == Order.OrderList.Count())
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

        private void panelClear_Click(object sender, EventArgs e)
        {
            if (Customer != null && Order != null)
            {
                if (OrderList.SelectedIndices.Count > 0)
                {
                    double balanceleft = Customer.BalanceLeft;
                    Order.ClearRow(OrderList.SelectedIndices[0], ref balanceleft);
                    Customer.BalanceLeft = balanceleft;
                    RefreshOrderGUI();
                }

                else
                {
                    MessageBox.Show("Please select an item from the list.");
                }
            }
        }

        private void btnConfirmPurchase_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Press YES if you want to process order and move to the next client.", "Confirm Purchase", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Customer != null && Order != null)
                {
                    if (Order.OrderList.Count != 0)
                    {
                        try                        
                        {
                            StoreDLL.ProcessOrder(Customer.CostumerID, Order.PurchaseID, Customer.BalanceLeft);

                            foreach (Item p in Order.OrderList)
                            {
                                StoreDLL.ProcessItem(Order.PurchaseID, p.ID, Customer.CostumerID, p.Quantity, p.LeftInStock);
                            }

                            Customer = null;
                            Order = null;
                            UpdateCustomerGUI();
                            RefreshOrderGUI();
                            timerDBCheck.Enabled = true;
                        }

                        catch
                        {
                            MessageBox.Show("Check your connection. Unable to reach the database.");
                        }                      
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
 
            }
        }

        private void OnError(string message)
        {
            MessageBox.Show(message);
        }

        private void timerDBCheck_Tick(object sender, EventArgs e)
        {
            try
            {
                if (nrOfItems != StoreDLL.GetNumberOfProducts())
                {
                    timerDBCheck.Enabled = false;
                    MessageBox.Show("Updates has been made to the inventory. Please restart the program.");
                }
            }

            catch
            {
                //Showing a messagebox here would be annoying. Leave it when the user does something.
            }
        }   
    }
}
