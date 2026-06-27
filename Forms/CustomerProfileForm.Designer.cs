namespace SmartMed.Forms
{
    partial class CustomerProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerProfileForm));
            this.pnlProfile = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateProfile = new Guna.UI2.WinForms.Guna2Button();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLoyaltyPoints = new System.Windows.Forms.Label();
            this.lblMembershipLevel = new System.Windows.Forms.Label();
            this.pnlProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.BorderRadius = 18;
            this.pnlProfile.Controls.Add(this.lblMembershipLevel);
            this.pnlProfile.Controls.Add(this.lblLoyaltyPoints);
            this.pnlProfile.Controls.Add(this.btnClose);
            this.pnlProfile.Controls.Add(this.btnUpdateProfile);
            this.pnlProfile.Controls.Add(this.txtNewPassword);
            this.pnlProfile.Controls.Add(this.txtUsername);
            this.pnlProfile.Controls.Add(this.txtAddress);
            this.pnlProfile.Controls.Add(this.txtPhone);
            this.pnlProfile.Controls.Add(this.txtEmail);
            this.pnlProfile.Controls.Add(this.txtFullName);
            this.pnlProfile.Controls.Add(this.lblPasswordTitle);
            this.pnlProfile.Controls.Add(this.lblAddress);
            this.pnlProfile.Controls.Add(this.lblPhone);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.lblFullName);
            this.pnlProfile.Controls.Add(this.lblSubTitle);
            this.pnlProfile.Controls.Add(this.lblTitle);
            this.pnlProfile.FillColor = System.Drawing.Color.White;
            this.pnlProfile.Location = new System.Drawing.Point(30, 30);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(640, 500);
            this.pnlProfile.TabIndex = 0;
            this.pnlProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlProfile_Paint);
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
            this.btnClose.Location = new System.Drawing.Point(350, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BorderRadius = 10;
            this.btnUpdateProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateProfile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(180, 460);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(150, 40);
            this.btnUpdateProfile.TabIndex = 6;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPassword.Location = new System.Drawing.Point(180, 410);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderText = "Enter new password only if changing";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(380, 36);
            this.txtNewPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsername.Location = new System.Drawing.Point(180, 150);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(380, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAddress.Location = new System.Drawing.Point(180, 290);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(380, 70);
            this.txtAddress.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPhone.Location = new System.Drawing.Point(180, 240);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(380, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(180, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtFullName
            // 
            this.txtFullName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFullName.Location = new System.Drawing.Point(180, 105);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(380, 22);
            this.txtFullName.TabIndex = 3;
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordTitle.Location = new System.Drawing.Point(35, 375);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(161, 25);
            this.lblPasswordTitle.TabIndex = 2;
            this.lblPasswordTitle.Text = "Change Password";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(35, 290);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(77, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(35, 245);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 25);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(35, 200);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(35, 155);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(35, 110);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 25);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubTitle.Location = new System.Drawing.Point(33, 62);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(315, 23);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Manage your SmartMed account details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(203, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Profile";
            // 
            // lblLoyaltyPoints
            // 
            this.lblLoyaltyPoints.AutoSize = true;
            this.lblLoyaltyPoints.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoyaltyPoints.Location = new System.Drawing.Point(382, 20);
            this.lblLoyaltyPoints.Name = "lblLoyaltyPoints";
            this.lblLoyaltyPoints.Size = new System.Drawing.Size(141, 23);
            this.lblLoyaltyPoints.TabIndex = 7;
            this.lblLoyaltyPoints.Text = "Loyalty Points: 0";
            // 
            // lblMembershipLevel
            // 
            this.lblMembershipLevel.AutoSize = true;
            this.lblMembershipLevel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembershipLevel.Location = new System.Drawing.Point(382, 47);
            this.lblMembershipLevel.Name = "lblMembershipLevel";
            this.lblMembershipLevel.Size = new System.Drawing.Size(222, 23);
            this.lblMembershipLevel.TabIndex = 8;
            this.lblMembershipLevel.Text = "Membership Level: Bronze";
            // 
            // CustomerProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(702, 553);
            this.Controls.Add(this.pnlProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomerProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.Load += new System.EventHandler(this.CustomerProfileForm_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlProfile;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPasswordTitle;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnUpdateProfile;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Label lblMembershipLevel;
        private System.Windows.Forms.Label lblLoyaltyPoints;
    }
}