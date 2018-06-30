namespace ATM_Apps
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dir = new System.Windows.Forms.TextBox();
            this.bt_browse = new System.Windows.Forms.Button();
            this.lb_log = new System.Windows.Forms.ListBox();
            this.lbl_log = new System.Windows.Forms.Label();
            this.bt_view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Image = global::ATM_Apps.Properties.Resources.Close_icon;
            this.close.Location = new System.Drawing.Point(577, 1);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM";
            // 
            // tb_dir
            // 
            this.tb_dir.Location = new System.Drawing.Point(16, 137);
            this.tb_dir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_dir.Name = "tb_dir";
            this.tb_dir.ReadOnly = true;
            this.tb_dir.Size = new System.Drawing.Size(412, 22);
            this.tb_dir.TabIndex = 2;
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(440, 134);
            this.bt_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(161, 28);
            this.bt_browse.TabIndex = 3;
            this.bt_browse.Text = "Change Location";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // lb_log
            // 
            this.lb_log.FormattingEnabled = true;
            this.lb_log.HorizontalScrollbar = true;
            this.lb_log.ItemHeight = 16;
            this.lb_log.Location = new System.Drawing.Point(16, 193);
            this.lb_log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_log.Name = "lb_log";
            this.lb_log.Size = new System.Drawing.Size(585, 228);
            this.lb_log.TabIndex = 4;
            // 
            // lbl_log
            // 
            this.lbl_log.AutoSize = true;
            this.lbl_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_log.Location = new System.Drawing.Point(248, 169);
            this.lbl_log.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_log.Name = "lbl_log";
            this.lbl_log.Size = new System.Drawing.Size(129, 20);
            this.lbl_log.TabIndex = 5;
            this.lbl_log.Text = "Transaction info";
            // 
            // bt_view
            // 
            this.bt_view.Location = new System.Drawing.Point(218, 429);
            this.bt_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_view.Name = "bt_view";
            this.bt_view.Size = new System.Drawing.Size(173, 28);
            this.bt_view.TabIndex = 6;
            this.bt_view.Text = "View this transaction";
            this.bt_view.UseVisualStyleBackColor = true;
            this.bt_view.Click += new System.EventHandler(this.bt_view_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 470);
            this.Controls.Add(this.bt_view);
            this.Controls.Add(this.lbl_log);
            this.Controls.Add(this.lb_log);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.tb_dir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_dir;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.ListBox lb_log;
        private System.Windows.Forms.Label lbl_log;
        private System.Windows.Forms.Button bt_view;
    }
}

