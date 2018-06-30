namespace ATM_Apps
{
    partial class TransactionInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionInfo));
            this.lb_user = new System.Windows.Forms.ListBox();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_user
            // 
            this.lb_user.FormattingEnabled = true;
            this.lb_user.HorizontalScrollbar = true;
            this.lb_user.ItemHeight = 16;
            this.lb_user.Location = new System.Drawing.Point(16, 15);
            this.lb_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(876, 164);
            this.lb_user.TabIndex = 1;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(401, 189);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(100, 28);
            this.bt_confirm.TabIndex = 2;
            this.bt_confirm.Text = "Ok";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // TransactionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 230);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.lb_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionInfo";
            this.Text = "TransactionInfo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_user;
        private System.Windows.Forms.Button bt_confirm;
    }
}