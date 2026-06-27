namespace SmartMed.Forms
{
    partial class CustomerCartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.dgvCartItems = new System.Windows.Forms.DataGridView();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnBack);
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(990, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.lblTitle.Location = new System.Drawing.Point(25, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Cart";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(870, 22);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 38);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlCart
            // 
            this.pnlCart.BackColor = System.Drawing.Color.White;
            this.pnlCart.Controls.Add(this.dgvCartItems);
            this.pnlCart.Controls.Add(this.lblCartTitle);
            this.pnlCart.Location = new System.Drawing.Point(20, 120);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(650, 500);
            this.pnlCart.TabIndex = 1;
            // 
            // dgvCartItems
            // 
            this.dgvCartItems.AllowUserToAddRows = false;
            this.dgvCartItems.AllowUserToDeleteRows = false;
            this.dgvCartItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCartItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvCartItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCartItems.ColumnHeadersHeight = 35;
            this.dgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCartItems.Location = new System.Drawing.Point(20, 70);
            this.dgvCartItems.MultiSelect = false;
            this.dgvCartItems.Name = "dgvCartItems";
            this.dgvCartItems.ReadOnly = true;
            this.dgvCartItems.RowHeadersVisible = false;
            this.dgvCartItems.RowHeadersWidth = 51;
            this.dgvCartItems.RowTemplate.Height = 32;
            this.dgvCartItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCartItems.Size = new System.Drawing.Size(610, 400);
            this.dgvCartItems.TabIndex = 1;
            this.dgvCartItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCartItems_CellClick);
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblCartTitle.Location = new System.Drawing.Point(20, 18);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(151, 37);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "Cart Items";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Controls.Add(this.lblSubTotal);
            this.pnlSummary.Controls.Add(this.lblDiscount);
            this.pnlSummary.Controls.Add(this.lblTax);
            this.pnlSummary.Controls.Add(this.lblGrandTotal);
            this.pnlSummary.Controls.Add(this.lblQuantity);
            this.pnlSummary.Controls.Add(this.txtQuantity);
            this.pnlSummary.Controls.Add(this.btnUpdateQuantity);
            this.pnlSummary.Controls.Add(this.btnRemoveItem);
            this.pnlSummary.Controls.Add(this.btnClearCart);
            this.pnlSummary.Controls.Add(this.btnCheckout);
            this.pnlSummary.Controls.Add(this.btnRefresh);
            this.pnlSummary.Location = new System.Drawing.Point(690, 120);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(320, 500);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(25, 18);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(221, 37);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Order Summary";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSubTotal.Location = new System.Drawing.Point(30, 85);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(160, 25);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "Sub Total: Rs. 0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDiscount.Location = new System.Drawing.Point(30, 125);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(157, 25);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "Discount: Rs. 0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTax.Location = new System.Drawing.Point(30, 165);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(110, 25);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Tax: Rs. 0.00";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(30, 220);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(251, 32);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.Text = "Grand Total: Rs. 0.00";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblQuantity.Location = new System.Drawing.Point(32, 290);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(130, 286);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(150, 32);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "1";
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnUpdateQuantity.FlatAppearance.BorderSize = 0;
            this.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuantity.ForeColor = System.Drawing.Color.White;
            this.btnUpdateQuantity.Location = new System.Drawing.Point(30, 340);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(120, 40);
            this.btnUpdateQuantity.TabIndex = 7;
            this.btnUpdateQuantity.Text = "Update Qty";
            this.btnUpdateQuantity.UseVisualStyleBackColor = false;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(170, 340);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 40);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.Location = new System.Drawing.Point(30, 395);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(120, 40);
            this.btnClearCart.TabIndex = 9;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = false;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(170, 395);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(120, 40);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(30, 450);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(260, 38);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh Cart";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // CustomerCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1032, 653);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CustomerCartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Cart";
            this.Load += new System.EventHandler(this.CustomerCartForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnRefresh;
    }
}