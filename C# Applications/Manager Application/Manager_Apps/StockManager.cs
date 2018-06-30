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
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;

namespace Manager_Apps
{
    public partial class StockManager : UserControl
    {
        private Manager manager;

        public StockManager()
        {
            InitializeComponent();

            this.manager = new Manager();
        }

        public void UpdateControlForm(Manager manager)
        {
            this.manager = manager;

            this.lb_LowStockProduct.Items.Clear();
            chart();
        }

        private void chart()
        {
            //Update the chart
            chart_Stock.Series.Clear();
            chart_Stock.Legends.Clear();

            chart_Stock.ChartAreas[0].AxisX.Interval = 1;
            chart_Stock.ChartAreas[0].AxisX.LabelStyle.Angle = 45;

            chart_Stock.Legends.Add("Stock status");
            chart_Stock.Legends[0].LegendStyle = LegendStyle.Column;
            chart_Stock.Legends[0].Docking = Docking.Right;
            chart_Stock.Legends[0].Alignment = StringAlignment.Center;
            chart_Stock.Legends[0].Title = "Stock status";
            chart_Stock.Legends[0].BorderColor = Color.Black;

            chart_Stock.Series.Add("Status");
            chart_Stock.Series["Status"].ChartType = SeriesChartType.Column;

            foreach (var product in manager.get20LowestProct())
            {
                if(product.Value <= 200)
                {
                     this.lb_LowStockProduct.Items.Add($"{product.Key}, In stock: {product.Value.ToString()}");
                }
                chart_Stock.Series["Status"].Points.AddXY(product.Key, product.Value);
            }
        }

        private void bt_requestProduct_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = null;
            try
            {
                //sw = File.AppendText("StockStatus.log");
                //sw.WriteLine($"--------------------------Update {DateTime.Now.ToString()}--------------------------");
                try
                {
                    string item;
                    for (int i = 0; i < lb_LowStockProduct.Items.Count; i++)
                    {
                        item = lb_LowStockProduct.Items[i].ToString();
                        if (!manager.AddProduct(item.Split(',')[0]))
                        {
                            MessageBox.Show("Some things wrong, cannot add product " + item.Split(',')[0]);
                            //sw.WriteLine($"{DateTime.Now.ToShortTimeString()} {item.Split(',')[0]} 100 Failed");
                        }
                        else
                        {
                            //sw.WriteLine($"{DateTime.Now.ToShortTimeString()} {item.Split(',')[0]} 100 Success");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Something went wrong, IOException was thrown");
            }
            finally
            {
                //if (sw != null) sw.Close();
            }
        }
    }
}
