namespace SmartMed.Forms
{
    partial class MyOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrdersForm));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTotalOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalOrdersTitle = new System.Windows.Forms.Label();
            this.pnlPendingOrders = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.lblPendingOrdersTitle = new System.Windows.Forms.Label();
            this.pnlTotalSpent = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblTotalSpentTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlOrderDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.btnViewInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.lblAdminNote = new System.Windows.Forms.Label();
            this.lblAdminNoteTitle = new System.Windows.Forms.Label();
            this.lblPrescriptionStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.lblSelectedOrder = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlTotalOrders.SuspendLayout();
            this.pnlPendingOrders.SuspendLayout();
            this.pnlTotalSpent.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 18;
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1040, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(900, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 58);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(423, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "View your order history and track current order status.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Orders";
            // 
            // pnlTotalOrders
            // 
            this.pnlTotalOrders.BorderRadius = 18;
            this.pnlTotalOrders.Controls.Add(this.lblTotalOrders);
            this.pnlTotalOrders.Controls.Add(this.lblTotalOrdersTitle);
            this.pnlTotalOrders.FillColor = System.Drawing.Color.White;
            this.pnlTotalOrders.Location = new System.Drawing.Point(20, 130);
            this.pnlTotalOrders.Name = "pnlTotalOrders";
            this.pnlTotalOrders.Size = new System.Drawing.Size(320, 120);
            this.pnlTotalOrders.TabIndex = 1;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblTotalOrders.Location = new System.Drawing.Point(25, 55);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(50, 59);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "0";
            // 
            // lblTotalOrdersTitle
            // 
            this.lblTotalOrdersTitle.AutoSize = true;
            this.lblTotalOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTotalOrdersTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            this.lblTotalOrdersTitle.Size = new System.Drawing.Size(108, 25);
            this.lblTotalOrdersTitle.TabIndex = 0;
            this.lblTotalOrdersTitle.Text = "Total Orders";
            // 
            // pnlPendingOrders
            // 
            this.pnlPendingOrders.BorderRadius = 18;
            this.pnlPendingOrders.Controls.Add(this.lblPendingOrders);
            this.pnlPendingOrders.Controls.Add(this.lblPendingOrdersTitle);
            this.pnlPendingOrders.FillColor = System.Drawing.Color.White;
            this.pnlPendingOrders.Location = new System.Drawing.Point(390, 130);
            this.pnlPendingOrders.Name = "pnlPendingOrders";
            this.pnlPendingOrders.Size = new System.Drawing.Size(320, 120);
            this.pnlPendingOrders.TabIndex = 2;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.AutoSize = true;
            this.lblPendingOrders.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblPendingOrders.Location = new System.Drawing.Point(25, 55);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(50, 59);
            this.lblPendingOrders.TabIndex = 1;
            this.lblPendingOrders.Text = "0";
            // 
            // lblPendingOrdersTitle
            // 
            this.lblPendingOrdersTitle.AutoSize = true;
            this.lblPendingOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrdersTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblPendingOrdersTitle.Location = new System.Drawing.Point(25, 20);
            this.lblPendingOrdersTitle.Name = "lblPendingOrdersTitle";
            this.lblPendingOrdersTitle.Size = new System.Drawing.Size(135, 25);
            this.lblPendingOrdersTitle.TabIndex = 0;
            this.lblPendingOrdersTitle.Text = "Pending Orders";
            // 
            // pnlTotalSpent
            // 
            this.pnlTotalSpent.BorderRadius = 18;
            this.pnlTotalSpent.Controls.Add(this.lblTotalSpent);
            this.pnlTotalSpent.Controls.Add(this.lblTotalSpentTitle);
            this.pnlTotalSpent.FillColor = System.Drawing.Color.White;
            this.pnlTotalSpent.Location = new System.Drawing.Point(740, 130);
            this.pnlTotalSpent.Name = "pnlTotalSpent";
            this.pnlTotalSpent.Size = new System.Drawing.Size(320, 120);
            this.pnlTotalSpent.TabIndex = 3;
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblTotalSpent.Location = new System.Drawing.Point(25, 55);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(183, 59);
            this.lblTotalSpent.TabIndex = 1;
            this.lblTotalSpent.Text = "Rs. 0.00";
            // 
            // lblTotalSpentTitle
            // 
            this.lblTotalSpentTitle.AutoSize = true;
            this.lblTotalSpentTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblTotalSpentTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTotalSpentTitle.Name = "lblTotalSpentTitle";
            this.lblTotalSpentTitle.Size = new System.Drawing.Size(100, 25);
            this.lblTotalSpentTitle.TabIndex = 0;
            this.lblTotalSpentTitle.Text = "Total Spent";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderRadius = 18;
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.cmbStatusFilter);
            this.pnlFilter.Controls.Add(this.lblStatusFilter);
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(20, 275);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1040, 75);
            this.pnlFilter.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(370, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "",
            "Pending",
            "",
            "Processing",
            "",
            "Delivered",
            "",
            "Cancelled"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(140, 20);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(200, 24);
            this.cmbStatusFilter.TabIndex = 1;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFilter.Location = new System.Drawing.Point(30, 25);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(98, 23);
            this.lblStatusFilter.TabIndex = 0;
            this.lblStatusFilter.Text = "Filter Status";
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 375);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(650, 260);
            this.dgvOrders.TabIndex = 5;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // pnlOrderDetails
            // 
            this.pnlOrderDetails.BorderRadius = 18;
            this.pnlOrderDetails.Controls.Add(this.btnViewInvoice);
            this.pnlOrderDetails.Controls.Add(this.lblAdminNote);
            this.pnlOrderDetails.Controls.Add(this.lblAdminNoteTitle);
            this.pnlOrderDetails.Controls.Add(this.lblPrescriptionStatus);
            this.pnlOrderDetails.Controls.Add(this.lblPaymentStatus);
            this.pnlOrderDetails.Controls.Add(this.lblPaymentMethod);
            this.pnlOrderDetails.Controls.Add(this.lblDeliveryMethod);
            this.pnlOrderDetails.Controls.Add(this.lblSelectedOrder);
            this.pnlOrderDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlOrderDetails.FillColor = System.Drawing.Color.White;
            this.pnlOrderDetails.Location = new System.Drawing.Point(700, 375);
            this.pnlOrderDetails.Name = "pnlOrderDetails";
            this.pnlOrderDetails.Size = new System.Drawing.Size(360, 260);
            this.pnlOrderDetails.TabIndex = 6;
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BorderRadius = 10;
            this.btnViewInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnViewInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnViewInvoice.Location = new System.Drawing.Point(220, 50);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(120, 35);
            this.btnViewInvoice.TabIndex = 10;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // lblAdminNote
            // 
            this.lblAdminNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNote.ForeColor = System.Drawing.Color.Gray;
            this.lblAdminNote.Location = new System.Drawing.Point(20, 210);
            this.lblAdminNote.Name = "lblAdminNote";
            this.lblAdminNote.Size = new System.Drawing.Size(320, 40);
            this.lblAdminNote.TabIndex = 7;
            this.lblAdminNote.Text = "-";
            // 
            // lblAdminNoteTitle
            // 
            this.lblAdminNoteTitle.AutoSize = true;
            this.lblAdminNoteTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNoteTitle.Location = new System.Drawing.Point(20, 185);
            this.lblAdminNoteTitle.Name = "lblAdminNoteTitle";
            this.lblAdminNoteTitle.Size = new System.Drawing.Size(99, 20);
            this.lblAdminNoteTitle.TabIndex = 6;
            this.lblAdminNoteTitle.Text = "Admin Note:";
            // 
            // lblPrescriptionStatus
            // 
            this.lblPrescriptionStatus.AutoSize = true;
            this.lblPrescriptionStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionStatus.Location = new System.Drawing.Point(20, 155);
            this.lblPrescriptionStatus.Name = "lblPrescriptionStatus";
            this.lblPrescriptionStatus.Size = new System.Drawing.Size(155, 20);
            this.lblPrescriptionStatus.TabIndex = 5;
            this.lblPrescriptionStatus.Text = "Prescription Status: -";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(20, 130);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(122, 20);
            this.lblPaymentStatus.TabIndex = 4;
            this.lblPaymentStatus.Text = "Payment Status: -";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(20, 105);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(134, 20);
            this.lblPaymentMethod.TabIndex = 3;
            this.lblPaymentMethod.Text = "Payment Method: -";
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMethod.Location = new System.Drawing.Point(20, 80);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.Size = new System.Drawing.Size(132, 20);
            this.lblDeliveryMethod.TabIndex = 2;
            this.lblDeliveryMethod.Text = "Delivery Method: -";
            // 
            // lblSelectedOrder
            // 
            this.lblSelectedOrder.AutoSize = true;
            this.lblSelectedOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrder.Location = new System.Drawing.Point(20, 50);
            this.lblSelectedOrder.Name = "lblSelectedOrder";
            this.lblSelectedOrder.Size = new System.Drawing.Size(183, 23);
            this.lblSelectedOrder.TabIndex = 1;
            this.lblSelectedOrder.Text = "Selected Order: None";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailsTitle.Location = new System.Drawing.Point(20, 13);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(226, 38);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Tracking Details";
            // 
            // MyOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.pnlOrderDetails);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.pnlTotalSpent);
            this.Controls.Add(this.pnlPendingOrders);
            this.Controls.Add(this.pnlTotalOrders);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Orders";
            this.Load += new System.EventHandler(this.MyOrdersForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTotalOrders.ResumeLayout(false);
            this.pnlTotalOrders.PerformLayout();
            this.pnlPendingOrders.ResumeLayout(false);
            this.pnlPendingOrders.PerformLayout();
            this.pnlTotalSpent.ResumeLayout(false);
            this.pnlTotalSpent.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlOrderDetails.ResumeLayout(false);
            this.pnlOrderDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalOrders;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalOrdersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlPendingOrders;
        private System.Windows.Forms.Label lblPendingOrders;
        private System.Windows.Forms.Label lblPendingOrdersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlTotalSpent;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblTotalSpentTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2Panel pnlOrderDetails;
        private System.Windows.Forms.Label lblAdminNoteTitle;
        private System.Windows.Forms.Label lblPrescriptionStatus;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private System.Windows.Forms.Label lblSelectedOrder;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblAdminNote;
        private Guna.UI2.WinForms.Guna2Button btnViewInvoice;
    }
}