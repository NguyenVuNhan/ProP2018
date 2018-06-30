namespace Loan_Application
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
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.groupBoxLoanSection = new System.Windows.Forms.GroupBox();
            this.pnlClearList = new System.Windows.Forms.Panel();
            this.pnlRemoveItem = new System.Windows.Forms.Panel();
            this.pnlConfirmLoan = new System.Windows.Forms.Panel();
            this.lblDefaultTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.OrderList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxReturnSection = new System.Windows.Forms.GroupBox();
            this.groupBoxReturnItem = new System.Windows.Forms.GroupBox();
            this.lblReturnItem = new System.Windows.Forms.Label();
            this.lblReturnStatus = new System.Windows.Forms.Label();
            this.lblDefaultItem = new System.Windows.Forms.Label();
            this.lblDefaultStatus = new System.Windows.Forms.Label();
            this.lBoxReturnItems = new System.Windows.Forms.ListBox();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lblDefaultReturnPenalty = new System.Windows.Forms.Label();
            this.groupBoxReturnedCondition = new System.Windows.Forms.GroupBox();
            this.pnlDamaged = new System.Windows.Forms.Panel();
            this.pnlNoDamage = new System.Windows.Forms.Panel();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lbldefaultBalance = new System.Windows.Forms.Label();
            this.btnEndSession = new System.Windows.Forms.Button();
            this.lblClientAge = new System.Windows.Forms.Label();
            this.lblDefaultAge = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblStaffLevel = new System.Windows.Forms.Label();
            this.btnLogOff = new System.Windows.Forms.Button();
            this.timerDBCheck = new System.Windows.Forms.Timer(this.components);
            this.groupBoxLoanSection.SuspendLayout();
            this.groupBoxReturnSection.SuspendLayout();
            this.groupBoxReturnItem.SuspendLayout();
            this.groupBoxReturnedCondition.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(15, 26);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Size = new System.Drawing.Size(952, 527);
            this.groupBoxItems.TabIndex = 0;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // groupBoxLoanSection
            // 
            this.groupBoxLoanSection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxLoanSection.Controls.Add(this.pnlClearList);
            this.groupBoxLoanSection.Controls.Add(this.pnlRemoveItem);
            this.groupBoxLoanSection.Controls.Add(this.pnlConfirmLoan);
            this.groupBoxLoanSection.Controls.Add(this.lblDefaultTotal);
            this.groupBoxLoanSection.Controls.Add(this.lblTotal);
            this.groupBoxLoanSection.Controls.Add(this.OrderList);
            this.groupBoxLoanSection.Controls.Add(this.groupBoxItems);
            this.groupBoxLoanSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLoanSection.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLoanSection.Name = "groupBoxLoanSection";
            this.groupBoxLoanSection.Size = new System.Drawing.Size(1426, 565);
            this.groupBoxLoanSection.TabIndex = 1;
            this.groupBoxLoanSection.TabStop = false;
            this.groupBoxLoanSection.Text = "Loan Section";
            // 
            // pnlClearList
            // 
            this.pnlClearList.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlClearList.BackgroundImage = global::Loan_Application.Properties.Resources.clear;
            this.pnlClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlClearList.Location = new System.Drawing.Point(991, 493);
            this.pnlClearList.Name = "pnlClearList";
            this.pnlClearList.Size = new System.Drawing.Size(188, 60);
            this.pnlClearList.TabIndex = 14;
            this.pnlClearList.Click += new System.EventHandler(this.pnlClearList_Click);
            // 
            // pnlRemoveItem
            // 
            this.pnlRemoveItem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlRemoveItem.BackgroundImage = global::Loan_Application.Properties.Resources.remove;
            this.pnlRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRemoveItem.Location = new System.Drawing.Point(991, 424);
            this.pnlRemoveItem.Name = "pnlRemoveItem";
            this.pnlRemoveItem.Size = new System.Drawing.Size(188, 63);
            this.pnlRemoveItem.TabIndex = 15;
            this.pnlRemoveItem.Click += new System.EventHandler(this.pnlRemoveItem_Click);
            // 
            // pnlConfirmLoan
            // 
            this.pnlConfirmLoan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlConfirmLoan.BackgroundImage = global::Loan_Application.Properties.Resources.confirm;
            this.pnlConfirmLoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlConfirmLoan.Location = new System.Drawing.Point(1215, 424);
            this.pnlConfirmLoan.Name = "pnlConfirmLoan";
            this.pnlConfirmLoan.Size = new System.Drawing.Size(186, 129);
            this.pnlConfirmLoan.TabIndex = 0;
            this.pnlConfirmLoan.Click += new System.EventHandler(this.pnlConfirmLoan_Click);
            // 
            // lblDefaultTotal
            // 
            this.lblDefaultTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDefaultTotal.AutoSize = true;
            this.lblDefaultTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultTotal.Location = new System.Drawing.Point(1099, 392);
            this.lblDefaultTotal.Name = "lblDefaultTotal";
            this.lblDefaultTotal.Size = new System.Drawing.Size(80, 29);
            this.lblDefaultTotal.TabIndex = 11;
            this.lblDefaultTotal.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1212, 392);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(85, 29);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "label1";
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
            this.OrderList.Location = new System.Drawing.Point(973, 26);
            this.OrderList.MultiSelect = false;
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(446, 352);
            this.OrderList.TabIndex = 8;
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
            // groupBoxReturnSection
            // 
            this.groupBoxReturnSection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxReturnSection.Controls.Add(this.groupBoxReturnItem);
            this.groupBoxReturnSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReturnSection.Location = new System.Drawing.Point(13, 583);
            this.groupBoxReturnSection.Name = "groupBoxReturnSection";
            this.groupBoxReturnSection.Size = new System.Drawing.Size(1356, 206);
            this.groupBoxReturnSection.TabIndex = 2;
            this.groupBoxReturnSection.TabStop = false;
            this.groupBoxReturnSection.Text = "Return Section";
            // 
            // groupBoxReturnItem
            // 
            this.groupBoxReturnItem.BackColor = System.Drawing.Color.LightGray;
            this.groupBoxReturnItem.Controls.Add(this.lblReturnItem);
            this.groupBoxReturnItem.Controls.Add(this.lblReturnStatus);
            this.groupBoxReturnItem.Controls.Add(this.lblDefaultItem);
            this.groupBoxReturnItem.Controls.Add(this.lblDefaultStatus);
            this.groupBoxReturnItem.Controls.Add(this.lBoxReturnItems);
            this.groupBoxReturnItem.Controls.Add(this.btnConfirmReturn);
            this.groupBoxReturnItem.Controls.Add(this.lblPenalty);
            this.groupBoxReturnItem.Controls.Add(this.lblDefaultReturnPenalty);
            this.groupBoxReturnItem.Controls.Add(this.groupBoxReturnedCondition);
            this.groupBoxReturnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxReturnItem.Location = new System.Drawing.Point(15, 27);
            this.groupBoxReturnItem.Name = "groupBoxReturnItem";
            this.groupBoxReturnItem.Size = new System.Drawing.Size(1330, 170);
            this.groupBoxReturnItem.TabIndex = 0;
            this.groupBoxReturnItem.TabStop = false;
            this.groupBoxReturnItem.Text = "Return Item";
            // 
            // lblReturnItem
            // 
            this.lblReturnItem.AutoSize = true;
            this.lblReturnItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnItem.Location = new System.Drawing.Point(970, 36);
            this.lblReturnItem.Name = "lblReturnItem";
            this.lblReturnItem.Size = new System.Drawing.Size(54, 25);
            this.lblReturnItem.TabIndex = 13;
            this.lblReturnItem.Text = "0,00";
            // 
            // lblReturnStatus
            // 
            this.lblReturnStatus.AutoSize = true;
            this.lblReturnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnStatus.Location = new System.Drawing.Point(970, 75);
            this.lblReturnStatus.Name = "lblReturnStatus";
            this.lblReturnStatus.Size = new System.Drawing.Size(54, 25);
            this.lblReturnStatus.TabIndex = 12;
            this.lblReturnStatus.Text = "0,00";
            // 
            // lblDefaultItem
            // 
            this.lblDefaultItem.AutoSize = true;
            this.lblDefaultItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultItem.Location = new System.Drawing.Point(775, 36);
            this.lblDefaultItem.Name = "lblDefaultItem";
            this.lblDefaultItem.Size = new System.Drawing.Size(53, 25);
            this.lblDefaultItem.TabIndex = 11;
            this.lblDefaultItem.Text = "Item";
            // 
            // lblDefaultStatus
            // 
            this.lblDefaultStatus.AutoSize = true;
            this.lblDefaultStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultStatus.Location = new System.Drawing.Point(775, 75);
            this.lblDefaultStatus.Name = "lblDefaultStatus";
            this.lblDefaultStatus.Size = new System.Drawing.Size(150, 25);
            this.lblDefaultStatus.TabIndex = 10;
            this.lblDefaultStatus.Text = "Return Status:";
            // 
            // lBoxReturnItems
            // 
            this.lBoxReturnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxReturnItems.FormattingEnabled = true;
            this.lBoxReturnItems.ItemHeight = 22;
            this.lBoxReturnItems.Location = new System.Drawing.Point(6, 26);
            this.lBoxReturnItems.Name = "lBoxReturnItems";
            this.lBoxReturnItems.Size = new System.Drawing.Size(385, 136);
            this.lBoxReturnItems.TabIndex = 9;
            this.lBoxReturnItems.SelectedIndexChanged += new System.EventHandler(this.lBoxReturnItems_SelectedIndexChanged);
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.BackColor = System.Drawing.Color.Lime;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReturn.Location = new System.Drawing.Point(1187, 36);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(137, 103);
            this.btnConfirmReturn.TabIndex = 8;
            this.btnConfirmReturn.Text = "CONFIRM RETURN";
            this.btnConfirmReturn.UseVisualStyleBackColor = false;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click);
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(970, 122);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(54, 25);
            this.lblPenalty.TabIndex = 7;
            this.lblPenalty.Text = "0,00";
            // 
            // lblDefaultReturnPenalty
            // 
            this.lblDefaultReturnPenalty.AutoSize = true;
            this.lblDefaultReturnPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultReturnPenalty.Location = new System.Drawing.Point(775, 122);
            this.lblDefaultReturnPenalty.Name = "lblDefaultReturnPenalty";
            this.lblDefaultReturnPenalty.Size = new System.Drawing.Size(91, 25);
            this.lblDefaultReturnPenalty.TabIndex = 6;
            this.lblDefaultReturnPenalty.Text = "Penalty:";
            // 
            // groupBoxReturnedCondition
            // 
            this.groupBoxReturnedCondition.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBoxReturnedCondition.Controls.Add(this.pnlDamaged);
            this.groupBoxReturnedCondition.Controls.Add(this.pnlNoDamage);
            this.groupBoxReturnedCondition.Location = new System.Drawing.Point(397, 26);
            this.groupBoxReturnedCondition.Name = "groupBoxReturnedCondition";
            this.groupBoxReturnedCondition.Size = new System.Drawing.Size(342, 136);
            this.groupBoxReturnedCondition.TabIndex = 3;
            this.groupBoxReturnedCondition.TabStop = false;
            this.groupBoxReturnedCondition.Text = "Returned Condition";
            // 
            // pnlDamaged
            // 
            this.pnlDamaged.BackgroundImage = global::Loan_Application.Properties.Resources.damaged;
            this.pnlDamaged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDamaged.Location = new System.Drawing.Point(181, 26);
            this.pnlDamaged.Name = "pnlDamaged";
            this.pnlDamaged.Size = new System.Drawing.Size(155, 95);
            this.pnlDamaged.TabIndex = 1;
            this.pnlDamaged.Click += new System.EventHandler(this.pnlDamaged_Click);
            // 
            // pnlNoDamage
            // 
            this.pnlNoDamage.BackgroundImage = global::Loan_Application.Properties.Resources.no_damage;
            this.pnlNoDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNoDamage.Location = new System.Drawing.Point(6, 26);
            this.pnlNoDamage.Name = "pnlNoDamage";
            this.pnlNoDamage.Size = new System.Drawing.Size(155, 95);
            this.pnlNoDamage.TabIndex = 0;
            this.pnlNoDamage.Click += new System.EventHandler(this.pnlNoDamage_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxClient.Controls.Add(this.lblBalance);
            this.groupBoxClient.Controls.Add(this.lbldefaultBalance);
            this.groupBoxClient.Controls.Add(this.btnEndSession);
            this.groupBoxClient.Controls.Add(this.lblClientAge);
            this.groupBoxClient.Controls.Add(this.lblDefaultAge);
            this.groupBoxClient.Controls.Add(this.lblClientName);
            this.groupBoxClient.Location = new System.Drawing.Point(218, 795);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(296, 130);
            this.groupBoxClient.TabIndex = 5;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(209, 45);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(50, 24);
            this.lblBalance.TabIndex = 7;
            this.lblBalance.Text = "Age:";
            // 
            // lbldefaultBalance
            // 
            this.lbldefaultBalance.AutoSize = true;
            this.lbldefaultBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefaultBalance.Location = new System.Drawing.Point(118, 45);
            this.lbldefaultBalance.Name = "lbldefaultBalance";
            this.lbldefaultBalance.Size = new System.Drawing.Size(83, 24);
            this.lbldefaultBalance.TabIndex = 6;
            this.lbldefaultBalance.Text = "Balance:";
            // 
            // btnEndSession
            // 
            this.btnEndSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndSession.Location = new System.Drawing.Point(6, 82);
            this.btnEndSession.Name = "btnEndSession";
            this.btnEndSession.Size = new System.Drawing.Size(148, 38);
            this.btnEndSession.TabIndex = 5;
            this.btnEndSession.Text = "End Session";
            this.btnEndSession.UseVisualStyleBackColor = true;
            this.btnEndSession.Click += new System.EventHandler(this.btnEndSession_Click);
            // 
            // lblClientAge
            // 
            this.lblClientAge.AutoSize = true;
            this.lblClientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientAge.Location = new System.Drawing.Point(63, 45);
            this.lblClientAge.Name = "lblClientAge";
            this.lblClientAge.Size = new System.Drawing.Size(30, 24);
            this.lblClientAge.TabIndex = 2;
            this.lblClientAge.Text = "18";
            // 
            // lblDefaultAge
            // 
            this.lblDefaultAge.AutoSize = true;
            this.lblDefaultAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultAge.Location = new System.Drawing.Point(7, 45);
            this.lblDefaultAge.Name = "lblDefaultAge";
            this.lblDefaultAge.Size = new System.Drawing.Size(50, 24);
            this.lblDefaultAge.TabIndex = 1;
            this.lblDefaultAge.Text = "Age:";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(6, 20);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(96, 25);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "Ivan Bok";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBoxUser.Controls.Add(this.lblStaffName);
            this.groupBoxUser.Controls.Add(this.lblStaffLevel);
            this.groupBoxUser.Controls.Add(this.btnLogOff);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(12, 795);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(200, 130);
            this.groupBoxUser.TabIndex = 6;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(6, 20);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(121, 25);
            this.lblStaffName.TabIndex = 2;
            this.lblStaffName.Text = "John Smith";
            // 
            // lblStaffLevel
            // 
            this.lblStaffLevel.AutoSize = true;
            this.lblStaffLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLevel.Location = new System.Drawing.Point(7, 45);
            this.lblStaffLevel.Name = "lblStaffLevel";
            this.lblStaffLevel.Size = new System.Drawing.Size(53, 24);
            this.lblStaffLevel.TabIndex = 1;
            this.lblStaffLevel.Text = "Clerk";
            // 
            // btnLogOff
            // 
            this.btnLogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOff.Location = new System.Drawing.Point(5, 82);
            this.btnLogOff.Name = "btnLogOff";
            this.btnLogOff.Size = new System.Drawing.Size(122, 38);
            this.btnLogOff.TabIndex = 0;
            this.btnLogOff.Text = "Log Off";
            this.btnLogOff.UseVisualStyleBackColor = true;
            this.btnLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // timerDBCheck
            // 
            this.timerDBCheck.Interval = 5000;
            this.timerDBCheck.Tick += new System.EventHandler(this.timerDBCheck_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1482, 937);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxReturnSection);
            this.Controls.Add(this.groupBoxLoanSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxLoanSection.ResumeLayout(false);
            this.groupBoxLoanSection.PerformLayout();
            this.groupBoxReturnSection.ResumeLayout(false);
            this.groupBoxReturnItem.ResumeLayout(false);
            this.groupBoxReturnItem.PerformLayout();
            this.groupBoxReturnedCondition.ResumeLayout(false);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.GroupBox groupBoxLoanSection;
        private System.Windows.Forms.GroupBox groupBoxReturnSection;
        private System.Windows.Forms.GroupBox groupBoxReturnItem;
        private System.Windows.Forms.GroupBox groupBoxReturnedCondition;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.Label lblPenalty;
        private System.Windows.Forms.Label lblDefaultReturnPenalty;
        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button btnEndSession;
        private System.Windows.Forms.Label lblClientAge;
        private System.Windows.Forms.Label lblDefaultAge;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblStaffLevel;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.ListView OrderList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDefaultTotal;
        private System.Windows.Forms.Panel pnlConfirmLoan;
        private System.Windows.Forms.Panel pnlClearList;
        private System.Windows.Forms.Panel pnlRemoveItem;
        private System.Windows.Forms.ListBox lBoxReturnItems;
        private System.Windows.Forms.Panel pnlNoDamage;
        private System.Windows.Forms.Panel pnlDamaged;
        private System.Windows.Forms.Label lblReturnItem;
        private System.Windows.Forms.Label lblReturnStatus;
        private System.Windows.Forms.Label lblDefaultItem;
        private System.Windows.Forms.Label lblDefaultStatus;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lbldefaultBalance;
        private System.Windows.Forms.Timer timerDBCheck;
    }
}

