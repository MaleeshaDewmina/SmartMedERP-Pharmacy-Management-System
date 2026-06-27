using System;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Handles user login for the SmartMed ERP system.
     * This form validates login input, authenticates users,
     * creates the active session and redirects users based on role.
     */
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pnlBrand_Paint(object sender, PaintEventArgs e)
        {

        }

        // Validates login details and authenticates the user.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username =
                txtUsername.Text.Trim();

            string password =
                txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter username.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            AuthenticationService auth =
                new AuthenticationService();

            User user =
                auth.Login(username, password);

            if (user == null)
            {
                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            /*
             * Store logged-in user details in SessionManager.
             * Other forms use this session to check user ID, username and role.
             */
            SessionManager.CurrentUser =
                new UserSession
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    RoleName = user.RoleName
                };

            AuditLogService auditLogService =
                new AuditLogService();

            auditLogService.Log(
                "Login",
                "Authentication",
                "User logged in successfully.");

            MessageBox.Show(
                "Login Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            OpenDashboard(user.RoleName);
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        // Opens the correct dashboard based on the logged-in user's role.
        private void OpenDashboard(string role)
        {
            this.Hide();

            switch (role)
            {
                case "SuperAdmin":
                case "Admin":

                    AdminDashboard admin =
                        new AdminDashboard();

                    admin.Show();

                    break;

                case "Customer":

                    CustomerDashboard customer =
                        new CustomerDashboard();

                    customer.Show();

                    break;

                default:

                    MessageBox.Show(
                        "Role not implemented yet.");

                    this.Show();

                    break;
            }
        }

        /*
         * This event is kept to avoid designer errors if the button still exists.
         * The previous hardcoded admin password reset code was removed for security.
         */
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This development function has been disabled.");
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        // Opens the customer registration form.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm();

            registerForm.Show();

            this.Hide();
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}