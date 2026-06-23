namespace SmartMed.Forms
{
    partial class OrderForm
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblMedicine = new System.Windows.Forms.Label();
            this.cmbMedicine = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddItem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.lblSubTotalTitle = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTaxTitle = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtDeliveryFee = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGrandTotalTitle = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Orders";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(40, 90);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(84, 23);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(150, 85);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(300, 24);
            this.cmbCustomer.TabIndex = 2;
            // 
            // lblMedicine
            // 
            this.lblMedicine.AutoSize = true;
            this.lblMedicine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicine.Location = new System.Drawing.Point(40, 150);
            this.lblMedicine.Name = "lblMedicine";
            this.lblMedicine.Size = new System.Drawing.Size(79, 23);
            this.lblMedicine.TabIndex = 3;
            this.lblMedicine.Text = "Medicine";
            // 
            // cmbMedicine
            // 
            this.cmbMedicine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedicine.FormattingEnabled = true;
            this.cmbMedicine.Location = new System.Drawing.Point(150, 145);
            this.cmbMedicine.Name = "cmbMedicine";
            this.cmbMedicine.Size = new System.Drawing.Size(300, 24);
            this.cmbMedicine.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(470, 145);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "Quantity";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(150, 40);
            this.txtQuantity.TabIndex = 5;
            // 
            // btnAddItem
            // 
            this.btnAddItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(640, 145);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(130, 40);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(40, 220);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(1000, 260);
            this.dgvCart.TabIndex = 7;
            // 
            // lblSubTotalTitle
            // 
            this.lblSubTotalTitle.AutoSize = true;
            this.lblSubTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalTitle.Location = new System.Drawing.Point(650, 500);
            this.lblSubTotalTitle.Name = "lblSubTotalTitle";
            this.lblSubTotalTitle.Size = new System.Drawing.Size(78, 23);
            this.lblSubTotalTitle.TabIndex = 8;
            this.lblSubTotalTitle.Text = "Subtotal:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(800, 500);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(67, 23);
            this.lblSubTotal.TabIndex = 9;
            this.lblSubTotal.Text = "Rs. 0.00";
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.Location = new System.Drawing.Point(650, 530);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(81, 23);
            this.lblDiscountTitle.TabIndex = 10;
            this.lblDiscountTitle.Text = "Discount:";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(800, 530);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 23);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Rs. 0.00";
            // 
            // lblTaxTitle
            // 
            this.lblTaxTitle.AutoSize = true;
            this.lblTaxTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTitle.Location = new System.Drawing.Point(650, 560);
            this.lblTaxTitle.Name = "lblTaxTitle";
            this.lblTaxTitle.Size = new System.Drawing.Size(38, 23);
            this.lblTaxTitle.TabIndex = 12;
            this.lblTaxTitle.Text = "Tax:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(800, 560);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(67, 23);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Rs. 0.00";
            // 
            // txtDeliveryFee
            // 
            this.txtDeliveryFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryFee.DefaultText = "0";
            this.txtDeliveryFee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryFee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryFee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryFee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeliveryFee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryFee.Location = new System.Drawing.Point(650, 590);
            this.txtDeliveryFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryFee.Name = "txtDeliveryFee";
            this.txtDeliveryFee.PlaceholderText = "Delivery Fee";
            this.txtDeliveryFee.SelectedText = "";
            this.txtDeliveryFee.Size = new System.Drawing.Size(150, 40);
            this.txtDeliveryFee.TabIndex = 14;
            this.txtDeliveryFee.TextChanged += new System.EventHandler(this.txtDeliveryFee_TextChanged);
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.AutoSize = true;
            this.lblGrandTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(650, 640);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(102, 23);
            this.lblGrandTotalTitle.TabIndex = 15;
            this.lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(800, 640);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(96, 31);
            this.lblGrandTotal.TabIndex = 16;
            this.lblGrandTotal.Text = "Rs. 0.00";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlaceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlaceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(40, 520);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(160, 45);
            this.btnPlaceOrder.TabIndex = 18;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(220, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 45);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 677);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblGrandTotalTitle);
            this.Controls.Add(this.txtDeliveryFee);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTaxTitle);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblDiscountTitle);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSubTotalTitle);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbMedicine);
            this.Controls.Add(this.lblMedicine);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblTitle);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblMedicine;
        private System.Windows.Forms.ComboBox cmbMedicine;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblSubTotalTitle;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTaxTitle;
        private System.Windows.Forms.Label lblTax;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryFee;
        private System.Windows.Forms.Label lblGrandTotalTitle;
        private System.Windows.Forms.Label lblGrandTotal;
        private Guna.UI2.WinForms.Guna2Button btnPlaceOrder;
        private Guna.UI2.WinForms.Guna2Button btnClear;
    }
}