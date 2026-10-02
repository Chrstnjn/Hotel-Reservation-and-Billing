using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.App.UI.Admin
{
    public partial class frmCreateRoom : Form
    {
        public frmCreateRoom()
        {
            InitializeComponent();
        }

        private void frmCreateRooms_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmADash = new frmAdminDashboard();
            frmADash.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
            this.Hide();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
            "Are you sure you want to logout?",
            "Logout Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
