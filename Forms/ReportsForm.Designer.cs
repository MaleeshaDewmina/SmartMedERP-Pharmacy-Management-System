namespace SmartMed.Forms
{
    partial class ReportsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblReportType = new System.Windows.Forms.Label();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSalesCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.pnlOrdersCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.pnlRevenueCard = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblRevenueTitle = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.btnExportPdf = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSalesCard.SuspendLayout();
            this.pnlOrdersCard.SuspendLayout();
            this.pnlRevenueCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports";
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportType.Location = new System.Drawing.Point(40, 90);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(101, 23);
            this.lblReportType.TabIndex = 1;
            this.lblReportType.Text = "Report Type";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Sales Report",
            "",
            "Inventory Report",
            "",
            "Low Stock Report",
            "",
            "Expiry Report"});
            this.cmbReportType.Location = new System.Drawing.Point(160, 85);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(250, 24);
            this.cmbReportType.TabIndex = 2;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(430, 90);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(90, 23);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(530, 91);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(180, 22);
            this.dtpFromDate.TabIndex = 4;
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(730, 90);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(68, 23);
            this.lblToDate.TabIndex = 5;
            this.lblToDate.Text = "To Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(811, 93);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(180, 22);
            this.dtpToDate.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BorderRadius = 8;
            this.btnGenerate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(40, 150);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(180, 45);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnlSalesCard
            // 
            this.pnlSalesCard.BorderRadius = 15;
            this.pnlSalesCard.Controls.Add(this.lblTotalSales);
            this.pnlSalesCard.Controls.Add(this.lblSalesTitle);
            this.pnlSalesCard.FillColor = System.Drawing.Color.White;
            this.pnlSalesCard.Location = new System.Drawing.Point(40, 220);
            this.pnlSalesCard.Name = "pnlSalesCard";
            this.pnlSalesCard.Size = new System.Drawing.Size(300, 100);
            this.pnlSalesCard.TabIndex = 8;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.AutoSize = true;
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.Location = new System.Drawing.Point(20, 15);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(89, 23);
            this.lblSalesTitle.TabIndex = 0;
            this.lblSalesTitle.Text = "Total Sales";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(20, 45);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(126, 41);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "Rs. 0.00";
            // 
            // pnlOrdersCard
            // 
            this.pnlOrdersCard.BorderRadius = 15;
            this.pnlOrdersCard.Controls.Add(this.lblTotalOrders);
            this.pnlOrdersCard.Controls.Add(this.lblOrdersTitle);
            this.pnlOrdersCard.FillColor = System.Drawing.Color.White;
            this.pnlOrdersCard.Location = new System.Drawing.Point(370, 220);
            this.pnlOrdersCard.Name = "pnlOrdersCard";
            this.pnlOrdersCard.Size = new System.Drawing.Size(300, 100);
            this.pnlOrdersCard.TabIndex = 9;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(20, 45);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(35, 41);
            this.lblTotalOrders.TabIndex = 1;
            this.lblTotalOrders.Text = "0";
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.AutoSize = true;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersTitle.Location = new System.Drawing.Point(20, 15);
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(102, 23);
            this.lblOrdersTitle.TabIndex = 0;
            this.lblOrdersTitle.Text = "Total Orders";
            // 
            // pnlRevenueCard
            // 
            this.pnlRevenueCard.BorderRadius = 15;
            this.pnlRevenueCard.Controls.Add(this.lblTotalRevenue);
            this.pnlRevenueCard.Controls.Add(this.lblRevenueTitle);
            this.pnlRevenueCard.FillColor = System.Drawing.Color.White;
            this.pnlRevenueCard.Location = new System.Drawing.Point(700, 220);
            this.pnlRevenueCard.Name = "pnlRevenueCard";
            this.pnlRevenueCard.Size = new System.Drawing.Size(300, 100);
            this.pnlRevenueCard.TabIndex = 10;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(20, 45);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(126, 41);
            this.lblTotalRevenue.TabIndex = 1;
            this.lblTotalRevenue.Text = "Rs. 0.00";
            // 
            // lblRevenueTitle
            // 
            this.lblRevenueTitle.AutoSize = true;
            this.lblRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTitle.Location = new System.Drawing.Point(20, 15);
            this.lblRevenueTitle.Name = "lblRevenueTitle";
            this.lblRevenueTitle.Size = new System.Drawing.Size(116, 23);
            this.lblRevenueTitle.TabIndex = 0;
            this.lblRevenueTitle.Text = "Total Revenue";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(40, 350);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.RowTemplate.Height = 24;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(1000, 280);
            this.dgvReports.TabIndex = 11;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BorderRadius = 8;
            this.btnExportPdf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPdf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPdf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportPdf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportPdf.ForeColor = System.Drawing.Color.White;
            this.btnExportPdf.Location = new System.Drawing.Point(240, 150);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(180, 45);
            this.btnExportPdf.TabIndex = 12;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.pnlRevenueCard);
            this.Controls.Add(this.pnlOrdersCard);
            this.Controls.Add(this.pnlSalesCard);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.lblReportType);
            this.Controls.Add(this.lblTitle);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.pnlSalesCard.ResumeLayout(false);
            this.pnlSalesCard.PerformLayout();
            this.pnlOrdersCard.ResumeLayout(false);
            this.pnlOrdersCard.PerformLayout();
            this.pnlRevenueCard.ResumeLayout(false);
            this.pnlRevenueCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblReportType;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
        private Guna.UI2.WinForms.Guna2Panel pnlSalesCard;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Label lblTotalSales;
        private Guna.UI2.WinForms.Guna2Panel pnlOrdersCard;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblOrdersTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlRevenueCard;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.DataGridView dgvReports;
        private Guna.UI2.WinForms.Guna2Button btnExportPdf;
    }
}