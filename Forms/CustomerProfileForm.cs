using System;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Repositories;
using SmartMedERP.Services;
using SmartMedERP.Utilities;

namespace SmartMed.Forms
{
    /*
     * Allows customers to view and update their profile details.
     * Customers can update personal details, change password
     * and view loyalty points and membership level.
     */
    public partial class CustomerProfileForm : Form
    {
        private readonly CustomerProfileRepository profileRepository =
            new CustomerProfileRepository();

        private int currentUserId = 0;
        private int currentCustomerId = 0;

        public CustomerProfileForm()
        {
            InitializeComponent();
        }

        private void CustomerProfileForm_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser == null)
            {
                MessageBox.Show("Session expired. Please login again.");
                this.Close();
                return;
            }

            currentUserId =
                SessionManager.CurrentUser.UserId;

            LoadProfile();
        }

        // Loads customer profile, account and loyalty details.
        private void LoadProfile()
        {
            Customer customer =
                profileRepository.GetCustomerProfileByUserId(
                    currentUserId);

            if (customer == null)
            {
                MessageBox.Show("Customer profile not found.");
                this.Close();
                return;
            }

            currentCustomerId =
                customer.CustomerId;

            txtFullName.Text =
                customer.FullName;

            txtUsername.Text =
                customer.Username;

            txtEmail.Text =
                customer.Email;

            txtPhone.Text =
                customer.Phone;

            txtAddress.Text =
                customer.Address;

            txtNewPassword.Clear();

            lblLoyaltyPoints.Text =
                "Loyalty Points: " + customer.LoyaltyPoints;

            lblMembershipLevel.Text =
                "Membership Level: " + customer.MembershipLevel;
        }

        // Validates and updates customer profile information.
        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name.");
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.");
                txtAddress.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text) &&
                txtNewPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("New password must be at least 6 characters.");
                txtNewPassword.Focus();
                return;
            }

            try
            {
                Customer customer =
                    new Customer
                    {
                        CustomerId = currentCustomerId,
                        UserId = currentUserId,
                        FullName = txtFullName.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Address = txtAddress.Text.Trim()
                    };

                profileRepository.UpdateProfile(customer);

                AuditLogService auditLogService =
                    new AuditLogService();

                auditLogService.Log(
                    "Update Profile",
                    "Customer Profile",
                    "Customer updated profile details.");

                /*
                 * Password is updated only when the customer enters a new password.
                 * The password is hashed before saving for security.
                 */
                if (!string.IsNullOrWhiteSpace(txtNewPassword.Text))
                {
                    string passwordHash =
                        PasswordHasher.HashPassword(
                            txtNewPassword.Text.Trim());

                    profileRepository.UpdatePassword(
                        currentUserId,
                        passwordHash);

                    auditLogService.Log(
                        "Change Password",
                        "Customer Profile",
                        "Customer changed account password.");
                }

                MessageBox.Show("Profile updated successfully.");

                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Profile update failed: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlProfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}