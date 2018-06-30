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

namespace Manager_Apps
{
    public partial class CampingSpot : UserControl
    {
        private Manager manager;

        public CampingSpot()
        {
            InitializeComponent();

            this.manager = new Manager();
        }

        public void UpdateControlForm(Manager manager)
        {
            this.manager = manager;

            int index = 0;
            if(this.lb_campingSpot.Items.Count > 0)
            {
                foreach (Spot spot in manager.Spots)
                {
                    try
                    {
                        if ((Spot)this.lb_campingSpot.Items[index] != spot)
                        {
                            this.lb_campingSpot.Items[index] = spot;
                            index++;
                        }
                    }
                    catch
                    {
                        this.lb_campingSpot.Items.Add(spot);
                    }
                }
            }
            else
            {
                foreach (Spot spot in manager.Spots)
                {
                    this.lb_campingSpot.Items.Add(spot);
                }
            }
            chart();
        }

        public void chart()
        {
            //Update the chart
            chart_generalInfo.Series.Clear();
            chart_generalInfo.Legends.Clear();

            chart_generalInfo.Legends.Add("Camping status");
            chart_generalInfo.Legends[0].LegendStyle = LegendStyle.Table;
            chart_generalInfo.Legends[0].Docking = Docking.Left;
            chart_generalInfo.Legends[0].Alignment = StringAlignment.Center;
            chart_generalInfo.Legends[0].Title = "Camping status";
            chart_generalInfo.Legends[0].BorderColor = Color.Black;

            chart_generalInfo.Series.Add("Status");
            chart_generalInfo.Series["Status"].ChartType = SeriesChartType.Pie;
            chart_generalInfo.Series["Status"]["PieLabelStyle"] = "Outside";
            chart_generalInfo.Series["Status"]["PieLineColor"] = "Black";
            chart_generalInfo.Series["Status"].IsValueShownAsLabel = true;

            int[] status = manager.visitorCampingStatus();
            chart_generalInfo.Series["Status"].Points.AddXY("Not in event", status[0]);
            chart_generalInfo.Series["Status"].Points.AddXY("Don't have camping", status[1]);
            chart_generalInfo.Series["Status"].Points.AddXY("Check in camping", status[2]);
            chart_generalInfo.Series["Status"].Points.AddXY("Check out camping", status[3]);
        }

        private void lb_campingSpot_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Spot currentSpot = (Spot)this.lb_campingSpot.SelectedItem;
                this.lb_campInfo.Items.Clear();
                this.lb_campInfo.Items.Add($"Spot id: {currentSpot.Id} Info:");
                foreach (User user in manager.getSpotUser(currentSpot))
                {
                    Console.WriteLine(user);
                    this.lb_campInfo.Items.Add("\t" + user);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
