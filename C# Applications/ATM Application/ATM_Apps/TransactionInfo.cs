using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Apps
{
    public partial class TransactionInfo : Form
    {
        private Transaction transaction;
        public TransactionInfo(Transaction transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            this.Text = "Transaction: " + transaction.Id;
            this.lb_user.Items.Add(transaction.ToString());
            foreach(User user in transaction.Users)
            {
                this.lb_user.Items.Add("   - " + user);
            }
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
