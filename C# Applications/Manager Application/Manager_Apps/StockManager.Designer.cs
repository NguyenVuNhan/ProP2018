namespace Manager_Apps
{
    partial class StockManager
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
            this.chart_Stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_LowStockProduct = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_requestProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Stock
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Stock.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Stock.Legends.Add(legend1);
            this.chart_Stock.Location = new System.Drawing.Point(20, 69);
            this.chart_Stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_Stock.Name = "chart_Stock";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Stock.Series.Add(series1);
            this.chart_Stock.Size = new System.Drawing.Size(988, 486);
            this.chart_Stock.TabIndex = 0;
            this.chart_Stock.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Infomation";
            // 
            // lb_LowStockProduct
            // 
            this.lb_LowStockProduct.FormattingEnabled = true;
            this.lb_LowStockProduct.ItemHeight = 16;
            this.lb_LowStockProduct.Location = new System.Drawing.Point(1016, 92);
            this.lb_LowStockProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_LowStockProduct.Name = "lb_LowStockProduct";
            this.lb_LowStockProduct.Size = new System.Drawing.Size(211, 404);
            this.lb_LowStockProduct.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1017, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Low stock product";
            // 
            // bt_requestProduct
            // 
            this.bt_requestProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_requestProduct.Location = new System.Drawing.Point(1031, 507);
            this.bt_requestProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_requestProduct.Name = "bt_requestProduct";
            this.bt_requestProduct.Size = new System.Drawing.Size(177, 48);
            this.bt_requestProduct.TabIndex = 4;
            this.bt_requestProduct.Text = "Restock all product";
            this.bt_requestProduct.UseVisualStyleBackColor = true;
            this.bt_requestProduct.Click += new System.EventHandler(this.bt_requestProduct_Click);
            // 
            // StockManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_requestProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_LowStockProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_Stock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockManager";
            this.Size = new System.Drawing.Size(1232, 570);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_LowStockProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_requestProduct;
    }
}
