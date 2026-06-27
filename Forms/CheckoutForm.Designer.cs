namespace SmartMed.Forms
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDeliveryFee = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblGrandTotalTitle = new System.Windows.Forms.Label();
            this.lblDeliveryFeeTitle = new System.Windows.Forms.Label();
            this.lblTaxTitle = new System.Windows.Forms.Label();
            this.lblDiscountTitle = new System.Windows.Forms.Label();
            this.lblSubTotalTitle = new System.Windows.Forms.Label();
            this.dgvCheckoutItems = new System.Windows.Forms.DataGridView();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlDelivery = new Guna.UI2.WinForms.Guna2Panel();
            this.cmbDeliveryMethod = new System.Windows.Forms.ComboBox();
            this.txtDeliveryAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeliveryNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDeliveryPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkUseDefaultAddress = new System.Windows.Forms.CheckBox();
            this.lblDeliveryTitle = new System.Windows.Forms.Label();
            this.lblDeliveryNote = new System.Windows.Forms.Label();
            this.lblDeliveryMethod = new System.Windows.Forms.Label();
            this.lblDeliveryAddress = new System.Windows.Forms.Label();
            this.lblDeliveryPhone = new System.Windows.Forms.Label();
            this.pnlPrescription = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowsePrescription = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrescriptionRequired = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentPrescriptionTitle = new System.Windows.Forms.Label();
            this.txtPrescriptionFile = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckoutItems)).BeginInit();
            this.pnlDelivery.SuspendLayout();
            this.pnlPrescription.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1090, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(960, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 52);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(665, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Confirm delivery details, payment method, and prescription before placing your or" +
    "der.";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Checkout";
            // 
            // pnlSummary
            // 
            this.pnlSummary.BorderRadius = 18;
            this.pnlSummary.Controls.Add(this.lblGrandTotal);
            this.pnlSummary.Controls.Add(this.lblDeliveryFee);
            this.pnlSummary.Controls.Add(this.lblTax);
            this.pnlSummary.Controls.Add(this.lblDiscount);
            this.pnlSummary.Controls.Add(this.lblSubTotal);
            this.pnlSummary.Controls.Add(this.lblGrandTotalTitle);
            this.pnlSummary.Controls.Add(this.lblDeliveryFeeTitle);
            this.pnlSummary.Controls.Add(this.lblTaxTitle);
            this.pnlSummary.Controls.Add(this.lblDiscountTitle);
            this.pnlSummary.Controls.Add(this.lblSubTotalTitle);
            this.pnlSummary.Controls.Add(this.dgvCheckoutItems);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.FillColor = System.Drawing.Color.White;
            this.pnlSummary.Location = new System.Drawing.Point(20, 120);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(540, 560);
            this.pnlSummary.TabIndex = 1;
            this.pnlSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSummary_Paint);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(320, 500);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(105, 35);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Rs. 0.00";
            // 
            // lblDeliveryFee
            // 
            this.lblDeliveryFee.AutoSize = true;
            this.lblDeliveryFee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFee.Location = new System.Drawing.Point(360, 455);
            this.lblDeliveryFee.Name = "lblDeliveryFee";
            this.lblDeliveryFee.Size = new System.Drawing.Size(73, 23);
            this.lblDeliveryFee.TabIndex = 7;
            this.lblDeliveryFee.Text = "Rs. 0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(360, 425);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(73, 23);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Rs. 0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(360, 395);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(73, 23);
            this.lblDiscount.TabIndex = 7;
            this.lblDiscount.Text = "Rs. 0.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(360, 365);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(73, 23);
            this.lblSubTotal.TabIndex = 7;
            this.lblSubTotal.Text = "Rs. 0.00";
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.AutoSize = true;
            this.lblGrandTotalTitle.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(25, 500);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(140, 30);
            this.lblGrandTotalTitle.TabIndex = 6;
            this.lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // lblDeliveryFeeTitle
            // 
            this.lblDeliveryFeeTitle.AutoSize = true;
            this.lblDeliveryFeeTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryFeeTitle.Location = new System.Drawing.Point(25, 455);
            this.lblDeliveryFeeTitle.Name = "lblDeliveryFeeTitle";
            this.lblDeliveryFeeTitle.Size = new System.Drawing.Size(105, 23);
            this.lblDeliveryFeeTitle.TabIndex = 6;
            this.lblDeliveryFeeTitle.Text = "Delivery Fee:";
            // 
            // lblTaxTitle
            // 
            this.lblTaxTitle.AutoSize = true;
            this.lblTaxTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxTitle.Location = new System.Drawing.Point(25, 425);
            this.lblTaxTitle.Name = "lblTaxTitle";
            this.lblTaxTitle.Size = new System.Drawing.Size(38, 23);
            this.lblTaxTitle.TabIndex = 6;
            this.lblTaxTitle.Text = "Tax:";
            // 
            // lblDiscountTitle
            // 
            this.lblDiscountTitle.AutoSize = true;
            this.lblDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscountTitle.Location = new System.Drawing.Point(25, 395);
            this.lblDiscountTitle.Name = "lblDiscountTitle";
            this.lblDiscountTitle.Size = new System.Drawing.Size(81, 23);
            this.lblDiscountTitle.TabIndex = 6;
            this.lblDiscountTitle.Text = "Discount:";
            // 
            // lblSubTotalTitle
            // 
            this.lblSubTotalTitle.AutoSize = true;
            this.lblSubTotalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalTitle.Location = new System.Drawing.Point(25, 365);
            this.lblSubTotalTitle.Name = "lblSubTotalTitle";
            this.lblSubTotalTitle.Size = new System.Drawing.Size(84, 23);
            this.lblSubTotalTitle.TabIndex = 6;
            this.lblSubTotalTitle.Text = "Sub Total:";
            // 
            // dgvCheckoutItems
            // 
            this.dgvCheckoutItems.AllowUserToAddRows = false;
            this.dgvCheckoutItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckoutItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvCheckoutItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckoutItems.Location = new System.Drawing.Point(25, 70);
            this.dgvCheckoutItems.MultiSelect = false;
            this.dgvCheckoutItems.Name = "dgvCheckoutItems";
            this.dgvCheckoutItems.ReadOnly = true;
            this.dgvCheckoutItems.RowHeadersVisible = false;
            this.dgvCheckoutItems.RowHeadersWidth = 51;
            this.dgvCheckoutItems.RowTemplate.Height = 24;
            this.dgvCheckoutItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckoutItems.Size = new System.Drawing.Size(490, 270);
            this.dgvCheckoutItems.TabIndex = 5;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(25, 20);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(242, 41);
            this.lblSummaryTitle.TabIndex = 4;
            this.lblSummaryTitle.Text = "Order Summary";
            // 
            // pnlDelivery
            // 
            this.pnlDelivery.BorderRadius = 18;
            this.pnlDelivery.Controls.Add(this.cmbDeliveryMethod);
            this.pnlDelivery.Controls.Add(this.txtDeliveryAddress);
            this.pnlDelivery.Controls.Add(this.txtDeliveryNote);
            this.pnlDelivery.Controls.Add(this.txtDeliveryPhone);
            this.pnlDelivery.Controls.Add(this.chkUseDefaultAddress);
            this.pnlDelivery.Controls.Add(this.lblDeliveryTitle);
            this.pnlDelivery.Controls.Add(this.lblDeliveryNote);
            this.pnlDelivery.Controls.Add(this.lblDeliveryMethod);
            this.pnlDelivery.Controls.Add(this.lblDeliveryAddress);
            this.pnlDelivery.Controls.Add(this.lblDeliveryPhone);
            this.pnlDelivery.FillColor = System.Drawing.Color.White;
            this.pnlDelivery.Location = new System.Drawing.Point(590, 120);
            this.pnlDelivery.Name = "pnlDelivery";
            this.pnlDelivery.Size = new System.Drawing.Size(520, 295);
            this.pnlDelivery.TabIndex = 2;
            // 
            // cmbDeliveryMethod
            // 
            this.cmbDeliveryMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeliveryMethod.FormattingEnabled = true;
            this.cmbDeliveryMethod.Items.AddRange(new object[] {
            "Delivery",
            "",
            "Pickup"});
            this.cmbDeliveryMethod.Location = new System.Drawing.Point(150, 220);
            this.cmbDeliveryMethod.Name = "cmbDeliveryMethod";
            this.cmbDeliveryMethod.Size = new System.Drawing.Size(150, 24);
            this.cmbDeliveryMethod.TabIndex = 8;
            this.cmbDeliveryMethod.SelectedIndexChanged += new System.EventHandler(this.cmbDeliveryMethod_SelectedIndexChanged);
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryAddress.DefaultText = "";
            this.txtDeliveryAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(150, 140);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.PlaceholderText = "";
            this.txtDeliveryAddress.SelectedText = "";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(330, 70);
            this.txtDeliveryAddress.TabIndex = 7;
            // 
            // txtDeliveryNote
            // 
            this.txtDeliveryNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryNote.DefaultText = "";
            this.txtDeliveryNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryNote.Location = new System.Drawing.Point(365, 220);
            this.txtDeliveryNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDeliveryNote.Name = "txtDeliveryNote";
            this.txtDeliveryNote.PlaceholderText = "";
            this.txtDeliveryNote.SelectedText = "";
            this.txtDeliveryNote.Size = new System.Drawing.Size(115, 35);
            this.txtDeliveryNote.TabIndex = 7;
            // 
            // txtDeliveryPhone
            // 
            this.txtDeliveryPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeliveryPhone.DefaultText = "";
            this.txtDeliveryPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeliveryPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeliveryPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeliveryPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDeliveryPhone.Location = new System.Drawing.Point(152, 95);
            this.txtDeliveryPhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDeliveryPhone.Name = "txtDeliveryPhone";
            this.txtDeliveryPhone.PlaceholderText = "";
            this.txtDeliveryPhone.SelectedText = "";
            this.txtDeliveryPhone.Size = new System.Drawing.Size(330, 35);
            this.txtDeliveryPhone.TabIndex = 7;
            // 
            // chkUseDefaultAddress
            // 
            this.chkUseDefaultAddress.AutoSize = true;
            this.chkUseDefaultAddress.Checked = true;
            this.chkUseDefaultAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseDefaultAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDefaultAddress.Location = new System.Drawing.Point(25, 60);
            this.chkUseDefaultAddress.Name = "chkUseDefaultAddress";
            this.chkUseDefaultAddress.Size = new System.Drawing.Size(252, 27);
            this.chkUseDefaultAddress.TabIndex = 5;
            this.chkUseDefaultAddress.Text = "Use my saved profile address";
            this.chkUseDefaultAddress.UseVisualStyleBackColor = true;
            this.chkUseDefaultAddress.CheckedChanged += new System.EventHandler(this.chkUseDefaultAddress_CheckedChanged);
            // 
            // lblDeliveryTitle
            // 
            this.lblDeliveryTitle.AutoSize = true;
            this.lblDeliveryTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDeliveryTitle.Location = new System.Drawing.Point(25, 18);
            this.lblDeliveryTitle.Name = "lblDeliveryTitle";
            this.lblDeliveryTitle.Size = new System.Drawing.Size(240, 41);
            this.lblDeliveryTitle.TabIndex = 4;
            this.lblDeliveryTitle.Text = "Delivery Details";
            // 
            // lblDeliveryNote
            // 
            this.lblDeliveryNote.AutoSize = true;
            this.lblDeliveryNote.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryNote.Location = new System.Drawing.Point(315, 225);
            this.lblDeliveryNote.Name = "lblDeliveryNote";
            this.lblDeliveryNote.Size = new System.Drawing.Size(48, 23);
            this.lblDeliveryNote.TabIndex = 6;
            this.lblDeliveryNote.Text = "Note";
            // 
            // lblDeliveryMethod
            // 
            this.lblDeliveryMethod.AutoSize = true;
            this.lblDeliveryMethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryMethod.Location = new System.Drawing.Point(21, 221);
            this.lblDeliveryMethod.Name = "lblDeliveryMethod";
            this.lblDeliveryMethod.Size = new System.Drawing.Size(70, 23);
            this.lblDeliveryMethod.TabIndex = 6;
            this.lblDeliveryMethod.Text = "Method";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryAddress.Location = new System.Drawing.Point(25, 145);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(70, 23);
            this.lblDeliveryAddress.TabIndex = 6;
            this.lblDeliveryAddress.Text = "Address";
            // 
            // lblDeliveryPhone
            // 
            this.lblDeliveryPhone.AutoSize = true;
            this.lblDeliveryPhone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryPhone.Location = new System.Drawing.Point(25, 100);
            this.lblDeliveryPhone.Name = "lblDeliveryPhone";
            this.lblDeliveryPhone.Size = new System.Drawing.Size(59, 23);
            this.lblDeliveryPhone.TabIndex = 6;
            this.lblDeliveryPhone.Text = "Phone";
            // 
            // pnlPrescription
            // 
            this.pnlPrescription.BorderRadius = 18;
            this.pnlPrescription.Controls.Add(this.btnCancel);
            this.pnlPrescription.Controls.Add(this.btnConfirmOrder);
            this.pnlPrescription.Controls.Add(this.btnBrowsePrescription);
            this.pnlPrescription.Controls.Add(this.lblPrescriptionRequired);
            this.pnlPrescription.Controls.Add(this.cmbPaymentMethod);
            this.pnlPrescription.Controls.Add(this.lblPaymentPrescriptionTitle);
            this.pnlPrescription.Controls.Add(this.txtPrescriptionFile);
            this.pnlPrescription.Controls.Add(this.lblPaymentMethod);
            this.pnlPrescription.FillColor = System.Drawing.Color.White;
            this.pnlPrescription.Location = new System.Drawing.Point(590, 435);
            this.pnlPrescription.Name = "pnlPrescription";
            this.pnlPrescription.Size = new System.Drawing.Size(520, 245);
            this.pnlPrescription.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(225, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BorderRadius = 10;
            this.btnConfirmOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnConfirmOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.White;
            this.btnConfirmOrder.Location = new System.Drawing.Point(25, 195);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(180, 40);
            this.btnConfirmOrder.TabIndex = 3;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnBrowsePrescription
            // 
            this.btnBrowsePrescription.BorderRadius = 10;
            this.btnBrowsePrescription.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowsePrescription.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowsePrescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowsePrescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowsePrescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnBrowsePrescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowsePrescription.ForeColor = System.Drawing.Color.White;
            this.btnBrowsePrescription.Location = new System.Drawing.Point(390, 145);
            this.btnBrowsePrescription.Name = "btnBrowsePrescription";
            this.btnBrowsePrescription.Size = new System.Drawing.Size(100, 35);
            this.btnBrowsePrescription.TabIndex = 3;
            this.btnBrowsePrescription.Text = "Browse";
            this.btnBrowsePrescription.Click += new System.EventHandler(this.btnBrowsePrescription_Click);
            // 
            // lblPrescriptionRequired
            // 
            this.lblPrescriptionRequired.AutoSize = true;
            this.lblPrescriptionRequired.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescriptionRequired.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.lblPrescriptionRequired.Location = new System.Drawing.Point(25, 110);
            this.lblPrescriptionRequired.Name = "lblPrescriptionRequired";
            this.lblPrescriptionRequired.Size = new System.Drawing.Size(205, 23);
            this.lblPrescriptionRequired.TabIndex = 8;
            this.lblPrescriptionRequired.Text = "Prescription Required: No";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash on Delivery",
            "",
            "Card",
            "",
            "Online Payment"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(180, 67);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(220, 24);
            this.cmbPaymentMethod.TabIndex = 7;
            // 
            // lblPaymentPrescriptionTitle
            // 
            this.lblPaymentPrescriptionTitle.AutoSize = true;
            this.lblPaymentPrescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPaymentPrescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblPaymentPrescriptionTitle.Location = new System.Drawing.Point(25, 18);
            this.lblPaymentPrescriptionTitle.Name = "lblPaymentPrescriptionTitle";
            this.lblPaymentPrescriptionTitle.Size = new System.Drawing.Size(379, 41);
            this.lblPaymentPrescriptionTitle.TabIndex = 4;
            this.lblPaymentPrescriptionTitle.Text = "Payment and Prescription";
            // 
            // txtPrescriptionFile
            // 
            this.txtPrescriptionFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrescriptionFile.DefaultText = "";
            this.txtPrescriptionFile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrescriptionFile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrescriptionFile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrescriptionFile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrescriptionFile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrescriptionFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrescriptionFile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrescriptionFile.Location = new System.Drawing.Point(25, 137);
            this.txtPrescriptionFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrescriptionFile.Name = "txtPrescriptionFile";
            this.txtPrescriptionFile.PlaceholderText = "";
            this.txtPrescriptionFile.ReadOnly = true;
            this.txtPrescriptionFile.SelectedText = "";
            this.txtPrescriptionFile.Size = new System.Drawing.Size(311, 30);
            this.txtPrescriptionFile.TabIndex = 7;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.Location = new System.Drawing.Point(25, 65);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(141, 23);
            this.lblPaymentMethod.TabIndex = 6;
            this.lblPaymentMethod.Text = "Payment Method";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1132, 703);
            this.Controls.Add(this.pnlPrescription);
            this.Controls.Add(this.pnlDelivery);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckoutItems)).EndInit();
            this.pnlDelivery.ResumeLayout(false);
            this.pnlDelivery.PerformLayout();
            this.pnlPrescription.ResumeLayout(false);
            this.pnlPrescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Panel pnlSummary;
        private System.Windows.Forms.DataGridView dgvCheckoutItems;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblDeliveryFee;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblDeliveryFeeTitle;
        private System.Windows.Forms.Label lblTaxTitle;
        private System.Windows.Forms.Label lblDiscountTitle;
        private System.Windows.Forms.Label lblSubTotalTitle;
        private System.Windows.Forms.Label lblGrandTotalTitle;
        private System.Windows.Forms.Label lblGrandTotal;
        private Guna.UI2.WinForms.Guna2Panel pnlDelivery;
        private System.Windows.Forms.CheckBox chkUseDefaultAddress;
        private System.Windows.Forms.Label lblDeliveryTitle;
        private System.Windows.Forms.Label lblDeliveryPhone;
        private System.Windows.Forms.ComboBox cmbDeliveryMethod;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryNote;
        private Guna.UI2.WinForms.Guna2TextBox txtDeliveryPhone;
        private System.Windows.Forms.Label lblDeliveryNote;
        private System.Windows.Forms.Label lblDeliveryMethod;
        private System.Windows.Forms.Label lblDeliveryAddress;
        private Guna.UI2.WinForms.Guna2Panel pnlPrescription;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentPrescriptionTitle;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.Label lblPrescriptionRequired;
        private Guna.UI2.WinForms.Guna2TextBox txtPrescriptionFile;
        private Guna.UI2.WinForms.Guna2Button btnBrowsePrescription;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnConfirmOrder;
    }
}