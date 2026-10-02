using HotelReservation.App.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.App
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
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
    }
}
