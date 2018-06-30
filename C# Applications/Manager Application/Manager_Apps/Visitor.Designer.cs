namespace Manager_Apps
{
    partial class Visitor
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
            this.chart_visitor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_showInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_User = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_ageStatus = new System.Windows.Forms.RadioButton();
            this.rbt_campingStatus = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart_visitor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart_visitor
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_visitor.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Name = "Legend1";
            legend1.Title = "CustomerStatus";
            this.chart_visitor.Legends.Add(legend1);
            this.chart_visitor.Location = new System.Drawing.Point(15, 46);
            this.chart_visitor.Margin = new System.Windows.Forms.Padding(1);
            this.chart_visitor.Name = "chart_visitor";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Status";
            this.chart_visitor.Series.Add(series1);
            this.chart_visitor.Size = new System.Drawing.Size(584, 414);
            this.chart_visitor.TabIndex = 0;
            this.chart_visitor.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visitor Infomation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_showInfo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Search);
            this.groupBox1.Controls.Add(this.lb_User);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(605, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 414);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // bt_showInfo
            // 
            this.bt_showInfo.Location = new System.Drawing.Point(87, 323);
            this.bt_showInfo.Name = "bt_showInfo";
            this.bt_showInfo.Size = new System.Drawing.Size(139, 23);
            this.bt_showInfo.TabIndex = 5;
            this.bt_showInfo.Text = "Show this visitor info";
            this.bt_showInfo.UseVisualStyleBackColor = true;
            this.bt_showInfo.Click += new System.EventHandler(this.bt_showInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search in visitor list";
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(6, 40);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(303, 20);
            this.tb_Search.TabIndex = 2;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_User
            // 
            this.lb_User.FormattingEnabled = true;
            this.lb_User.Location = new System.Drawing.Point(6, 66);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(304, 251);
            this.lb_User.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_ageStatus);
            this.panel1.Controls.Add(this.rbt_campingStatus);
            this.panel1.Location = new System.Drawing.Point(6, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 54);
            this.panel1.TabIndex = 0;
            // 
            // rbt_ageStatus
            // 
            this.rbt_ageStatus.AutoSize = true;
            this.rbt_ageStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_ageStatus.Location = new System.Drawing.Point(4, 30);
            this.rbt_ageStatus.Name = "rbt_ageStatus";
            this.rbt_ageStatus.Size = new System.Drawing.Size(173, 21);
            this.rbt_ageStatus.TabIndex = 1;
            this.rbt_ageStatus.TabStop = true;
            this.rbt_ageStatus.Text = "Show visitor age status";
            this.rbt_ageStatus.UseVisualStyleBackColor = true;
            this.rbt_ageStatus.CheckedChanged += new System.EventHandler(this.rbt_ageStatus_CheckedChanged);
            // 
            // rbt_campingStatus
            // 
            this.rbt_campingStatus.AutoSize = true;
            this.rbt_campingStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_campingStatus.Location = new System.Drawing.Point(4, 3);
            this.rbt_campingStatus.Name = "rbt_campingStatus";
            this.rbt_campingStatus.Size = new System.Drawing.Size(206, 21);
            this.rbt_campingStatus.TabIndex = 0;
            this.rbt_campingStatus.TabStop = true;
            this.rbt_campingStatus.Text = "Show visitor purchase status";
            this.rbt_campingStatus.UseVisualStyleBackColor = true;
            this.rbt_campingStatus.CheckedChanged += new System.EventHandler(this.rbt_campingStatus_CheckedChanged);
            // 
            // Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_visitor);
            this.Name = "Visitor";
            this.Size = new System.Drawing.Size(924, 463);
            ((System.ComponentModel.ISupportInitialize)(this.chart_visitor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_visitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.ListBox lb_User;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_ageStatus;
        private System.Windows.Forms.RadioButton rbt_campingStatus;
        private System.Windows.Forms.Button bt_showInfo;
    }
}
