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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}