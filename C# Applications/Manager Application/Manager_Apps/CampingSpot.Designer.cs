namespace Manager_Apps
{
    partial class CampingSpot
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_campingSpot = new System.Windows.Forms.ListBox();
            this.lb_campInfo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart_generalInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_generalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camping spot";
            // 
            // lb_campingSpot
            // 
            this.lb_campingSpot.FormattingEnabled = true;
            this.lb_campingSpot.Location = new System.Drawing.Point(15, 34);
            this.lb_campingSpot.Name = "lb_campingSpot";
            this.lb_campingSpot.Size = new System.Drawing.Size(235, 407);
            this.lb_campingSpot.TabIndex = 1;
            this.lb_campingSpot.SelectedIndexChanged += new System.EventHandler(this.lb_campingSpot_SelectedIndexChanged);
            // 
            // lb_campInfo
            // 
            this.lb_campInfo.FormattingEnabled = true;
            this.lb_campInfo.HorizontalScrollbar = true;
            this.lb_campInfo.Location = new System.Drawing.Point(282, 34);
            this.lb_campInfo.Name = "lb_campInfo";
            this.lb_campInfo.Size = new System.Drawing.Size(621, 95);
            this.lb_campInfo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Spot Info";
            // 
            // chart_generalInfo
            // 
            this.chart_generalInfo.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            chartArea1.Name = "ChartArea1";
            this.chart_generalInfo.ChartAreas.Add(chartArea1);
            this.chart_generalInfo.Cursor = System.Windows.Forms.Cursors.Cross;
            legend1.Name = "Legend1";
            this.chart_generalInfo.Legends.Add(legend1);
            this.chart_generalInfo.Location = new System.Drawing.Point(282, 135);
            this.chart_generalInfo.Name = "chart_generalInfo";
            this.chart_generalInfo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Status";
            this.chart_generalInfo.Series.Add(series1);
            this.chart_generalInfo.Size = new System.Drawing.Size(621, 306);
            this.chart_generalInfo.TabIndex = 6;
            this.chart_generalInfo.Text = "chart_generalInfo";
            // 
            // CampingSpot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.chart_generalInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_campInfo);
            this.Controls.Add(this.lb_campingSpot);
            this.Controls.Add(this.label1);
            this.Name = "CampingSpot";
            this.Size = new System.Drawing.Size(924, 463);
            ((System.ComponentModel.ISupportInitialize)(this.chart_generalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_campingSpot;
        private System.Windows.Forms.ListBox lb_campInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_generalInfo;
    }
}
