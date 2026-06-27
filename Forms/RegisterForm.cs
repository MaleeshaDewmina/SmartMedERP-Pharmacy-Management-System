using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Services;

namespace SmartMed.Forms
{
    /*
     * Handles customer account registration.
     * This form validates customer input and sends registration data
     * to the CustomerService layer.
     */
    public partial class RegisterForm : Form
    {
        private readonly CustomerService customerService =
            new CustomerService();

        public RegisterForm()
        {
            InitializeComponent();
        }

        // Validates registration fields and creates a new customer account.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter full name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter phone number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                return;
            }

            // Basic password length validation before registration.
            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                /*
                 * CustomerService handles business logic such as password hashing
                 * and saving user/customer details into the database.
                 */
                customerService.RegisterCustomer(
                    txtFullName.Text.Trim(),
                    txtUsername.Text.Trim(),
                    txtEmail.Text.Trim(),
                    txtPhone.Text.Trim(),
                    txtAddress.Text.Trim(),
                    txtPassword.Text.Trim());

                MessageBox.Show("Registration successful. Please login now.");

                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Hide();
            }
            catch (SqlException ex)
            {
                /*
                 * SQL error numbers 2627 and 2601 usually occur when
                 * unique fields such as username or email already exist.
                 */
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Username or email already exists.");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message);
            }
        }

        // Returns the user to the login form.
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm =
                new LoginForm();

            loginForm.Show();

            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }
}