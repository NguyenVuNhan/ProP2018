namespace Camping_CheckIn_CheckOut
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Lbshow1 = new System.Windows.Forms.Label();
            this.Lbshow = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.Lbinfo = new System.Windows.Forms.Label();
            this.LbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbshow1
            // 
            this.Lbshow1.AutoSize = true;
            this.Lbshow1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Lbshow1.Location = new System.Drawing.Point(45, 302);
            this.Lbshow1.Name = "Lbshow1";
            this.Lbshow1.Size = new System.Drawing.Size(22, 17);
            this.Lbshow1.TabIndex = 9;
            this.Lbshow1.Text = "→";
            // 
            // Lbshow
            // 
            this.Lbshow.AutoSize = true;
            this.Lbshow.ForeColor = System.Drawing.Color.SteelBlue;
            this.Lbshow.Location = new System.Drawing.Point(213, 22);
            this.Lbshow.Name = "Lbshow";
            this.Lbshow.Size = new System.Drawing.Size(15, 17);
            this.Lbshow.TabIndex = 8;
            this.Lbshow.Text = "↓";
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(247, 202);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 7;
            this.pbMain.TabStop = false;
            // 
            // Lbinfo
            // 
            this.Lbinfo.AutoSize = true;
            this.Lbinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbinfo.Location = new System.Drawing.Point(96, 302);
            this.Lbinfo.Name = "Lbinfo";
            this.Lbinfo.Size = new System.Drawing.Size(0, 17);
            this.Lbinfo.TabIndex = 6;
            // 
            // LbTime
            // 
            this.LbTime.AutoSize = true;
            this.LbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LbTime.Location = new System.Drawing.Point(12, 9);
            this.LbTime.Name = "LbTime";
            this.LbTime.Size = new System.Drawing.Size(0, 17);
            this.LbTime.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Location = new System.Drawing.Point(99, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 202);
            this.panel1.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 345);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbshow1);
            this.Controls.Add(this.Lbshow);
            this.Controls.Add(this.Lbinfo);
            this.Controls.Add(this.LbTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camping CheckIn CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbshow1;
        private System.Windows.Forms.Label Lbshow;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Label Lbinfo;
        private System.Windows.Forms.Label LbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}

