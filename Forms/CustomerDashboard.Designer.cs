namespace SmartMed.Forms
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearchMedicines = new Guna.UI2.WinForms.Guna2Button();
            this.btnMyOrders = new Guna.UI2.WinForms.Guna2Button();
            this.btnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMedicines = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMedicinesHint = new System.Windows.Forms.Label();
            this.lblMedicineCount = new System.Windows.Forms.Label();
            this.lblMedicinesTitle = new System.Windows.Forms.Label();
            this.pnlOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOrdersHint = new System.Windows.Forms.Label();
            this.lblOrderCount = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlPending = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPendingHint = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubText = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlActions = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMyCart = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFeature = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFeatureBadgeSub = new System.Windows.Forms.Label();
            this.lblFeatureBadge = new System.Windows.Forms.Label();
            this.btnStartShopping = new Guna.UI2.WinForms.Guna2Button();
            this.lblFeatureText = new System.Windows.Forms.Label();
            this.lblFeatureTitle = new System.Windows.Forms.Label();
            this.lblMembershipLevel = new System.Windows.Forms.Label();
            this.lblLoyaltyPoints = new System.Windows.Forms.Label();
            this.pnlMedicines.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlPending.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(336, 26);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(184, 50);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnSearchMedicines
            // 
            this.btnSearchMedicines.BorderRadius = 12;
            this.btnSearchMedicines.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchMedicines.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchMedicines.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchMedicines.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchMedicines.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnSearchMedicines.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMedicines.ForeColor = System.Drawing.Color.White;
            this.btnSearchMedicines.Location = new System.Drawing.Point(36, 25);
            this.btnSearchMedicines.Name = "btnSearchMedicines";
            this.btnSearchMedicines.Size = new System.Drawing.Size(199, 45);
            this.btnSearchMedicines.TabIndex = 2;
            this.btnSearchMedicines.Text = "Search Medicines";
            this.btnSearchMedicines.Click += new System.EventHandler(this.btnSearchMedicines_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.BorderRadius = 10;
            this.btnMyOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyOrders.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnMyOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.Location = new System.Drawing.Point(293, 25);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(175, 45);
            this.btnMyOrders.TabIndex = 3;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BorderRadius = 12;
            this.btnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(774, 25);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(175, 45);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 12;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnLogout.Location = new System.Drawing.Point(257, 107);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlMedicines
            // 
            this.pnlMedicines.BorderRadius = 20;
            this.pnlMedicines.Controls.Add(this.lblMedicinesHint);
            this.pnlMedicines.Controls.Add(this.lblMedicineCount);
            this.pnlMedicines.Controls.Add(this.lblMedicinesTitle);
            this.pnlMedicines.FillColor = System.Drawing.Color.White;
            this.pnlMedicines.Location = new System.Drawing.Point(20, 290);
            this.pnlMedicines.Name = "pnlMedicines";
            this.pnlMedicines.Size = new System.Drawing.Size(320, 145);
            this.pnlMedicines.TabIndex = 6;
            // 
            // lblMedicinesHint
            // 
            this.lblMedicinesHint.AutoSize = true;
            this.lblMedicinesHint.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicinesHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicinesHint.ForeColor = System.Drawing.Color.Gray;
            this.lblMedicinesHint.Location = new System.Drawing.Point(26, 113);
            this.lblMedicinesHint.Name = "lblMedicinesHint";
            this.lblMedicinesHint.Size = new System.Drawing.Size(231, 20);
            this.lblMedicinesHint.TabIndex = 2;
            this.lblMedicinesHint.Text = "In-stock medicines ready to order";
            // 
            // lblMedicineCount
            // 
            this.lblMedicineCount.AutoSize = true;
            this.lblMedicineCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicineCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblMedicineCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblMedicineCount.Location = new System.Drawing.Point(25, 55);
            this.lblMedicineCount.Name = "lblMedicineCount";
            this.lblMedicineCount.Size = new System.Drawing.Size(54, 62);
            this.lblMedicineCount.TabIndex = 1;
            this.lblMedicineCount.Text = "0";
            // 
            // lblMedicinesTitle
            // 
            this.lblMedicinesTitle.AutoSize = true;
            this.lblMedicinesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicinesTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblMedicinesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblMedicinesTitle.Location = new System.Drawing.Point(25, 22);
            this.lblMedicinesTitle.Name = "lblMedicinesTitle";
            this.lblMedicinesTitle.Size = new System.Drawing.Size(180, 25);
            this.lblMedicinesTitle.TabIndex = 0;
            this.lblMedicinesTitle.Text = "Medicines Available";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BorderRadius = 20;
            this.pnlOrders.Controls.Add(this.lblOrdersHint);
            this.pnlOrders.Controls.Add(this.lblOrderCount);
            this.pnlOrders.Controls.Add(this.lblOrdersTitle);
            this.pnlOrders.FillColor = System.Drawing.Color.White;
            this.pnlOrders.Location = new System.Drawing.Point(380, 290);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(320, 145);
            this.pnlOrders.TabIndex = 7;
            // 
            // lblOrdersHint
            // 
            this.lblOrdersHint.AutoSize = true;
            this.lblOrdersHint.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersHint.ForeColor = System.Drawing.Color.Gray;
            this.lblOrdersHint.Location = new System.Drawing.Point(26, 113);
            this.lblOrdersHint.Name = "lblOrdersHint";
            this.lblOrdersHint.Size = new System.Drawing.Size(200, 20);
            this.lblOrdersHint.TabIndex = 3;
            this.lblOrdersHint.Text = "Total orders you have placed";
            // 
            // lblOrderCount
            // 
            this.lblOrderCount.AutoSize = true;
            this.lblOrderCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblOrderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblOrderCount.Location = new System.Drawing.Point(25, 55);
            this.lblOrderCount.Name = "lblOrderCount";
            this.lblOrderCount.Size = new System.Drawing.Size(54, 62);
            this.lblOrderCount.TabIndex = 1;
            this.lblOrderCount.Text = "0";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblOrdersTitle.Location = new System.Drawing.Point(25, 22);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(100, 25);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "My Orders";
            // 
            // pnlPending
            // 
            this.pnlPending.BorderRadius = 20;
            this.pnlPending.Controls.Add(this.lblPendingHint);
            this.pnlPending.Controls.Add(this.lblPendingCount);
            this.pnlPending.Controls.Add(this.lblPendingTitle);
            this.pnlPending.FillColor = System.Drawing.Color.White;
            this.pnlPending.Location = new System.Drawing.Point(740, 290);
            this.pnlPending.Name = "pnlPending";
            this.pnlPending.Size = new System.Drawing.Size(320, 145);
            this.pnlPending.TabIndex = 8;
            // 
            // lblPendingHint
            // 
            this.lblPendingHint.AutoSize = true;
            this.lblPendingHint.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingHint.ForeColor = System.Drawing.Color.Gray;
            this.lblPendingHint.Location = new System.Drawing.Point(26, 113);
            this.lblPendingHint.Name = "lblPendingHint";
            this.lblPendingHint.Size = new System.Drawing.Size(221, 20);
            this.lblPendingHint.TabIndex = 4;
            this.lblPendingHint.Text = "Orders waiting to be completed";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingCount.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblPendingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPendingCount.Location = new System.Drawing.Point(25, 55);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(54, 62);
            this.lblPendingCount.TabIndex = 1;
            this.lblPendingCount.Text = "0";
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblPendingTitle.Location = new System.Drawing.Point(25, 22);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(143, 25);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "Pending Orders";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 20;
            this.pnlHeader.Controls.Add(this.lblMembershipLevel);
            this.pnlHeader.Controls.Add(this.lblLoyaltyPoints);
            this.pnlHeader.Controls.Add(this.lblSubText);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 130);
            this.pnlHeader.TabIndex = 9;
            // 
            // lblSubText
            // 
            this.lblSubText.AutoSize = true;
            this.lblSubText.BackColor = System.Drawing.Color.Transparent;
            this.lblSubText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubText.Location = new System.Drawing.Point(341, 88);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.Size = new System.Drawing.Size(427, 20);
            this.lblSubText.TabIndex = 10;
            this.lblSubText.Text = "Search medicines, place orders, and track your purchases easily.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlActions
            // 
            this.pnlActions.BorderRadius = 18;
            this.pnlActions.Controls.Add(this.btnSearchMedicines);
            this.pnlActions.Controls.Add(this.btnMyCart);
            this.pnlActions.Controls.Add(this.btnMyOrders);
            this.pnlActions.Controls.Add(this.btnProfile);
            this.pnlActions.FillColor = System.Drawing.Color.White;
            this.pnlActions.Location = new System.Drawing.Point(20, 170);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(1040, 95);
            this.pnlActions.TabIndex = 10;
            // 
            // btnMyCart
            // 
            this.btnMyCart.BorderRadius = 10;
            this.btnMyCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnMyCart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCart.ForeColor = System.Drawing.Color.White;
            this.btnMyCart.Location = new System.Drawing.Point(526, 25);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(175, 45);
            this.btnMyCart.TabIndex = 3;
            this.btnMyCart.Text = "My Cart";
            this.btnMyCart.Click += new System.EventHandler(this.btnMyCart_Click);
            // 
            // pnlFeature
            // 
            this.pnlFeature.BorderRadius = 22;
            this.pnlFeature.Controls.Add(this.lblFeatureBadgeSub);
            this.pnlFeature.Controls.Add(this.lblFeatureBadge);
            this.pnlFeature.Controls.Add(this.btnStartShopping);
            this.pnlFeature.Controls.Add(this.btnLogout);
            this.pnlFeature.Controls.Add(this.lblFeatureText);
            this.pnlFeature.Controls.Add(this.lblFeatureTitle);
            this.pnlFeature.FillColor = System.Drawing.Color.White;
            this.pnlFeature.Location = new System.Drawing.Point(20, 465);
            this.pnlFeature.Name = "pnlFeature";
            this.pnlFeature.Size = new System.Drawing.Size(1040, 165);
            this.pnlFeature.TabIndex = 11;
            this.pnlFeature.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFeature_Paint);
            // 
            // lblFeatureBadgeSub
            // 
            this.lblFeatureBadgeSub.AutoSize = true;
            this.lblFeatureBadgeSub.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatureBadgeSub.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureBadgeSub.ForeColor = System.Drawing.Color.Gray;
            this.lblFeatureBadgeSub.Location = new System.Drawing.Point(582, 145);
            this.lblFeatureBadgeSub.Name = "lblFeatureBadgeSub";
            this.lblFeatureBadgeSub.Size = new System.Drawing.Size(417, 23);
            this.lblFeatureBadgeSub.TabIndex = 7;
            this.lblFeatureBadgeSub.Text = "Contact us at +94 7586293 or smartmed@gmail.com.";
            this.lblFeatureBadgeSub.Click += new System.EventHandler(this.lblFeatureBadgeSub_Click);
            // 
            // lblFeatureBadge
            // 
            this.lblFeatureBadge.AutoSize = true;
            this.lblFeatureBadge.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatureBadge.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureBadge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblFeatureBadge.Location = new System.Drawing.Point(689, 107);
            this.lblFeatureBadge.Name = "lblFeatureBadge";
            this.lblFeatureBadge.Size = new System.Drawing.Size(310, 38);
            this.lblFeatureBadge.TabIndex = 6;
            this.lblFeatureBadge.Text = "24/7 Digital Pharmacy";
            // 
            // btnStartShopping
            // 
            this.btnStartShopping.BorderRadius = 12;
            this.btnStartShopping.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStartShopping.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStartShopping.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStartShopping.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStartShopping.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnStartShopping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStartShopping.ForeColor = System.Drawing.Color.White;
            this.btnStartShopping.Location = new System.Drawing.Point(43, 107);
            this.btnStartShopping.Name = "btnStartShopping";
            this.btnStartShopping.Size = new System.Drawing.Size(180, 42);
            this.btnStartShopping.TabIndex = 5;
            this.btnStartShopping.Text = "Start Shopping";
            this.btnStartShopping.Click += new System.EventHandler(this.btnStartShopping_Click);
            // 
            // lblFeatureText
            // 
            this.lblFeatureText.AutoSize = true;
            this.lblFeatureText.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatureText.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeatureText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblFeatureText.Location = new System.Drawing.Point(38, 68);
            this.lblFeatureText.Name = "lblFeatureText";
            this.lblFeatureText.Size = new System.Drawing.Size(768, 25);
            this.lblFeatureText.TabIndex = 1;
            this.lblFeatureText.Text = "Search available medicines, add items to your cart, and place orders quickly thro" +
    "ugh SmartMed.";
            // 
            // lblFeatureTitle
            // 
            this.lblFeatureTitle.AutoSize = true;
            this.lblFeatureTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFeatureTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFeatureTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblFeatureTitle.Location = new System.Drawing.Point(35, 25);
            this.lblFeatureTitle.Name = "lblFeatureTitle";
            this.lblFeatureTitle.Size = new System.Drawing.Size(447, 46);
            this.lblFeatureTitle.TabIndex = 0;
            this.lblFeatureTitle.Text = "Start Your Pharmacy Order";
            // 
            // lblMembershipLevel
            // 
            this.lblMembershipLevel.AutoSize = true;
            this.lblMembershipLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblMembershipLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMembershipLevel.ForeColor = System.Drawing.Color.Green;
            this.lblMembershipLevel.Location = new System.Drawing.Point(831, 58);
            this.lblMembershipLevel.Name = "lblMembershipLevel";
            this.lblMembershipLevel.Size = new System.Drawing.Size(194, 20);
            this.lblMembershipLevel.TabIndex = 12;
            this.lblMembershipLevel.Text = "Membership Level: Bronze";
            // 
            // lblLoyaltyPoints
            // 
            this.lblLoyaltyPoints.AutoSize = true;
            this.lblLoyaltyPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblLoyaltyPoints.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLoyaltyPoints.ForeColor = System.Drawing.Color.Green;
            this.lblLoyaltyPoints.Location = new System.Drawing.Point(831, 31);
            this.lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            this.lblLoyaltyPoints.Size = new System.Drawing.Size(125, 20);
            this.lblLoyaltyPoints.TabIndex = 11;
            this.lblLoyaltyPoints.Text = "Loyalty Points: 0";
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.pnlFeature);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlPending);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlMedicines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Dashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.pnlMedicines.ResumeLayout(false);
            this.pnlMedicines.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlPending.ResumeLayout(false);
            this.pnlPending.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlFeature.ResumeLayout(false);
            this.pnlFeature.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnSearchMedicines;
        private Guna.UI2.WinForms.Guna2Button btnMyOrders;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnlMedicines;
        private System.Windows.Forms.Label lblMedicineCount;
        private System.Windows.Forms.Label lblMedicinesTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlOrders;
        private System.Windows.Forms.Label lblOrderCount;
        private System.Windows.Forms.Label lblOrdersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlPending;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblPendingTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubText;
        private Guna.UI2.WinForms.Guna2Panel pnlActions;
        private System.Windows.Forms.Label lblMedicinesHint;
        private System.Windows.Forms.Label lblOrdersHint;
        private System.Windows.Forms.Label lblPendingHint;
        private Guna.UI2.WinForms.Guna2Panel pnlFeature;
        private Guna.UI2.WinForms.Guna2Button btnStartShopping;
        private System.Windows.Forms.Label lblFeatureText;
        private System.Windows.Forms.Label lblFeatureTitle;
        private System.Windows.Forms.Label lblFeatureBadgeSub;
        private System.Windows.Forms.Label lblFeatureBadge;
        private Guna.UI2.WinForms.Guna2Button btnMyCart;
        private System.Windows.Forms.Label lblMembershipLevel;
        private System.Windows.Forms.Label lblLoyaltyPoints;
    }
}