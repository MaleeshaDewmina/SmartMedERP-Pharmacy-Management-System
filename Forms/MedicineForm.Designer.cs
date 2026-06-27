namespace SmartMed.Forms
{
    partial class MedicineForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            this.txtStockQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSellingPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtGenericName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMedicineName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBrandName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.txtCostPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtReorderLevel = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBatchNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpManufactureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.chkPrescriptionRequired = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtDiscountPercentage = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBarcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQRCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtTaxPercentage = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStockQuantity
            // 
            this.txtStockQuantity.BorderRadius = 8;
            this.txtStockQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockQuantity.DefaultText = "";
            this.txtStockQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockQuantity.Location = new System.Drawing.Point(580, 210);
            this.txtStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStockQuantity.Name = "txtStockQuantity";
            this.txtStockQuantity.PlaceholderText = "Stock Quantity";
            this.txtStockQuantity.SelectedText = "";
            this.txtStockQuantity.Size = new System.Drawing.Size(250, 40);
            this.txtStockQuantity.TabIndex = 43;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.BorderRadius = 8;
            this.txtSellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSellingPrice.DefaultText = "";
            this.txtSellingPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSellingPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSellingPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSellingPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSellingPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSellingPrice.Location = new System.Drawing.Point(310, 210);
            this.txtSellingPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.PlaceholderText = "Selling Price";
            this.txtSellingPrice.SelectedText = "";
            this.txtSellingPrice.Size = new System.Drawing.Size(250, 40);
            this.txtSellingPrice.TabIndex = 41;
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(40, 460);
            this.dgvMedicines.MultiSelect = false;
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersWidth = 51;
            this.dgvMedicines.RowTemplate.Height = 24;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(1060, 280);
            this.dgvMedicines.TabIndex = 39;
            this.dgvMedicines.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicines_CellClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(760, 390);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search medicines...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(340, 40);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(445, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 390);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 8;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(175, 390);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(40, 390);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGenericName
            // 
            this.txtGenericName.BorderRadius = 8;
            this.txtGenericName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenericName.DefaultText = "";
            this.txtGenericName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenericName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenericName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenericName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenericName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenericName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGenericName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenericName.Location = new System.Drawing.Point(310, 90);
            this.txtGenericName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGenericName.Name = "txtGenericName";
            this.txtGenericName.PlaceholderText = "Generic Name";
            this.txtGenericName.SelectedText = "";
            this.txtGenericName.Size = new System.Drawing.Size(250, 40);
            this.txtGenericName.TabIndex = 33;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.BorderRadius = 8;
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.DefaultText = "";
            this.txtMedicineName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedicineName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedicineName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedicineName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMedicineName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMedicineName.Location = new System.Drawing.Point(40, 90);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.PlaceholderText = "Medicine Name";
            this.txtMedicineName.SelectedText = "";
            this.txtMedicineName.Size = new System.Drawing.Size(250, 40);
            this.txtMedicineName.TabIndex = 31;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 45);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Manage Medicines";
            // 
            // txtBrandName
            // 
            this.txtBrandName.BorderRadius = 8;
            this.txtBrandName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrandName.DefaultText = "";
            this.txtBrandName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBrandName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBrandName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBrandName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBrandName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBrandName.Location = new System.Drawing.Point(580, 90);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.PlaceholderText = "Brand Name";
            this.txtBrandName.SelectedText = "";
            this.txtBrandName.Size = new System.Drawing.Size(250, 40);
            this.txtBrandName.TabIndex = 45;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(40, 150);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 24);
            this.cmbCategory.TabIndex = 46;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(310, 150);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(250, 24);
            this.cmbSupplier.TabIndex = 47;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BorderRadius = 8;
            this.txtCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostPrice.DefaultText = "";
            this.txtCostPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostPrice.Location = new System.Drawing.Point(40, 210);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.PlaceholderText = "Cost Price";
            this.txtCostPrice.SelectedText = "";
            this.txtCostPrice.Size = new System.Drawing.Size(250, 40);
            this.txtCostPrice.TabIndex = 48;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.BorderRadius = 8;
            this.txtReorderLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReorderLevel.DefaultText = "";
            this.txtReorderLevel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReorderLevel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReorderLevel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReorderLevel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReorderLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReorderLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReorderLevel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReorderLevel.Location = new System.Drawing.Point(850, 210);
            this.txtReorderLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.PlaceholderText = "Reorder Level";
            this.txtReorderLevel.SelectedText = "";
            this.txtReorderLevel.Size = new System.Drawing.Size(250, 40);
            this.txtReorderLevel.TabIndex = 49;
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.BorderRadius = 8;
            this.txtBatchNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatchNumber.DefaultText = "";
            this.txtBatchNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBatchNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBatchNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBatchNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBatchNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBatchNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatchNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBatchNumber.Location = new System.Drawing.Point(40, 270);
            this.txtBatchNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.PlaceholderText = "Batch Number";
            this.txtBatchNumber.SelectedText = "";
            this.txtBatchNumber.Size = new System.Drawing.Size(250, 40);
            this.txtBatchNumber.TabIndex = 50;
            // 
            // dtpManufactureDate
            // 
            this.dtpManufactureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManufactureDate.Location = new System.Drawing.Point(310, 270);
            this.dtpManufactureDate.Name = "dtpManufactureDate";
            this.dtpManufactureDate.Size = new System.Drawing.Size(250, 22);
            this.dtpManufactureDate.TabIndex = 51;
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(580, 270);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(250, 22);
            this.dtpExpiryDate.TabIndex = 52;
            // 
            // chkPrescriptionRequired
            // 
            this.chkPrescriptionRequired.AutoSize = true;
            this.chkPrescriptionRequired.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPrescriptionRequired.CheckedState.BorderRadius = 0;
            this.chkPrescriptionRequired.CheckedState.BorderThickness = 0;
            this.chkPrescriptionRequired.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkPrescriptionRequired.Location = new System.Drawing.Point(850, 275);
            this.chkPrescriptionRequired.Name = "chkPrescriptionRequired";
            this.chkPrescriptionRequired.Size = new System.Drawing.Size(159, 20);
            this.chkPrescriptionRequired.TabIndex = 53;
            this.chkPrescriptionRequired.Text = "Prescription Required";
            this.chkPrescriptionRequired.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkPrescriptionRequired.UncheckedState.BorderRadius = 0;
            this.chkPrescriptionRequired.UncheckedState.BorderThickness = 0;
            this.chkPrescriptionRequired.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtDiscountPercentage
            // 
            this.txtDiscountPercentage.BorderRadius = 8;
            this.txtDiscountPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscountPercentage.DefaultText = "";
            this.txtDiscountPercentage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscountPercentage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscountPercentage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountPercentage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscountPercentage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscountPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscountPercentage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscountPercentage.Location = new System.Drawing.Point(850, 90);
            this.txtDiscountPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.PlaceholderText = "DiscountPercentage";
            this.txtDiscountPercentage.SelectedText = "";
            this.txtDiscountPercentage.Size = new System.Drawing.Size(250, 40);
            this.txtDiscountPercentage.TabIndex = 54;
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderRadius = 8;
            this.txtBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBarcode.DefaultText = "";
            this.txtBarcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBarcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBarcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBarcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBarcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBarcode.Location = new System.Drawing.Point(580, 150);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "Barcode";
            this.txtBarcode.SelectedText = "";
            this.txtBarcode.Size = new System.Drawing.Size(250, 40);
            this.txtBarcode.TabIndex = 55;
            // 
            // txtQRCode
            // 
            this.txtQRCode.BorderRadius = 8;
            this.txtQRCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQRCode.DefaultText = "";
            this.txtQRCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQRCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQRCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQRCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQRCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQRCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQRCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQRCode.Location = new System.Drawing.Point(310, 330);
            this.txtQRCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQRCode.Name = "txtQRCode";
            this.txtQRCode.PlaceholderText = "QRCode";
            this.txtQRCode.SelectedText = "";
            this.txtQRCode.Size = new System.Drawing.Size(250, 40);
            this.txtQRCode.TabIndex = 56;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 0;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.chkIsActive.Location = new System.Drawing.Point(580, 335);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(82, 20);
            this.chkIsActive.TabIndex = 57;
            this.chkIsActive.Text = "Is Active ";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 0;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtTaxPercentage
            // 
            this.txtTaxPercentage.BorderRadius = 8;
            this.txtTaxPercentage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxPercentage.DefaultText = "";
            this.txtTaxPercentage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaxPercentage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaxPercentage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaxPercentage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaxPercentage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaxPercentage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaxPercentage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaxPercentage.Location = new System.Drawing.Point(850, 150);
            this.txtTaxPercentage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxPercentage.Name = "txtTaxPercentage";
            this.txtTaxPercentage.PlaceholderText = "Tax Percentage";
            this.txtTaxPercentage.SelectedText = "";
            this.txtTaxPercentage.Size = new System.Drawing.Size(250, 40);
            this.txtTaxPercentage.TabIndex = 58;
            // 
            // MedicineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 755);
            this.Controls.Add(this.txtTaxPercentage);
            this.Controls.Add(this.chkIsActive);
            this.Controls.Add(this.txtQRCode);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtDiscountPercentage);
            this.Controls.Add(this.chkPrescriptionRequired);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.dtpManufactureDate);
            this.Controls.Add(this.txtBatchNumber);
            this.Controls.Add(this.txtReorderLevel);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtStockQuantity);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGenericName);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MedicineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Medicines";
            this.Load += new System.EventHandler(this.MedicineForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtStockQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtSellingPrice;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtGenericName;
        private Guna.UI2.WinForms.Guna2TextBox txtMedicineName;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2TextBox txtBrandName;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtCostPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtReorderLevel;
        private Guna.UI2.WinForms.Guna2TextBox txtBatchNumber;
        private System.Windows.Forms.DateTimePicker dtpManufactureDate;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private Guna.UI2.WinForms.Guna2CheckBox chkPrescriptionRequired;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscountPercentage;
        private Guna.UI2.WinForms.Guna2TextBox txtBarcode;
        private Guna.UI2.WinForms.Guna2TextBox txtQRCode;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtTaxPercentage;
    }
}