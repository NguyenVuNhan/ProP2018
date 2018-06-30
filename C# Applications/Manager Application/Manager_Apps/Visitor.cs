using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Manager_Apps
{
    public partial class Visitor : UserControl
    {
        private delegate void ChartHandler();
        private ChartHandler chart;

        private Manager manager;
        
        public Visitor()
        {
            InitializeComponent();

            this.manager = new Manager();
            this.rbt_campingStatus.Checked = true;

            this.chart = new ChartHandler(campingChart);
        }

        public void UpdateControlForm(Manager manager)
        {
            this.manager = manager;
            chart();

            if(this.tb_Search.Text == "")
            {
                UpdateAllUser();
            }
        }

        private void UpdateAllUser()
        {
            int index = 0;
            if (this.lb_User.Items.Count > 0)
            {
                foreach (User user in manager.Customers)
                {
                    try
                    {
                        if ((User)this.lb_User.Items[index] != user)
                        {
                            this.lb_User.Items[index] = user;
                            index++;
                        }
                    }
                    catch
                    {
                        this.lb_User.Items.Add(user);
                    }
                }
            }
            else
            {
                foreach (User user in manager.Customers)
                {
                    this.lb_User.Items.Add(user);
                }
            }
        }

        private void campingChart()
        {
            //Update the chart
            chart_visitor.Series.Clear();
            chart_visitor.Legends.Clear();

            chart_visitor.Legends.Add("Purchase status");
            chart_visitor.Legends[0].LegendStyle = LegendStyle.Table;
            chart_visitor.Legends[0].Docking = Docking.Right;
            chart_visitor.Legends[0].Alignment = StringAlignment.Center;
            chart_visitor.Legends[0].Title = "Camping status";
            chart_visitor.Legends[0].BorderColor = Color.Black;

            chart_visitor.Series.Add("Status");
            chart_visitor.Series["Status"].ChartType = SeriesChartType.Doughnut;
            chart_visitor.Series["Status"].IsValueShownAsLabel = true;

            int[] status = manager.Purchase();
            chart_visitor.Series["Status"].Points.AddXY("Camping spot purchase", status[0]);
            chart_visitor.Series["Status"].Points.AddXY("Ticket purchase", status[1]);
            chart_visitor.Series["Status"].Points.AddXY("Product purchase", status[2]);
        }

        private void ageChart()
        {
            //Update the chart
            chart_visitor.Series.Clear();
            chart_visitor.Legends.Clear();

            chart_visitor.Legends.Add("Age status");
            chart_visitor.Legends[0].LegendStyle = LegendStyle.Table;
            chart_visitor.Legends[0].Docking = Docking.Right;
            chart_visitor.Legends[0].Alignment = StringAlignment.Center;
            chart_visitor.Legends[0].Title = "Camping status";
            chart_visitor.Legends[0].BorderColor = Color.Black;

            chart_visitor.Series.Add("Status");
            chart_visitor.Series["Status"].ChartType = SeriesChartType.Doughnut;
            chart_visitor.Series["Status"].IsValueShownAsLabel = true;

            int[] status = manager.visitorAgeStatus();
            chart_visitor.Series["Status"].Points.AddXY("<= 17", status[0]);
            chart_visitor.Series["Status"].Points.AddXY("18 - 39", status[1]);
            chart_visitor.Series["Status"].Points.AddXY(">= 40", status[2]);
        }

        private void rbt_campingStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.chart = new ChartHandler(campingChart);
        }

        private void rbt_ageStatus_CheckedChanged(object sender, EventArgs e)
        {
            this.chart = new ChartHandler(ageChart);
        }

        private void bt_showInfo_Click(object sender, EventArgs e)
        {
            if(this.lb_User.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a visitor");
            }
            else
            {
                User user = (User)this.lb_User.SelectedItem;
                VisitorInfo info = new VisitorInfo();
                info.Update(user);
                info.Show();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            if(this.tb_Search.Text.ToLower() != "")
            {
                this.lb_User.Items.Clear();
                foreach (User user in manager.findUser(this.tb_Search.Text.ToLower()))
                {
                    lb_User.Items.Add(user);
                }
            }
        }
    }
}
