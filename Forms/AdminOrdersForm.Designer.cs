namespace SmartMed.Forms
{
    partial class AdminOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOrdersForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblPaymentStatusTitle = new System.Windows.Forms.Label();
            this.btnViewInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.txtAdminNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAdminNote = new System.Windows.Forms.Label();
            this.lblPrescriptionStatus = new System.Windows.Forms.Label();
            this.lblPrescriptionRequired = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnRejectPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnApprovePrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewPrescription = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdatePaymentStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateStatus = new Guna.UI2.WinForms.Guna2Button();
            this.cmbUpdateStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSelectedOrder = new System.Windows.Forms.Label();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.Controls.Add(this.lblSubTitle);
            this.guna2Panel1.Controls.Add(this.lblTitle);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1193, 90);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 59);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(470, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "View customer orders, update status, and check order items.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(363, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Order Management";
            // 
            // pnlFilter
            // 
            this.pnlFilter.BorderRadius = 18;
            this.pnlFilter.Controls.Add(this.btnRefresh);
            this.pnlFilter.Controls.Add(this.cmbStatusFilter);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.FillColor = System.Drawing.Color.White;
            this.pnlFilter.Location = new System.Drawing.Point(20, 130);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1193, 80);
            this.pnlFilter.TabIndex = 1;
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
            this.btnRefresh.Location = new System.Drawing.Point(750, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 40);
            this.btnRefresh.TabIndex = 2;
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
            this.cmbStatusFilter.Location = new System.Drawing.Point(557, 36);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(180, 24);
            this.cmbStatusFilter.TabIndex = 1;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(23, 22);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by customer name or order ID";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(528, 53);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Location = new System.Drawing.Point(20, 235);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.RowTemplate.Height = 24;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(720, 603);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderRadius = 18;
            this.pnlDetails.Controls.Add(this.cmbPaymentStatus);
            this.pnlDetails.Controls.Add(this.lblPaymentStatusTitle);
            this.pnlDetails.Controls.Add(this.btnViewInvoice);
            this.pnlDetails.Controls.Add(this.txtAdminNote);
            this.pnlDetails.Controls.Add(this.lblAdminNote);
            this.pnlDetails.Controls.Add(this.lblPrescriptionStatus);
            this.pnlDetails.Controls.Add(this.lblPrescriptionRequired);
            this.pnlDetails.Controls.Add(this.dgvOrderItems);
            this.pnlDetails.Controls.Add(this.btnRejectPrescription);
            this.pnlDetails.Controls.Add(this.btnApprovePrescription);
            this.pnlDetails.Controls.Add(this.btnViewPrescription);
            this.pnlDetails.Controls.Add(this.btnUpdatePaymentStatus);
            this.pnlDetails.Controls.Add(this.btnUpdateStatus);
            this.pnlDetails.Controls.Add(this.cmbUpdateStatus);
            this.pnlDetails.Controls.Add(this.lblStatus);
            this.pnlDetails.Controls.Add(this.lblSelectedOrder);
            this.pnlDetails.Controls.Add(this.lblDetailsTitle);
            this.pnlDetails.FillColor = System.Drawing.Color.White;
            this.pnlDetails.Location = new System.Drawing.Point(770, 235);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(443, 603);
            this.pnlDetails.TabIndex = 3;
            this.pnlDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetails_Paint);
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Location = new System.Drawing.Point(39, 131);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(180, 24);
            this.cmbPaymentStatus.TabIndex = 11;
            // 
            // lblPaymentStatusTitle
            // 
            this.lblPaymentStatusTitle.AutoSize = true;
            this.lblPaymentStatusTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatusTitle.Location = new System.Drawing.Point(36, 95);
            this.lblPaymentStatusTitle.Name = "lblPaymentStatusTitle";
            this.lblPaymentStatusTitle.Size = new System.Drawing.Size(135, 23);
            this.lblPaymentStatusTitle.TabIndex = 10;
            this.lblPaymentStatusTitle.Text = "Payment Status";
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
            this.btnViewInvoice.Location = new System.Drawing.Point(38, 227);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(134, 34);
            this.btnViewInvoice.TabIndex = 9;
            this.btnViewInvoice.Text = "View Invoice";
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // txtAdminNote
            // 
            this.txtAdminNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminNote.DefaultText = "";
            this.txtAdminNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAdminNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAdminNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAdminNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAdminNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAdminNote.Location = new System.Drawing.Point(30, 416);
            this.txtAdminNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAdminNote.Multiline = true;
            this.txtAdminNote.Name = "txtAdminNote";
            this.txtAdminNote.PlaceholderText = "";
            this.txtAdminNote.SelectedText = "";
            this.txtAdminNote.Size = new System.Drawing.Size(386, 55);
            this.txtAdminNote.TabIndex = 8;
            // 
            // lblAdminNote
            // 
            this.lblAdminNote.AutoSize = true;
            this.lblAdminNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminNote.Location = new System.Drawing.Point(35, 388);
            this.lblAdminNote.Name = "lblAdminNote";
            this.lblAdminNote.Size = new System.Drawing.Size(103, 23);
            this.lblAdminNote.TabIndex = 7;
            this.lblAdminNote.Text = "Admin Note";
            // 
            // lblPrescriptionStatus
            // 
            this.lblPrescriptionStatus.AutoSize = true;
            this.lblPrescriptionStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionStatus.Location = new System.Drawing.Point(30, 302);
            this.lblPrescriptionStatus.Name = "lblPrescriptionStatus";
            this.lblPrescriptionStatus.Size = new System.Drawing.Size(279, 23);
            this.lblPrescriptionStatus.TabIndex = 6;
            this.lblPrescriptionStatus.Text = "Prescription Status: Not Required";
            // 
            // lblPrescriptionRequired
            // 
            this.lblPrescriptionRequired.AutoSize = true;
            this.lblPrescriptionRequired.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionRequired.Location = new System.Drawing.Point(30, 272);
            this.lblPrescriptionRequired.Name = "lblPrescriptionRequired";
            this.lblPrescriptionRequired.Size = new System.Drawing.Size(217, 23);
            this.lblPrescriptionRequired.TabIndex = 6;
            this.lblPrescriptionRequired.Text = "Prescription Required: No";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Location = new System.Drawing.Point(30, 489);
            this.dgvOrderItems.MultiSelect = false;
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersVisible = false;
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 24;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(386, 97);
            this.dgvOrderItems.TabIndex = 5;
            // 
            // btnRejectPrescription
            // 
            this.btnRejectPrescription.BorderRadius = 10;
            this.btnRejectPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRejectPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRejectPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRejectPrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRejectPrescription.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnRejectPrescription.ForeColor = System.Drawing.Color.White;
            this.btnRejectPrescription.Location = new System.Drawing.Point(336, 337);
            this.btnRejectPrescription.Name = "btnRejectPrescription";
            this.btnRejectPrescription.Size = new System.Drawing.Size(80, 38);
            this.btnRejectPrescription.TabIndex = 4;
            this.btnRejectPrescription.Text = "Reject";
            this.btnRejectPrescription.Click += new System.EventHandler(this.btnRejectPrescription_Click);
            // 
            // btnApprovePrescription
            // 
            this.btnApprovePrescription.BorderRadius = 10;
            this.btnApprovePrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApprovePrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApprovePrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApprovePrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApprovePrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnApprovePrescription.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.btnApprovePrescription.ForeColor = System.Drawing.Color.White;
            this.btnApprovePrescription.Location = new System.Drawing.Point(240, 337);
            this.btnApprovePrescription.Name = "btnApprovePrescription";
            this.btnApprovePrescription.Size = new System.Drawing.Size(80, 38);
            this.btnApprovePrescription.TabIndex = 4;
            this.btnApprovePrescription.Text = "Approve";
            this.btnApprovePrescription.Click += new System.EventHandler(this.btnApprovePrescription_Click);
            // 
            // btnViewPrescription
            // 
            this.btnViewPrescription.BorderRadius = 10;
            this.btnViewPrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewPrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewPrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewPrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnViewPrescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewPrescription.ForeColor = System.Drawing.Color.White;
            this.btnViewPrescription.Location = new System.Drawing.Point(30, 337);
            this.btnViewPrescription.Name = "btnViewPrescription";
            this.btnViewPrescription.Size = new System.Drawing.Size(189, 38);
            this.btnViewPrescription.TabIndex = 4;
            this.btnViewPrescription.Text = "View Prescription";
            this.btnViewPrescription.Click += new System.EventHandler(this.btnViewPrescription_Click);
            // 
            // btnUpdatePaymentStatus
            // 
            this.btnUpdatePaymentStatus.BorderRadius = 10;
            this.btnUpdatePaymentStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePaymentStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdatePaymentStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdatePaymentStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdatePaymentStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdatePaymentStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePaymentStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePaymentStatus.Location = new System.Drawing.Point(225, 123);
            this.btnUpdatePaymentStatus.Name = "btnUpdatePaymentStatus";
            this.btnUpdatePaymentStatus.Size = new System.Drawing.Size(150, 38);
            this.btnUpdatePaymentStatus.TabIndex = 4;
            this.btnUpdatePaymentStatus.Text = "Update Payment";
            this.btnUpdatePaymentStatus.Click += new System.EventHandler(this.btnUpdatePaymentStatus_Click);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BorderRadius = 10;
            this.btnUpdateStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnUpdateStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.Location = new System.Drawing.Point(307, 179);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // cmbUpdateStatus
            // 
            this.cmbUpdateStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUpdateStatus.FormattingEnabled = true;
            this.cmbUpdateStatus.Items.AddRange(new object[] {
            "Pending",
            "",
            "Processing",
            "",
            "Delivered",
            "",
            "Cancelled"});
            this.cmbUpdateStatus.Location = new System.Drawing.Point(38, 188);
            this.cmbUpdateStatus.Name = "cmbUpdateStatus";
            this.cmbUpdateStatus.Size = new System.Drawing.Size(263, 24);
            this.cmbUpdateStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(36, 162);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Update Status";
            // 
            // lblSelectedOrder
            // 
            this.lblSelectedOrder.AutoSize = true;
            this.lblSelectedOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedOrder.Location = new System.Drawing.Point(32, 61);
            this.lblSelectedOrder.Name = "lblSelectedOrder";
            this.lblSelectedOrder.Size = new System.Drawing.Size(174, 23);
            this.lblSelectedOrder.TabIndex = 1;
            this.lblSelectedOrder.Text = "Selected Order: None";
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.Location = new System.Drawing.Point(32, 16);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(205, 41);
            this.lblDetailsTitle.TabIndex = 0;
            this.lblDetailsTitle.Text = "Order Details";
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1238, 850);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Order Management";
            this.Load += new System.EventHandler(this.AdminOrdersForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2Panel pnlDetails;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSelectedOrder;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.ComboBox cmbUpdateStatus;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStatus;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label lblPrescriptionRequired;
        private System.Windows.Forms.Label lblAdminNote;
        private System.Windows.Forms.Label lblPrescriptionStatus;
        private Guna.UI2.WinForms.Guna2Button btnRejectPrescription;
        private Guna.UI2.WinForms.Guna2Button btnApprovePrescription;
        private Guna.UI2.WinForms.Guna2Button btnViewPrescription;
        private Guna.UI2.WinForms.Guna2TextBox txtAdminNote;
        private Guna.UI2.WinForms.Guna2Button btnViewInvoice;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Label lblPaymentStatusTitle;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePaymentStatus;
    }
}