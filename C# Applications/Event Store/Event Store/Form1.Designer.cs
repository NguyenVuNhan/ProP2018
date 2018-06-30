namespace Event_Store
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.picBoxSouvenir = new System.Windows.Forms.PictureBox();
            this.picBoxDrink = new System.Windows.Forms.PictureBox();
            this.picBoxFood = new System.Windows.Forms.PictureBox();
            this.groupBoxCategoryRadiobtn = new System.Windows.Forms.GroupBox();
            this.radiobtnSouvenir = new System.Windows.Forms.RadioButton();
            this.radiobtnDrink = new System.Windows.Forms.RadioButton();
            this.radiobtnFood = new System.Windows.Forms.RadioButton();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffLevel = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.lblClientAlcohol = new System.Windows.Forms.Label();
            this.lblDefaultAlcohol = new System.Windows.Forms.Label();
            this.lblClientAge = new System.Windows.Forms.Label();
            this.lblDefaultAge = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.btnConfirmPurchase = new System.Windows.Forms.Button();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblDefaultTotal = new System.Windows.Forms.Label();
            this.panelClear = new System.Windows.Forms.Panel();
            this.panelAdd5 = new System.Windows.Forms.Panel();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelDeduct = new System.Windows.Forms.Panel();
            this.OrderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerDBCheck = new System.Windows.Forms.Timer(this.components);
            this.lblBalanceDefault = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSouvenir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).BeginInit();
            this.groupBoxCategoryRadiobtn.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBoxCategory.Controls.Add(this.groupBoxItems);
            this.groupBoxCategory.Controls.Add(this.picBoxSouvenir);
            this.groupBoxCategory.Controls.Add(this.picBoxDrink);
            this.groupBoxCategory.Controls.Add(this.picBoxFood);
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategory.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Size = new System.Drawing.Size(939, 471);
            this.groupBoxCategory.TabIndex = 0;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = "Category";
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(169, 14);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(763, 448);
            this.groupBoxItems.TabIndex = 3;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // picBoxSouvenir
            // 
            this.picBoxSouvenir.Image = global::Event_Store.Properties.Resources.icon_souv;
            this.picBoxSouvenir.Location = new System.Drawing.Point(6, 319);
            this.picBoxSouvenir.Name = "picBoxSouvenir";
            this.picBoxSouvenir.Size = new System.Drawing.Size(157, 143);
            this.picBoxSouvenir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSouvenir.TabIndex = 2;
            this.picBoxSouvenir.TabStop = false;
            this.picBoxSouvenir.Click += new System.EventHandler(this.picBoxSouvenir_Click);
            // 
            // picBoxDrink
            // 
            this.picBoxDrink.Image = global::Event_Store.Properties.Resources.icon_drink;
            this.picBoxDrink.Location = new System.Drawing.Point(6, 170);
            this.picBoxDrink.Name = "picBoxDrink";
            this.picBoxDrink.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.picBoxDrink.Size = new System.Drawing.Size(157, 143);
            this.picBoxDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDrink.TabIndex = 1;
            this.picBoxDrink.TabStop = false;
            this.picBoxDrink.Click += new System.EventHandler(this.picBoxDrink_Click);
            // 
            // picBoxFood
            // 
            this.picBoxFood.Image = ((System.Drawing.Image)(resources.GetObject("picBoxFood.Image")));
            this.picBoxFood.Location = new System.Drawing.Point(6, 21);
            this.picBoxFood.Name = "picBoxFood";
            this.picBoxFood.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.picBoxFood.Size = new System.Drawing.Size(157, 143);
            this.picBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFood.TabIndex = 0;
            this.picBoxFood.TabStop = false;
            this.picBoxFood.Click += new System.EventHandler(this.picBoxFood_Click);
            // 
            // groupBoxCategoryRadiobtn
            // 
            this.groupBoxCategoryRadiobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBoxCategoryRadiobtn.Controls.Add(this.radiobtnSouvenir);
            this.groupBoxCategoryRadiobtn.Controls.Add(this.radiobtnDrink);
            this.groupBoxCategoryRadiobtn.Controls.Add(this.radiobtnFood);
            this.groupBoxCategoryRadiobtn.Location = new System.Drawing.Point(797, 493);
            this.groupBoxCategoryRadiobtn.Name = "groupBoxCategoryRadiobtn";
            this.groupBoxCategoryRadiobtn.Size = new System.Drawing.Size(155, 120);
            this.groupBoxCategoryRadiobtn.TabIndex = 1;
            this.groupBoxCategoryRadiobtn.TabStop = false;
            this.groupBoxCategoryRadiobtn.Text = "hidden at runtime";
            // 
            // radiobtnSouvenir
            // 
            this.radiobtnSouvenir.AutoSize = true;
            this.radiobtnSouvenir.Location = new System.Drawing.Point(6, 87);
            this.radiobtnSouvenir.Name = "radiobtnSouvenir";
            this.radiobtnSouvenir.Size = new System.Drawing.Size(85, 21);
            this.radiobtnSouvenir.TabIndex = 2;
            this.radiobtnSouvenir.TabStop = true;
            this.radiobtnSouvenir.Text = "Souvenir";
            this.radiobtnSouvenir.UseVisualStyleBackColor = true;
            // 
            // radiobtnDrink
            // 
            this.radiobtnDrink.AutoSize = true;
            this.radiobtnDrink.Location = new System.Drawing.Point(7, 60);
            this.radiobtnDrink.Name = "radiobtnDrink";
            this.radiobtnDrink.Size = new System.Drawing.Size(62, 21);
            this.radiobtnDrink.TabIndex = 1;
            this.radiobtnDrink.TabStop = true;
            this.radiobtnDrink.Text = "Drink";
            this.radiobtnDrink.UseVisualStyleBackColor = true;
            // 
            // radiobtnFood
            // 
            this.radiobtnFood.AutoSize = true;
            this.radiobtnFood.Location = new System.Drawing.Point(7, 33);
            this.radiobtnFood.Name = "radiobtnFood";
            this.radiobtnFood.Size = new System.Drawing.Size(61, 21);
            this.radiobtnFood.TabIndex = 0;
            this.radiobtnFood.TabStop = true;
            this.radiobtnFood.Text = "Food";
            this.radiobtnFood.UseVisualStyleBackColor = true;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxUser.Controls.Add(this.lblStaffName);
            this.groupBoxUser.Controls.Add(this.lblStaffLevel);
            this.groupBoxUser.Controls.Add(this.btnLogOff);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(13, 493);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(200, 153);
            this.groupBoxUser.TabIndex = 3;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(6, 25);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(121, 25);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "John Smith";
            // 
            // lblStaffLevel
            // 
            this.lblStaffLevel.AutoSize = true;
            this.lblStaffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLevel.Location = new System.Drawing.Point(7, 57);
            this.lblStaffLevel.Name = "lblStaffLevel";
            this.lblStaffLevel.Size = new System.Drawing.Size(53, 24);
            this.lblStaffLevel.TabIndex = 1;
            this.lblStaffLevel.Text = "Clerk";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(6, 109);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(122, 38);
            this.btnLogOff.TabIndex = 0;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxClient.Controls.Add(this.lblBalance);
            this.groupBoxClient.Controls.Add(this.lblBalanceDefault);
            this.groupBoxClient.Controls.Add(this.btnEndSession);
            this.groupBoxClient.Controls.Add(this.lblClientAlcohol);
            this.groupBoxClient.Controls.Add(this.lblDefaultAlcohol);
            this.groupBoxClient.Controls.Add(this.lblClientAge);
            this.groupBoxClient.Controls.Add(this.lblDefaultAge);
            this.groupBoxClient.Controls.Add(this.lblClientName);
            this.groupBoxClient.Location = new System.Drawing.Point(219, 493);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(348, 153);
            this.groupBoxClient.TabIndex = 4;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // btnEndSession
            // 
            this.btnEndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSession.Location = new System.Drawing.Point(6, 109);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(141, 38);
            this.btnEndSession.TabIndex = 5;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // lblClientAlcohol
            // 
            this.lblClientAlcohol.AutoSize = true;
            this.lblClientAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAlcohol.Location = new System.Drawing.Point(97, 78);
            this.lblClientAlcohol.Name = "lblClientAlcohol";
            this.lblClientAlcohol.Size = new System.Drawing.Size(50, 24);
            this.lblClientAlcohol.TabIndex = 4;
            this.lblClientAlcohol.Text = "YES";
            // 
            // lblDefaultAlcohol
            // 
            this.lblDefaultAlcohol.AutoSize = true;
            this.lblDefaultAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultAlcohol.Location = new System.Drawing.Point(7, 78);
            this.lblDefaultAlcohol.Name = "lblDefaultAlcohol";
            this.lblDefaultAlcohol.Size = new System.Drawing.Size(84, 24);
            this.lblDefaultAlcohol.TabIndex = 3;
            this.lblDefaultAlcohol.Text = "Alcohol: ";
            // 
            // lblClientAge
            // 
            this.lblClientAge.AutoSize = true;
            this.lblClientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAge.Location = new System.Drawing.Point(117, 54);
            this.lblClientAge.Name = "lblClientAge";
            this.lblClientAge.Size = new System.Drawing.Size(30, 24);
            this.lblClientAge.TabIndex = 2;
            this.lblClientAge.Text = "18";
            // 
            // lblDefaultAge
            // 
            this.lblDefaultAge.AutoSize = true;
            this.lblDefaultAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultAge.Location = new System.Drawing.Point(7, 54);
            this.lblDefaultAge.Name = "lblDefaultAge";
            this.lblDefaultAge.Size = new System.Drawing.Size(50, 24);
            this.lblDefaultAge.TabIndex = 1;
            this.lblDefaultAge.Text = "Age:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(6, 26);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(96, 25);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Ivan Bok";
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelTotal.Controls.Add(this.btnConfirmPurchase);
            this.panelTotal.Controls.Add(this.lblOrderTotal);
            this.panelTotal.Controls.Add(this.lblDefaultTotal);
            this.panelTotal.Location = new System.Drawing.Point(959, 490);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(446, 156);
            this.panelTotal.TabIndex = 6;
            // 
            // btnConfirmPurchase
            // 
            this.btnConfirmPurchase.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPurchase.Location = new System.Drawing.Point(113, 69);
            this.btnConfirmPurchase.Name = "btnConfirmPurchase";
            this.btnConfirmPurchase.Size = new System.Drawing.Size(227, 56);
            this.btnConfirmPurchase.TabIndex = 7;
            this.btnConfirmPurchase.Text = "Confirm Purchase";
            this.btnConfirmPurchase.UseVisualStyleBackColor = false;
            this.btnConfirmPurchase.Click += new System.EventHandler(this.btnConfirmPurchase_Click);
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblOrderTotal.Location = new System.Drawing.Point(278, 24);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(62, 29);
            this.lblOrderTotal.TabIndex = 6;
            this.lblOrderTotal.Text = "0,00";
            // 
            // lblDefaultTotal
            // 
            this.lblDefaultTotal.AutoSize = true;
            this.lblDefaultTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblDefaultTotal.Location = new System.Drawing.Point(108, 24);
            this.lblDefaultTotal.Name = "lblDefaultTotal";
            this.lblDefaultTotal.Size = new System.Drawing.Size(80, 29);
            this.lblDefaultTotal.TabIndex = 5;
            this.lblDefaultTotal.Text = "Total:";
            // 
            // panelClear
            // 
            this.panelClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClear.BackColor = System.Drawing.Color.Transparent;
            this.panelClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelClear.BackgroundImage")));
            this.panelClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelClear.Location = new System.Drawing.Point(1411, 381);
            this.panelClear.Name = "panelClear";
            this.panelClear.Size = new System.Drawing.Size(105, 103);
            this.panelClear.TabIndex = 3;
            this.panelClear.Click += new System.EventHandler(this.panelClear_Click);
            // 
            // panelAdd5
            // 
            this.panelAdd5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdd5.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd5.BackgroundImage = global::Event_Store.Properties.Resources.add5;
            this.panelAdd5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdd5.Location = new System.Drawing.Point(1411, 261);
            this.panelAdd5.Name = "panelAdd5";
            this.panelAdd5.Size = new System.Drawing.Size(105, 103);
            this.panelAdd5.TabIndex = 4;
            this.panelAdd5.Click += new System.EventHandler(this.panelAdd5_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdd.BackColor = System.Drawing.Color.Transparent;
            this.panelAdd.BackgroundImage = global::Event_Store.Properties.Resources.add1;
            this.panelAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdd.Location = new System.Drawing.Point(1411, 136);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(105, 103);
            this.panelAdd.TabIndex = 5;
            this.panelAdd.Click += new System.EventHandler(this.panelAdd_Click);
            // 
            // panelDeduct
            // 
            this.panelDeduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDeduct.BackColor = System.Drawing.Color.Transparent;
            this.panelDeduct.BackgroundImage = global::Event_Store.Properties.Resources.remove_1;
            this.panelDeduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDeduct.Location = new System.Drawing.Point(1411, 13);
            this.panelDeduct.Name = "panelDeduct";
            this.panelDeduct.Size = new System.Drawing.Size(105, 103);
            this.panelDeduct.TabIndex = 2;
            this.panelDeduct.Click += new System.EventHandler(this.panelDeduct_Click);
            // 
            // OrderList
            // 
            this.OrderList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.OrderList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderList.FullRowSelect = true;
            this.OrderList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrderList.Location = new System.Drawing.Point(959, 13);
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(446, 471);
            this.OrderList.TabIndex = 7;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total";
            this.columnHeader3.Width = 75;
            // 
            // timerDBCheck
            // 
            this.timerDBCheck.Interval = 5000;
            this.timerDBCheck.Tick += new System.EventHandler(this.timerDBCheck_Tick);
            // 
            // lblBalanceDefault
            // 
            this.lblBalanceDefault.AutoSize = true;
            this.lblBalanceDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDefault.Location = new System.Drawing.Point(170, 54);
            this.lblBalanceDefault.Name = "lblBalanceDefault";
            this.lblBalanceDefault.Size = new System.Drawing.Size(83, 24);
            this.lblBalanceDefault.TabIndex = 6;
            this.lblBalanceDefault.Text = "Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(274, 54);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(50, 24);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Age:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1528, 652);
            this.ControlBox = false;
            this.Controls.Add(this.OrderList);
            this.Controls.Add(this.panelClear);
            this.Controls.Add(this.panelAdd5);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.panelDeduct);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxCategoryRadiobtn);
            this.Controls.Add(this.groupBoxCategory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Event Store";
            this.groupBoxCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSouvenir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDrink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFood)).EndInit();
            this.groupBoxCategoryRadiobtn.ResumeLayout(false);
            this.groupBoxCategoryRadiobtn.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.PictureBox picBoxSouvenir;
        private System.Windows.Forms.PictureBox picBoxDrink;
        private System.Windows.Forms.PictureBox picBoxFood;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.GroupBox groupBoxCategoryRadiobtn;
        private System.Windows.Forms.RadioButton radiobtnSouvenir;
        private System.Windows.Forms.RadioButton radiobtnDrink;
        private System.Windows.Forms.RadioButton radiobtnFood;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffLevel;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Label lblClientAlcohol;
        private System.Windows.Forms.Label lblDefaultAlcohol;
        private System.Windows.Forms.Label lblClientAge;
        private System.Windows.Forms.Label lblDefaultAge;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Button btnConfirmPurchase;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblDefaultTotal;
        private System.Windows.Forms.Panel panelDeduct;
        private System.Windows.Forms.Panel panelAdd5;
        private System.Windows.Forms.Panel panelClear;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timerDBCheck;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceDefault;
    }
}

