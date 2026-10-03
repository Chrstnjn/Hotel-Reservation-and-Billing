using HotelReservation.App.BusinessLogic.Controller;
using HotelReservation.App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelReservation.App.UI
{
    public partial class frmCreateHR : Form
    {
        public frmCreateHR()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHRID.Text) ||
          string.IsNullOrWhiteSpace(txtFirstName.Text) ||
          string.IsNullOrWhiteSpace(txtLastName.Text) ||
          string.IsNullOrWhiteSpace(txtEmail.Text) ||
          string.IsNullOrWhiteSpace(txtUsername.Text) ||
          string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(txtHRID.Text, out int hrid))
            {
                MessageBox.Show("HR ID must contain digits only.");
                return;
            }

            if (txtPhone.Text.Length != 11 ||
               !txtPhone.Text.StartsWith("09") ||
               !txtPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Phone number must be 11 digits and start with 09.");

                txtPhone.Focus();
                return;
            }

            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show(
                    "Please enter a valid Gmail address.");

                txtEmail.Focus();
                return;
            }

            if (!int.TryParse(txtHRID.Text, out int HRID))
            {
                MessageBox.Show("HR ID must contain digits only.");
                return;
            }

            ReceptionistAccountController controller = new ReceptionistAccountController();

            ReceptionistAccountModel hr = new ReceptionistAccountModel()
            {
                HRID = hrid,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MiddleInitial = txtMiddle.Text,
                ContactNo = txtPhone.Text,
                DateOfBirth = dtpBirthDate.Value,
                Email = txtEmail.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            if (controller.EmailExists(txtEmail.Text))
            {
                MessageBox.Show(
                    "Email already exists.");

                txtEmail.Focus();
                return;
            }

            if (controller.UsernameExists(txtUsername.Text))
            {
                MessageBox.Show(
                    "Username already exists.");

                txtUsername.Focus();
                return;
            }

            if (controller.HRIDExists(hrid))
            {
                MessageBox.Show("HR ID already exists.");

                txtHRID.Focus();
                return;
            }

            if (controller.CreateHR(hr))
            {
                MessageBox.Show("HR Account Created Successfully!");

                txtHRID.Clear();
                txtFirstName.Clear();
                txtLastName.Clear();
                txtMiddle.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Failed to Create HR Account.");
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
            !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        private void btnLeave_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
            this.Hide();
        }
    }
}