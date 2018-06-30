namespace Manager_Apps
{
    partial class Employee
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
            this.data_Employee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Job = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.tb_fequency = new System.Windows.Forms.TextBox();
            this.bt_refreshAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Employee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_Employee
            // 
            this.data_Employee.AllowUserToAddRows = false;
            this.data_Employee.AllowUserToDeleteRows = false;
            this.data_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Employee.Location = new System.Drawing.Point(4, 319);
            this.data_Employee.Margin = new System.Windows.Forms.Padding(4);
            this.data_Employee.MultiSelect = false;
            this.data_Employee.Name = "data_Employee";
            this.data_Employee.ReadOnly = true;
            this.data_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Employee.Size = new System.Drawing.Size(1224, 196);
            this.data_Employee.TabIndex = 0;
            this.data_Employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Employee_CellContentClick);
            this.data_Employee.SelectionChanged += new System.EventHandler(this.data_Employee_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 100;
            this.label1.Text = "All employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Job);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bt_Edit);
            this.groupBox1.Controls.Add(this.bt_Add);
            this.groupBox1.Controls.Add(this.tb_Password);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_Email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_ConfirmPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_UserName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_lastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_firstName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(225, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(755, 213);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add employee";
            // 
            // tb_Job
            // 
            this.tb_Job.Location = new System.Drawing.Point(148, 126);
            this.tb_Job.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Job.Name = "tb_Job";
            this.tb_Job.Size = new System.Drawing.Size(196, 22);
            this.tb_Job.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Job";
            // 
            // bt_Edit
            // 
            this.bt_Edit.Enabled = false;
            this.bt_Edit.Location = new System.Drawing.Point(449, 169);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(191, 37);
            this.bt_Edit.TabIndex = 100;
            this.bt_Edit.Text = "Edit this employee";
            this.bt_Edit.UseVisualStyleBackColor = true;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(96, 169);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(191, 37);
            this.bt_Add.TabIndex = 100;
            this.bt_Add.Text = "Add this employee";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(515, 30);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(196, 22);
            this.tb_Password.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(515, 94);
            this.tb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(196, 22);
            this.tb_Email.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // tb_ConfirmPassword
            // 
            this.tb_ConfirmPassword.Location = new System.Drawing.Point(515, 62);
            this.tb_ConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ConfirmPassword.Name = "tb_ConfirmPassword";
            this.tb_ConfirmPassword.PasswordChar = '*';
            this.tb_ConfirmPassword.Size = new System.Drawing.Size(196, 22);
            this.tb_ConfirmPassword.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Confirm Password";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(148, 94);
            this.tb_UserName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(196, 22);
            this.tb_UserName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "User name";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(148, 62);
            this.tb_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(196, 22);
            this.tb_lastName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Last Name";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(148, 30);
            this.tb_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(196, 22);
            this.tb_firstName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "First name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee manager";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(321, 522);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(205, 38);
            this.bt_refresh.TabIndex = 100;
            this.bt_refresh.Text = "Refresh data";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // tb_fequency
            // 
            this.tb_fequency.Location = new System.Drawing.Point(885, 529);
            this.tb_fequency.Margin = new System.Windows.Forms.Padding(4);
            this.tb_fequency.Name = "tb_fequency";
            this.tb_fequency.Size = new System.Drawing.Size(51, 22);
            this.tb_fequency.TabIndex = 100;
            // 
            // bt_refreshAuto
            // 
            this.bt_refreshAuto.Location = new System.Drawing.Point(672, 522);
            this.bt_refreshAuto.Margin = new System.Windows.Forms.Padding(4);
            this.bt_refreshAuto.Name = "bt_refreshAuto";
            this.bt_refreshAuto.Size = new System.Drawing.Size(205, 38);
            this.bt_refreshAuto.TabIndex = 100;
            this.bt_refreshAuto.Text = "Enable Auto Refresh";
            this.bt_refreshAuto.UseVisualStyleBackColor = true;
            this.bt_refreshAuto.Click += new System.EventHandler(this.bt_refreshAuto_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_refreshAuto);
            this.Controls.Add(this.tb_fequency);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_Employee);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(1232, 570);
            ((System.ComponentModel.ISupportInitialize)(this.data_Employee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ConfirmPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Edit;
        private System.Windows.Forms.TextBox tb_Job;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.TextBox tb_fequency;
        private System.Windows.Forms.Button bt_refreshAuto;
    }
}
