namespace Event_CheckInOut
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbReturn = new System.Windows.Forms.Label();
            this.LbInfo = new System.Windows.Forms.Label();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.TbReturnValue = new System.Windows.Forms.TextBox();
            this.LbAlert = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblReturn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "→";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(222, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "↓";
            // 
            // LbReturn
            // 
            this.LbReturn.AutoSize = true;
            this.LbReturn.ForeColor = System.Drawing.Color.DarkGreen;
            this.LbReturn.Location = new System.Drawing.Point(107, 63);
            this.LbReturn.Name = "LbReturn";
            this.LbReturn.Size = new System.Drawing.Size(0, 17);
            this.LbReturn.TabIndex = 14;
            this.LbReturn.Visible = false;
            // 
            // LbInfo
            // 
            this.LbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInfo.ForeColor = System.Drawing.Color.DarkGreen;
            this.LbInfo.Location = new System.Drawing.Point(81, 417);
            this.LbInfo.MaximumSize = new System.Drawing.Size(350, 150);
            this.LbInfo.MinimumSize = new System.Drawing.Size(44, 32);
            this.LbInfo.Name = "LbInfo";
            this.LbInfo.Size = new System.Drawing.Size(350, 32);
            this.LbInfo.TabIndex = 13;
            this.LbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbMain
            // 
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.Location = new System.Drawing.Point(0, -2);
            this.pbMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(289, 271);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 12;
            this.pbMain.TabStop = false;
            // 
            // TbReturnValue
            // 
            this.TbReturnValue.Location = new System.Drawing.Point(134, 26);
            this.TbReturnValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbReturnValue.Name = "TbReturnValue";
            this.TbReturnValue.Size = new System.Drawing.Size(195, 22);
            this.TbReturnValue.TabIndex = 11;
            this.TbReturnValue.TextChanged += new System.EventHandler(this.TbReturnValue_TextChanged);
            // 
            // LbAlert
            // 
            this.LbAlert.AutoSize = true;
            this.LbAlert.Location = new System.Drawing.Point(131, 50);
            this.LbAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbAlert.Name = "LbAlert";
            this.LbAlert.Size = new System.Drawing.Size(0, 17);
            this.LbAlert.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblReturn
            // 
            this.lblReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturn.ForeColor = System.Drawing.Color.Black;
            this.lblReturn.Location = new System.Drawing.Point(81, 456);
            this.lblReturn.MaximumSize = new System.Drawing.Size(400, 80);
            this.lblReturn.MinimumSize = new System.Drawing.Size(44, 32);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(350, 32);
            this.lblReturn.TabIndex = 17;
            this.lblReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Location = new System.Drawing.Point(85, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 271);
            this.panel1.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbReturn);
            this.Controls.Add(this.LbInfo);
            this.Controls.Add(this.TbReturnValue);
            this.Controls.Add(this.LbAlert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 548);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 548);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn CheckOut";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbReturn;
        private System.Windows.Forms.Label LbInfo;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TextBox TbReturnValue;
        private System.Windows.Forms.Label LbAlert;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

