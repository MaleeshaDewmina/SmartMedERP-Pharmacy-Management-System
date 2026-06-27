namespace SmartMed.Forms
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.lblInvoiceTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblPrescriptionStatus = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblDeliveryPhone = new System.Windows.Forms.Label();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.pnlTotals = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            this.pnlTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 18;
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblInvoiceDate);
            this.pnlHeader.Controls.Add(this.lblInvoiceTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(940, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(820, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.Gray;
            this.lblInvoiceDate.Location = new System.Drawing.Point(241, 56);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(350, 25);
            this.lblInvoiceDate.TabIndex = 2;
            this.lblInvoiceDate.Text = "Date: -";
            // 
            // lblInvoiceTitle
            // 
            this.lblInvoiceTitle.AutoSize = true;
            this.lblInvoiceTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceTitle.Location = new System.Drawing.Point(240, 14);
            this.lblInvoiceTitle.Name = "lblInvoiceTitle";
            this.lblInvoiceTitle.Size = new System.Drawing.Size(279, 45);
            this.lblInvoiceTitle.TabIndex = 1;
            this.lblInvoiceTitle.Text = "Invoice / Receipt";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(25, 15);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(180, 60);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.BorderRadius = 18;
            this.pnlDetails.Controls.Add(this.lblOrderStatus);
            this.pnlDetails.Controls.Add(this.lblDeliveryAddress);
            this.pnlDetails.Controls.Add(this.lblPrescriptionStatus);
            this.pnlDetails.Controls.Add(this.lblPaymentStatus);
            this.pnlDetails.Controls.Add(this.lblDeliveryPhone);
            this.pnlDetails.Controls.Add(this.lblPaymentMethod);
            this.pnlDetails.Controls.Add(this.lblCustomerName);
            this.pnlDetails.Controls.Add(this.lblOrderId);
            this.pnlDetails.Location = new System.Drawing.Point(20, 130);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(940, 160);
            this.pnlDetails.TabIndex = 1;
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderStatus.Location = new System.Drawing.Point(560, 20);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(82, 20);
            this.lblOrderStatus.TabIndex = 3;
            this.lblOrderStatus.Text = "Status: -";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(25, 110);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(514, 40);
            this.lblDeliveryAddress.TabIndex = 2;
            this.lblDeliveryAddress.Text = "Address: -";
            // 
            // lblPrescriptionStatus
            // 
            this.lblPrescriptionStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionStatus.Location = new System.Drawing.Point(560, 110);
            this.lblPrescriptionStatus.Name = "lblPrescriptionStatus";
            this.lblPrescriptionStatus.Size = new System.Drawing.Size(330, 25);
            this.lblPrescriptionStatus.TabIndex = 2;
            this.lblPrescriptionStatus.Text = "Prescription: -";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentStatus.Location = new System.Drawing.Point(560, 80);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(350, 25);
            this.lblPaymentStatus.TabIndex = 2;
            this.lblPaymentStatus.Text = "Payment Status: -";
            // 
            // lblDeliveryPhone
            // 
            this.lblDeliveryPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryPhone.Location = new System.Drawing.Point(25, 80);
            this.lblDeliveryPhone.Name = "lblDeliveryPhone";
            this.lblDeliveryPhone.Size = new System.Drawing.Size(350, 25);
            this.lblDeliveryPhone.TabIndex = 2;
            this.lblDeliveryPhone.Text = "Phone: -";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(560, 50);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(330, 25);
            this.lblPaymentMethod.TabIndex = 1;
            this.lblPaymentMethod.Text = "Payment: -";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(25, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(350, 25);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer: -";
            // 
            // lblOrderId
            // 
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(25, 20);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(250, 25);
            this.lblOrderId.TabIndex = 0;
            this.lblOrderId.Text = "Order ID: -";
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceItems.Location = new System.Drawing.Point(20, 315);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidth = 51;
            this.dgvInvoiceItems.RowTemplate.Height = 24;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(940, 250);
            this.dgvInvoiceItems.TabIndex = 2;
            // 
            // pnlTotals
            // 
            this.pnlTotals.BackColor = System.Drawing.Color.White;
            this.pnlTotals.BorderRadius = 18;
            this.pnlTotals.Controls.Add(this.lblGrandTotal);
            this.pnlTotals.Controls.Add(this.lblTax);
            this.pnlTotals.Controls.Add(this.lblDiscount);
            this.pnlTotals.Controls.Add(this.lblSubTotal);
            this.pnlTotals.Location = new System.Drawing.Point(600, 585);
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Size = new System.Drawing.Size(360, 110);
            this.pnlTotals.TabIndex = 3;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(25, 84);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(300, 22);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = "Grand Total: Rs. 0.00";
            // 
            // lblTax
            // 
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(25, 61);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(300, 22);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax: Rs. 0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(25, 38);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(300, 22);
            this.lblDiscount.TabIndex = 1;
            this.lblDiscount.Text = "Discount: Rs. 0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(25, 15);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(300, 22);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total: Rs. 0.00";
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BorderRadius = 10;
            this.btnExportPdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportPdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportPdf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(20, 600);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(150, 45);
            this.btnExportPdf.TabIndex = 3;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(190, 600);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 45);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 10;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(330, 600);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.pnlTotals);
            this.Controls.Add(this.dgvInvoiceItems);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InvoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceForm";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            this.pnlTotals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceTitle;
        private System.Windows.Forms.PictureBox picLogo;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Panel pnlDetails;
        private System.Windows.Forms.Label lblOrderStatus;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private System.Windows.Forms.Label lblDeliveryPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.Label lblPrescriptionStatus;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private Guna.UI2.WinForms.Guna2Panel pnlTotals;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private Guna.UI2.WinForms.Guna2Button btnExportPdf;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}