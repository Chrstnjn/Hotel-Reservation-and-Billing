using HotelReservation.App.UI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.App.UI
{
    public partial class frmAdminManagement : Form
    {
        public frmAdminManagement()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmADash = new frmAdminDashboard();
            frmADash.Show();
            this.Hide();
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

        private void btnCreateRooms_Click(object sender, EventArgs e)
        {
            frmCreateRoom frmCreateR = new frmCreateRoom();
            frmCreateR.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            frmUpdateRoom frmUpdateR = new frmUpdateRoom();
            frmUpdateR.Show();
            this.Hide();
        }

        private void btnUpdateHrAccount_Click(object sender, EventArgs e)
        {
            frmUpdateHR frmUpdateHR = new frmUpdateHR();
            frmUpdateHR.Show();
            this.Hide();
        }

        private void btnDeleteHrAccount_Click(object sender, EventArgs e)
        {
            frmDeactHR frmDeact = new frmDeactHR();
            frmDeact.Show();
            this.Hide();
        }

        private void btnCreateHrAccount_Click(object sender, EventArgs e)
        {
            frmCreateHR frmAddHR = new frmCreateHR();
            frmAddHR.Show();
            this.Hide();
        }
    }
}
