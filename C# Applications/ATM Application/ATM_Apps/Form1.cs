using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace ATM_Apps
{
    public partial class Form1 : Form
    {
        private FileSystemWatcher watch;
        private FolderBrowserDialog fbd;
        private List<Transaction> transactions;
        public Form1()
        {
            InitializeComponent();
            fbd = new FolderBrowserDialog();
            transactions = new List<Transaction>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb_dir.Text = "Default";
            var filePaths = Directory.EnumerateFiles("./", "*.log"); ;
            foreach (string filePath in filePaths)
            {
                ReadFile(filePath);
            }
            watcher(".");
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Create new watcher thread to check ATM log file
         */
        private void watcher(string fileName)
        {
            watch = new FileSystemWatcher();
            watch.Filter = "*.log";
            watch.Path = fileName;

            watch.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watch.Created += new FileSystemEventHandler(onChange);
            watch.EnableRaisingEvents = true;
        }

        private void onChange(object sender, FileSystemEventArgs e)
        {
            try
            {
                Thread.Sleep(10);
                watch.EnableRaisingEvents = false;
                //Comunicate between two thread
                lb_log.Invoke((MethodInvoker)(() => { ReadFile(e.FullPath); }));
            }
            finally
            {
                watch.EnableRaisingEvents = true;
            }
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.tb_dir.Text = fbd.SelectedPath;
                this.lb_log.Items.Clear();
                var filePaths = Directory.EnumerateFiles("./", "*.log"); ;
                foreach (string filePath in filePaths)
                {
                    ReadFile(filePath);
                }
                watcher(fbd.SelectedPath);
            }
        }

        private void ReadFile(string filePath)
        {
            FileStream fin = null;
            StreamReader sr = null;
            try
            {
                Console.WriteLine(filePath);
                fin = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fin);

                string line;
                int id;
                double money;
                try
                {
                    //Read transaction content content
                    string bankAccount = sr.ReadLine();
                    DateTime startTime = DateTime.ParseExact(sr.ReadLine(), "yyyy/MM/dd/HH:mm:ss", System.Globalization.CultureInfo.InstalledUICulture);
                    DateTime endTime = DateTime.ParseExact(sr.ReadLine(), "yyyy/MM/dd/HH:mm:ss", System.Globalization.CultureInfo.InstalledUICulture);
                    int amount = Convert.ToInt32(sr.ReadLine());
                    Transaction transaction = new Transaction(bankAccount, startTime, endTime, amount);
                    for (int i = 0; i < amount; i++)
                    {
                        line = sr.ReadLine();
                        id = Convert.ToInt32(line.Split(' ')[0]);
                        money = Convert.ToDouble(line.Split(' ')[1]);
                        string user_name = "dbi396210";
                        string user_password = "cvezQ2iLsb4ERq5g";
                        string database = "dbi396210";
                        string server = "studmysql01.fhict.local";
                        using (MySqlConnection conn = new MySqlConnection($"Server={server};Uid={user_name};Pwd={user_password};database={database};SslMode=none"))
                        {
                            try
                            {
                                double oldbalance = 0;
                                conn.Open();
                                MySqlCommand cmd = new MySqlCommand($"SELECT Balance FROM `customer` WHERE `CustomerID` = '{id.ToString()}' LIMIT 1", conn);
                                MySqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read())
                                {
                                    oldbalance = Convert.ToDouble(reader["Balance"]);
                                }
                                conn.Close();
                                conn.Open();
                                MySqlCommand cmd1 = new MySqlCommand($"Update customer SET Balance='{oldbalance + money}' WHERE `CustomerID` = '{id.ToString()}'", conn);
                                int number = cmd1.ExecuteNonQuery();
                            }

                            catch
                            {
                                MessageBox.Show("Error connecting to the database.");
                            }
                        }
                        transaction.AddUser(id, money);
                    }
                    transactions.Add(transaction);
                    lb_log.Items.Add(transaction);
                    this.lb_log.SelectedIndex = this.lb_log.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (IOException)
            {
                MessageBox.Show("something went wrong, IOException was thrown");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You have to run this program as adminstrator");
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fin != null) fin.Close();
            }
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            if(lb_log.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a transaction");
            }
            else
            {
                TransactionInfo transactionInfo = new TransactionInfo((Transaction)this.lb_log.SelectedItem);
                transactionInfo.Show();
            }
        }
    }
}
