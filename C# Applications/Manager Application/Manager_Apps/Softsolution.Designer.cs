namespace Manager_Apps
{
    partial class Softsolution
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Softsolution));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_employee = new System.Windows.Forms.Button();
            this.bt_visitor = new System.Windows.Forms.Button();
            this.bt_StockManager = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_camping = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.login = new Manager_Apps.Login();
            this.employee = new Manager_Apps.Employee();
            this.visitor = new Manager_Apps.Visitor();
            this.stockManager = new Manager_Apps.StockManager();
            this.campingSpot = new Manager_Apps.CampingSpot();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bt_Login);
            this.panel1.Controls.Add(this.bt_employee);
            this.panel1.Controls.Add(this.bt_visitor);
            this.panel1.Controls.Add(this.bt_StockManager);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bt_camping);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 646);
            this.panel1.TabIndex = 0;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bt_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Login.FlatAppearance.BorderSize = 0;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.White;
            this.bt_Login.Image = global::Manager_Apps.Properties.Resources.login;
            this.bt_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_Login.Location = new System.Drawing.Point(16, 375);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(213, 54);
            this.bt_Login.TabIndex = 9;
            this.bt_Login.Text = "Login";
            this.bt_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_employee
            // 
            this.bt_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bt_employee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_employee.FlatAppearance.BorderSize = 0;
            this.bt_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_employee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_employee.ForeColor = System.Drawing.Color.White;
            this.bt_employee.Image = global::Manager_Apps.Properties.Resources.employee;
            this.bt_employee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_employee.Location = new System.Drawing.Point(16, 314);
            this.bt_employee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_employee.Name = "bt_employee";
            this.bt_employee.Size = new System.Drawing.Size(213, 54);
            this.bt_employee.TabIndex = 8;
            this.bt_employee.Text = "Employee";
            this.bt_employee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_employee.UseVisualStyleBackColor = false;
            this.bt_employee.Click += new System.EventHandler(this.bt_employee_Click);
            // 
            // bt_visitor
            // 
            this.bt_visitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bt_visitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_visitor.FlatAppearance.BorderSize = 0;
            this.bt_visitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_visitor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_visitor.ForeColor = System.Drawing.Color.White;
            this.bt_visitor.Image = global::Manager_Apps.Properties.Resources.visitor;
            this.bt_visitor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_visitor.Location = new System.Drawing.Point(16, 252);
            this.bt_visitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_visitor.Name = "bt_visitor";
            this.bt_visitor.Size = new System.Drawing.Size(213, 54);
            this.bt_visitor.TabIndex = 7;
            this.bt_visitor.Text = "Visitor";
            this.bt_visitor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_visitor.UseVisualStyleBackColor = false;
            this.bt_visitor.Click += new System.EventHandler(this.bt_visitor_Click);
            // 
            // bt_StockManager
            // 
            this.bt_StockManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bt_StockManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_StockManager.FlatAppearance.BorderSize = 0;
            this.bt_StockManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_StockManager.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_StockManager.ForeColor = System.Drawing.Color.White;
            this.bt_StockManager.Image = global::Manager_Apps.Properties.Resources.wareHouse;
            this.bt_StockManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_StockManager.Location = new System.Drawing.Point(16, 191);
            this.bt_StockManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_StockManager.Name = "bt_StockManager";
            this.bt_StockManager.Size = new System.Drawing.Size(213, 54);
            this.bt_StockManager.TabIndex = 2;
            this.bt_StockManager.Text = "Warehouse";
            this.bt_StockManager.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_StockManager.UseVisualStyleBackColor = false;
            this.bt_StockManager.Click += new System.EventHandler(this.bt_StockManager_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Location = new System.Drawing.Point(0, 129);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 54);
            this.panel3.TabIndex = 2;
            // 
            // bt_camping
            // 
            this.bt_camping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.bt_camping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_camping.FlatAppearance.BorderSize = 0;
            this.bt_camping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_camping.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_camping.ForeColor = System.Drawing.Color.White;
            this.bt_camping.Image = global::Manager_Apps.Properties.Resources.camp;
            this.bt_camping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_camping.Location = new System.Drawing.Point(16, 129);
            this.bt_camping.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_camping.Name = "bt_camping";
            this.bt_camping.Size = new System.Drawing.Size(213, 54);
            this.bt_camping.TabIndex = 2;
            this.bt_camping.Text = "Camping Spot";
            this.bt_camping.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_camping.UseVisualStyleBackColor = false;
            this.bt_camping.Click += new System.EventHandler(this.bt_camping_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(229, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 12);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Manager_Apps.Properties.Resources.soft_solution_icon;
            this.pictureBox1.Location = new System.Drawing.Point(255, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // bt_close
            // 
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ForeColor = System.Drawing.Color.Black;
            this.bt_close.Image = ((System.Drawing.Image)(resources.GetObject("bt_close.Image")));
            this.bt_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_close.Location = new System.Drawing.Point(1401, 16);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(43, 43);
            this.bt_close.TabIndex = 5;
            this.bt_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(333, 16);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(363, 40);
            this.lbl_status.TabIndex = 10;
            this.lbl_status.Text = "Manager application";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(229, 76);
            this.login.Margin = new System.Windows.Forms.Padding(5);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1232, 570);
            this.login.TabIndex = 8;
            this.login.Load += new System.EventHandler(this.login_Load);
            // 
            // employee
            // 
            this.employee.Location = new System.Drawing.Point(229, 76);
            this.employee.Margin = new System.Windows.Forms.Padding(5);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(1232, 570);
            this.employee.TabIndex = 7;
            // 
            // visitor
            // 
            this.visitor.Location = new System.Drawing.Point(229, 76);
            this.visitor.Margin = new System.Windows.Forms.Padding(5);
            this.visitor.Name = "visitor";
            this.visitor.Size = new System.Drawing.Size(1232, 570);
            this.visitor.TabIndex = 4;
            // 
            // stockManager
            // 
            this.stockManager.Location = new System.Drawing.Point(229, 76);
            this.stockManager.Margin = new System.Windows.Forms.Padding(5);
            this.stockManager.Name = "stockManager";
            this.stockManager.Size = new System.Drawing.Size(1232, 570);
            this.stockManager.TabIndex = 3;
            // 
            // campingSpot
            // 
            this.campingSpot.BackColor = System.Drawing.SystemColors.Control;
            this.campingSpot.Location = new System.Drawing.Point(229, 76);
            this.campingSpot.Margin = new System.Windows.Forms.Padding(5);
            this.campingSpot.Name = "campingSpot";
            this.campingSpot.Size = new System.Drawing.Size(1232, 570);
            this.campingSpot.TabIndex = 2;
            // 
            // Softsolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 646);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.visitor);
            this.Controls.Add(this.stockManager);
            this.Controls.Add(this.campingSpot);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Softsolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_camping;
        private CampingSpot campingSpot;
        private System.Windows.Forms.Button bt_StockManager;
        private StockManager stockManager;
        private System.Windows.Forms.Button bt_visitor;
        private Visitor visitor;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_employee;
        private Employee employee;
        private System.Windows.Forms.Button bt_Login;
        private Login login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_status;
    }
}

