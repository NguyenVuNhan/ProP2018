namespace Add_Visitor
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
            this.lblCode = new System.Windows.Forms.Label();
            this.lblMinBalance = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.RbSpot = new System.Windows.Forms.RadioButton();
            this.RbFriendSpot = new System.Windows.Forms.RadioButton();
            this.RbNoSpot = new System.Windows.Forms.RadioButton();
            this.lblDOB = new System.Windows.Forms.Label();
            this.tbDOB = new System.Windows.Forms.DateTimePicker();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(274, 262);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(105, 17);
            this.lblCode.TabIndex = 82;
            this.lblCode.Text = "Invitation Code ";
            // 
            // lblMinBalance
            // 
            this.lblMinBalance.AutoSize = true;
            this.lblMinBalance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMinBalance.ForeColor = System.Drawing.Color.Red;
            this.lblMinBalance.Location = new System.Drawing.Point(254, 413);
            this.lblMinBalance.Name = "lblMinBalance";
            this.lblMinBalance.Size = new System.Drawing.Size(54, 17);
            this.lblMinBalance.TabIndex = 81;
            this.lblMinBalance.Text = "Min 5 €";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(257, 40);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 22);
            this.tbEmail.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(257, 445);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Visitor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(163, 392);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 17);
            this.lblBalance.TabIndex = 77;
            this.lblBalance.Text = "Balance";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(257, 389);
            this.tbBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(178, 22);
            this.tbBalance.TabIndex = 6;
            this.tbBalance.Text = "0";
            // 
            // tbCode
            // 
            this.tbCode.Location = new System.Drawing.Point(399, 259);
            this.tbCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(128, 22);
            this.tbCode.TabIndex = 5;
            this.tbCode.Tag = "";
            // 
            // RbSpot
            // 
            this.RbSpot.AutoSize = true;
            this.RbSpot.Location = new System.Drawing.Point(83, 297);
            this.RbSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbSpot.Name = "RbSpot";
            this.RbSpot.Size = new System.Drawing.Size(178, 21);
            this.RbSpot.TabIndex = 74;
            this.RbSpot.TabStop = true;
            this.RbSpot.Text = "Available Camping Spot";
            this.RbSpot.UseVisualStyleBackColor = true;
            // 
            // RbFriendSpot
            // 
            this.RbFriendSpot.AutoSize = true;
            this.RbFriendSpot.Location = new System.Drawing.Point(83, 260);
            this.RbFriendSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbFriendSpot.Name = "RbFriendSpot";
            this.RbFriendSpot.Size = new System.Drawing.Size(167, 21);
            this.RbFriendSpot.TabIndex = 73;
            this.RbFriendSpot.TabStop = true;
            this.RbFriendSpot.Text = "Friend\'s CampingSpot";
            this.RbFriendSpot.UseVisualStyleBackColor = true;
            // 
            // RbNoSpot
            // 
            this.RbNoSpot.AutoSize = true;
            this.RbNoSpot.Location = new System.Drawing.Point(83, 337);
            this.RbNoSpot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RbNoSpot.Name = "RbNoSpot";
            this.RbNoSpot.Size = new System.Drawing.Size(139, 21);
            this.RbNoSpot.TabIndex = 10;
            this.RbNoSpot.TabStop = true;
            this.RbNoSpot.Text = "No Camping Spot";
            this.RbNoSpot.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(163, 215);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(87, 17);
            this.lblDOB.TabIndex = 71;
            this.lblDOB.Text = "Date of Birth";
            // 
            // tbDOB
            // 
            this.tbDOB.CustomFormat = "yyyy-MM-dd";
            this.tbDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbDOB.Location = new System.Drawing.Point(257, 210);
            this.tbDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDOB.Name = "tbDOB";
            this.tbDOB.Size = new System.Drawing.Size(178, 22);
            this.tbDOB.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(257, 167);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(178, 22);
            this.tbLastName.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(257, 124);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(178, 22);
            this.tbFirstName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(257, 80);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(178, 22);
            this.tbPassword.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(163, 170);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 62;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(163, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 61;
            this.lblFirstName.Text = "First Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(163, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 60;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(163, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(132, 511);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 85;
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 537);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblMinBalance);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.RbSpot);
            this.Controls.Add(this.RbFriendSpot);
            this.Controls.Add(this.RbNoSpot);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.tbDOB);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Visitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblMinBalance;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.RadioButton RbSpot;
        private System.Windows.Forms.RadioButton RbFriendSpot;
        private System.Windows.Forms.RadioButton RbNoSpot;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker tbDOB;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer1;
    }
}

