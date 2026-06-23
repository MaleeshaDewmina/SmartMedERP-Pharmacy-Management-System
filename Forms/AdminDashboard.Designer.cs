namespace SmartMed.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.pnlSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSuppliers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategories = new Guna.UI2.WinForms.Guna2Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnMedicines = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAlerts = new Guna.UI2.WinForms.Guna2Panel();
            this.lblAlerts = new System.Windows.Forms.Label();
            this.lblAlertsTitle = new System.Windows.Forms.Label();
            this.pnlRevenueCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.pnlOrdersCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlCustomersCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.pnlMedicinesCard = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblMedicineCount = new System.Windows.Forms.Label();
            this.lblMedicinesTitle = new System.Windows.Forms.Label();
            this.lblLoggedUsers = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlAlerts.SuspendLayout();
            this.pnlRevenueCard.SuspendLayout();
            this.pnlOrdersCard.SuspendLayout();
            this.pnlCustomersCard.SuspendLayout();
            this.pnlMedicinesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Location = new System.Drawing.Point(121, 51);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(44, 16);
            this.lblLoggedUser.TabIndex = 0;
            this.lblLoggedUser.Text = "label1";
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnSuppliers);
            this.pnlSidebar.Controls.Add(this.btnCategories);
            this.pnlSidebar.Controls.Add(this.lblAppName);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(230, 653);
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Animated = true;
            this.btnSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.btnSuppliers.BorderRadius = 8;
            this.btnSuppliers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppliers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppliers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuppliers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuppliers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSuppliers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Location = new System.Drawing.Point(20, 210);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(190, 45);
            this.btnSuppliers.TabIndex = 4;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseTransparentBackground = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.Animated = true;
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.BorderRadius = 8;
            this.btnCategories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategories.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(20, 155);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(190, 45);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseTransparentBackground = true;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(10, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(214, 38);
            this.lblAppName.TabIndex = 2;
            this.lblAppName.Text = "SmartMed ERP";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 8;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(190, 45);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseTransparentBackground = true;
            // 
            // btnMedicines
            // 
            this.btnMedicines.Animated = true;
            this.btnMedicines.BackColor = System.Drawing.Color.Transparent;
            this.btnMedicines.BorderRadius = 8;
            this.btnMedicines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMedicines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMedicines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMedicines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnMedicines.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnMedicines.ForeColor = System.Drawing.Color.White;
            this.btnMedicines.Location = new System.Drawing.Point(20, 265);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(190, 45);
            this.btnMedicines.TabIndex = 5;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.UseTransparentBackground = true;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Animated = true;
            this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomers.BorderRadius = 8;
            this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Location = new System.Drawing.Point(20, 320);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(190, 45);
            this.btnCustomers.TabIndex = 6;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseTransparentBackground = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Animated = true;
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.BorderRadius = 8;
            this.btnOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(20, 375);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(190, 45);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseTransparentBackground = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnReports
            // 
            this.btnReports.Animated = true;
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.BorderRadius = 8;
            this.btnReports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReports.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(20, 430);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(190, 45);
            this.btnReports.TabIndex = 8;
            this.btnReports.Text = "Reports";
            this.btnReports.UseTransparentBackground = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 590);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(190, 45);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseTransparentBackground = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlAlerts);
            this.pnlMain.Controls.Add(this.pnlRevenueCard);
            this.pnlMain.Controls.Add(this.pnlOrdersCard);
            this.pnlMain.Controls.Add(this.pnlCustomersCard);
            this.pnlMain.Controls.Add(this.pnlMedicinesCard);
            this.pnlMain.Controls.Add(this.lblLoggedUsers);
            this.pnlMain.Controls.Add(this.lblDashboardTitle);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pnlMain.Location = new System.Drawing.Point(230, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(952, 653);
            this.pnlMain.TabIndex = 10;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pnlAlerts
            // 
            this.pnlAlerts.BorderRadius = 15;
            this.pnlAlerts.Controls.Add(this.lblAlerts);
            this.pnlAlerts.Controls.Add(this.lblAlertsTitle);
            this.pnlAlerts.FillColor = System.Drawing.Color.White;
            this.pnlAlerts.Location = new System.Drawing.Point(35, 270);
            this.pnlAlerts.Name = "pnlAlerts";
            this.pnlAlerts.Size = new System.Drawing.Size(900, 330);
            this.pnlAlerts.TabIndex = 6;
            // 
            // lblAlerts
            // 
            this.lblAlerts.AutoSize = true;
            this.lblAlerts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAlerts.ForeColor = System.Drawing.Color.Black;
            this.lblAlerts.Location = new System.Drawing.Point(20, 70);
            this.lblAlerts.Name = "lblAlerts";
            this.lblAlerts.Size = new System.Drawing.Size(111, 23);
            this.lblAlerts.TabIndex = 1;
            this.lblAlerts.Text = "No alerts yet.";
            // 
            // lblAlertsTitle
            // 
            this.lblAlertsTitle.AutoSize = true;
            this.lblAlertsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblAlertsTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAlertsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAlertsTitle.Name = "lblAlertsTitle";
            this.lblAlertsTitle.Size = new System.Drawing.Size(193, 37);
            this.lblAlertsTitle.TabIndex = 0;
            this.lblAlertsTitle.Text = "System Alerts";
            // 
            // pnlRevenueCard
            // 
            this.pnlRevenueCard.BorderRadius = 15;
            this.pnlRevenueCard.Controls.Add(this.lblRevenue);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenueCard.FillColor = System.Drawing.Color.White;
            this.pnlRevenueCard.Location = new System.Drawing.Point(725, 120);
            this.pnlRevenueCard.Name = "pnlRevenueCard";
            this.pnlRevenueCard.Size = new System.Drawing.Size(210, 120);
            this.pnlRevenueCard.TabIndex = 5;
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.Black;
            this.lblRevenue.Location = new System.Drawing.Point(17, 51);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(176, 57);
            this.lblRevenue.TabIndex = 1;
            this.lblRevenue.Text = "Rs. 0.00";
            this.lblRevenue.Click += new System.EventHandler(this.lblRevenue_Click);
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRevenueTitle.ForeColor = System.Drawing.Color.Black;
            this.lblRevenueTitle.Location = new System.Drawing.Point(22, 18);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(116, 23);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Total Revenue";
            // 
            // pnlOrdersCard
            // 
            this.pnlOrdersCard.BorderRadius = 15;
            this.pnlOrdersCard.Controls.Add(this.lblOrderCount);
            this.pnlOrdersCard.Controls.Add(this.lblOrdersTitle);
            this.pnlOrdersCard.FillColor = System.Drawing.Color.White;
            this.pnlOrdersCard.Location = new System.Drawing.Point(495, 120);
            this.pnlOrdersCard.Name = "pnlOrdersCard";
            this.pnlOrdersCard.Size = new System.Drawing.Size(210, 120);
            this.pnlOrdersCard.TabIndex = 4;
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblOrderCount.ForeColor = System.Drawing.Color.Black;
            this.lblOrderCount.Location = new System.Drawing.Point(33, 51);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(49, 57);
            this.lblOrderCount.TabIndex = 1;
            this.lblOrderCount.Text = "0";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.Black;
            this.lblOrdersTitle.Location = new System.Drawing.Point(22, 18);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(102, 23);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Total Orders";
            // 
            // pnlCustomersCard
            // 
            this.pnlCustomersCard.BorderRadius = 15;
            this.pnlCustomersCard.Controls.Add(this.lblCustomerCount);
            this.pnlCustomersCard.Controls.Add(this.lblCustomersTitle);
            this.pnlCustomersCard.FillColor = System.Drawing.Color.White;
            this.pnlCustomersCard.Location = new System.Drawing.Point(265, 120);
            this.pnlCustomersCard.Name = "pnlCustomersCard";
            this.pnlCustomersCard.Size = new System.Drawing.Size(210, 120);
            this.pnlCustomersCard.TabIndex = 3;
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerCount.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerCount.Location = new System.Drawing.Point(33, 51);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(49, 57);
            this.lblCustomerCount.TabIndex = 1;
            this.lblCustomerCount.Text = "0";
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.AutoSize = true;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.Black;
            this.lblCustomersTitle.Location = new System.Drawing.Point(22, 18);
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(132, 23);
            this.lblCustomersTitle.TabIndex = 0;
            this.lblCustomersTitle.Text = "Total Customers";
            // 
            // pnlMedicinesCard
            // 
            this.pnlMedicinesCard.BorderRadius = 15;
            this.pnlMedicinesCard.Controls.Add(this.iconPictureBox1);
            this.pnlMedicinesCard.Controls.Add(this.lblMedicineCount);
            this.pnlMedicinesCard.Controls.Add(this.lblMedicinesTitle);
            this.pnlMedicinesCard.FillColor = System.Drawing.Color.White;
            this.pnlMedicinesCard.Location = new System.Drawing.Point(35, 120);
            this.pnlMedicinesCard.Name = "pnlMedicinesCard";
            this.pnlMedicinesCard.Size = new System.Drawing.Size(210, 120);
            this.pnlMedicinesCard.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 28;
            this.iconPictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.InitialImage")));
            this.iconPictureBox1.Location = new System.Drawing.Point(155, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(33, 28);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblMedicineCount
            // 
            this.lblMedicineCount.AutoSize = true;
            this.lblMedicineCount.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblMedicineCount.ForeColor = System.Drawing.Color.Black;
            this.lblMedicineCount.Location = new System.Drawing.Point(33, 51);
            this.lblMedicineCount.Name = "lblMedicineCount";
            this.lblMedicineCount.Size = new System.Drawing.Size(49, 57);
            this.lblMedicineCount.TabIndex = 1;
            this.lblMedicineCount.Text = "0";
            // 
            // lblMedicinesTitle
            // 
            this.lblMedicinesTitle.AutoSize = true;
            this.lblMedicinesTitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMedicinesTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMedicinesTitle.Location = new System.Drawing.Point(22, 18);
            this.lblMedicinesTitle.Name = "lblMedicinesTitle";
            this.lblMedicinesTitle.Size = new System.Drawing.Size(127, 23);
            this.lblMedicinesTitle.TabIndex = 0;
            this.lblMedicinesTitle.Text = "Total Medicines";
            // 
            // lblLoggedUsers
            // 
            this.lblLoggedUsers.AutoSize = true;
            this.lblLoggedUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLoggedUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblLoggedUsers.Location = new System.Drawing.Point(40, 86);
            this.lblLoggedUsers.Name = "lblLoggedUsers";
            this.lblLoggedUsers.Size = new System.Drawing.Size(137, 23);
            this.lblLoggedUsers.TabIndex = 1;
            this.lblLoggedUsers.Text = "Welcome, admin";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(35, 25);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(211, 50);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnMedicines);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.lblLoggedUser);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartMed ERP - Admin Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlAlerts.ResumeLayout(false);
            this.pnlAlerts.PerformLayout();
            this.pnlRevenueCard.ResumeLayout(false);
            this.pnlRevenueCard.PerformLayout();
            this.pnlOrdersCard.ResumeLayout(false);
            this.pnlOrdersCard.PerformLayout();
            this.pnlCustomersCard.ResumeLayout(false);
            this.pnlCustomersCard.PerformLayout();
            this.pnlMedicinesCard.ResumeLayout(false);
            this.pnlMedicinesCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedUser;
        private Guna.UI2.WinForms.Guna2Panel pnlSidebar;
        private System.Windows.Forms.Label lblAppName;
        private Guna.UI2.WinForms.Guna2Button btnSuppliers;
        private Guna.UI2.WinForms.Guna2Button btnCategories;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnMedicines;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnOrders;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Label lblLoggedUsers;
        private Guna.UI2.WinForms.Guna2Panel pnlMedicinesCard;
        private System.Windows.Forms.Label lblMedicinesTitle;
        private System.Windows.Forms.Label lblMedicineCount;
        private Guna.UI2.WinForms.Guna2Panel pnlRevenueCard;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlOrdersCard;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label lblOrdersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlCustomersCard;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblCustomersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlAlerts;
        private System.Windows.Forms.Label lblAlerts;
        private System.Windows.Forms.Label lblAlertsTitle;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}