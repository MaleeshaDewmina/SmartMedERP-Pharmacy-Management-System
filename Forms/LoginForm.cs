using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SmartMedERP.Models;
using SmartMedERP.Services;
using SmartMedERP.Utilities;

namespace SmartMed.Forms
{
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

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

            SessionManager.CurrentUser =
                new UserSession
                {
                    UserId = user.UserId,
                    Username = user.Username,
                    RoleName = user.RoleName
                };

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

        private void button1_Click(object sender, EventArgs e)
        {
            string hash = PasswordHasher.HashPassword("Admin@123");

            using (SqlConnection con = SmartMedERP.Data.Database.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET PasswordHash = @Hash WHERE Username = @Username",
                    con);

                cmd.Parameters.AddWithValue("@Hash", hash);
                cmd.Parameters.AddWithValue("@Username", "admin");

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show("Password reset done. Rows updated: " + rows);
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}