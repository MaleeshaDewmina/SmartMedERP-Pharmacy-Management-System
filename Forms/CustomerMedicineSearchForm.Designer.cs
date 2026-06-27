namespace SmartMed.Forms
{
    partial class CustomerMedicineSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMedicineSearchForm));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvMedicines = new System.Windows.Forms.DataGridView();
            this.pnlCart = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClearCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblGrandTotalTitle = new System.Windows.Forms.Label();
            this.txtDeliveryFee = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxTitle = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).BeginInit();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderRadius = 18;
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.FillColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1140, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 58);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(405, 23);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Find available medicines and add them to your cart.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(324, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Search Medicines";
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
            this.btnBack.Location = new System.Drawing.Point(1007, 28);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BorderRadius = 18;
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(20, 130);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(740, 80);
            this.pnlSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(597, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(34, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by medicine name, generic name, brand, barcode";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(562, 40);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvMedicines
            // 
            this.dgvMedicines.AllowUserToAddRows = false;
            this.dgvMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicines.BackgroundColor = System.Drawing.Color.White;
            this.dgvMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicines.Location = new System.Drawing.Point(20, 230);
            this.dgvMedicines.MultiSelect = false;
            this.dgvMedicines.Name = "dgvMedicines";
            this.dgvMedicines.ReadOnly = true;
            this.dgvMedicines.RowHeadersWidth = 51;
            this.dgvMedicines.RowTemplate.Height = 24;
            this.dgvMedicines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicines.Size = new System.Drawing.Size(740, 470);
            this.dgvMedicines.TabIndex = 4;
            // 
            // pnlCart
            // 
            this.pnlCart.BorderRadius = 18;
            this.pnlCart.Controls.Add(this.btnClearCart);
            this.pnlCart.Controls.Add(this.btnPlaceOrder);
            this.pnlCart.Controls.Add(this.lblGrandTotal);
            this.pnlCart.Controls.Add(this.lblGrandTotalTitle);
            this.pnlCart.Controls.Add(this.txtDeliveryFee);
            this.pnlCart.Controls.Add(this.lblDeliveryFee);
            this.pnlCart.Controls.Add(this.lblTax);
            this.pnlCart.Controls.Add(this.lblTaxTitle);
            this.pnlCart.Controls.Add(this.lblDiscount);
            this.pnlCart.Controls.Add(this.lblDiscountTitle);
            this.pnlCart.Controls.Add(this.lblSubTotal);
            this.pnlCart.Controls.Add(this.lblSubTotalTitle);
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.btnAddToCart);
            this.pnlCart.Controls.Add(this.txtQuantity);
            this.pnlCart.Controls.Add(this.lblQuantity);
            this.pnlCart.Controls.Add(this.lblCartTitle);
            this.pnlCart.FillColor = System.Drawing.Color.White;
            this.pnlCart.Location = new System.Drawing.Point(790, 130);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(370, 570);
            this.pnlCart.TabIndex = 5;
            // 
            // btnClearCart
            // 
            this.btnClearCart.BorderRadius = 10;
            this.btnClearCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(195, 520);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(150, 40);
            this.btnClearCart.TabIndex = 18;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BorderRadius = 10;
            this.btnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(25, 520);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(150, 40);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(190, 480);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(86, 28);
            this.lblGrandTotal.TabIndex = 16;
            this.lblGrandTotal.Text = "Rs. 0.00";
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.AutoSize = true;
            this.lblGrandTotalTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(25, 480);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(127, 28);
            this.lblGrandTotalTitle.TabIndex = 15;
            this.lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // txtDeliveryFee
            // 
            this.txtDeliveryFee.AutoSize = true;
            this.txtDeliveryFee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeliveryFee.Location = new System.Drawing.Point(190, 438);
            this.txtDeliveryFee.Name = "txtDeliveryFee";
            this.txtDeliveryFee.Size = new System.Drawing.Size(20, 23);
            this.txtDeliveryFee.TabIndex = 14;
            this.txtDeliveryFee.Text = "0";
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFee.Location = new System.Drawing.Point(25, 440);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(105, 23);
            this.lblDeliveryFee.TabIndex = 13;
            this.lblDeliveryFee.Text = "Delivery Fee:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(190, 410);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(73, 23);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Rs. 0.00";
            // 
            // lblTaxTitle
            // 
            this.lblTaxTitle.AutoSize = true;
            this.lblTaxTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTitle.Location = new System.Drawing.Point(25, 410);
            this.lblTaxTitle.Name = "lblTaxTitle";
            this.lblTaxTitle.Size = new System.Drawing.Size(38, 23);
            this.lblTaxTitle.TabIndex = 11;
            this.lblTaxTitle.Text = "Tax:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(190, 380);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(73, 23);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Rs. 0.00";
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.Location = new System.Drawing.Point(25, 380);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(81, 23);
            this.lblDiscountTitle.TabIndex = 9;
            this.lblDiscountTitle.Text = "Discount:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(190, 350);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(73, 23);
            this.lblSubTotal.TabIndex = 8;
            this.lblSubTotal.Text = "Rs. 0.00";
            // 
            // lblSubTotalTitle
            // 
            this.lblSubTotalTitle.AutoSize = true;
            this.lblSubTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalTitle.Location = new System.Drawing.Point(25, 350);
            this.lblSubTotalTitle.Name = "lblSubTotalTitle";
            this.lblSubTotalTitle.Size = new System.Drawing.Size(84, 23);
            this.lblSubTotalTitle.TabIndex = 7;
            this.lblSubTotalTitle.Text = "Sub Total:";
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(25, 120);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(320, 210);
            this.dgvCart.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderRadius = 10;
            this.btnAddToCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddToCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddToCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.Location = new System.Drawing.Point(227, 61);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(120, 38);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(120, 68);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(90, 22);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "1";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(25, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 23);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCartTitle.Location = new System.Drawing.Point(25, 20);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(131, 41);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "My Cart";
            // 
            // CustomerMedicineSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.dgvMedicines);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerMedicineSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Medicines";
            this.Load += new System.EventHandler(this.CustomerMedicineSearchForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicines)).EndInit();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMedicines;
        private Guna.UI2.WinForms.Guna2Panel pnlCart;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxTitle;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTotalTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private Guna.UI2.WinForms.Guna2Button btnClearCart;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblGrandTotalTitle;
        private System.Windows.Forms.Label txtDeliveryFee;
    }
}