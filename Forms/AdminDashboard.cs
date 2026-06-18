using System;
using System.Windows.Forms;
using SmartMedERP.Services;
using SmartMedERP.Utilities;

namespace SmartMed.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (SessionManager.CurrentUser != null)
            {
                lblLoggedUser.Text =
                    SessionManager.CurrentUser.Username;
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
        
                string hash = PasswordHasher.HashPassword("Admin@123");
                MessageBox.Show(hash);
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
                 SessionManager.CurrentUser = null;

            LoginForm login =
                new LoginForm();

            login.Show();

            this.Close();
        }
        
    }
}