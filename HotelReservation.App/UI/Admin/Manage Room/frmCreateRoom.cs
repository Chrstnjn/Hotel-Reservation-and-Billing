using HotelReservation.App.BusinessLogic.Controller;
using HotelReservation.App.Model;
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

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text) ||
            string.IsNullOrWhiteSpace(txtRoomType.Text) ||
            string.IsNullOrWhiteSpace(txtBedType.Text) ||
            string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            RoomController controller = new RoomController();

            if (string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Enter Room Number");
                return;
            }

            if (controller.RoomNumberExists(txtRoomNumber.Text))
            {
                MessageBox.Show(
                "Room Number already exists.",
                "Duplicate Room",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

                txtRoomNumber.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show(
                    "Price must contain digits only.",
                    "Invalid Price",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPrice.Focus();
                return;
            }

            Room room = new Room()
            {
                RoomNumber = txtRoomNumber.Text,
                RoomType = txtRoomType.Text,
                BedType = txtBedType.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Status = "Available"
            };

            if (controller.CreateRoom(room))
            {
                MessageBox.Show("Room Added Successfully!");

                txtRoomNumber.Clear();
                txtRoomType.Clear();
                txtBedType.Clear();
                txtPrice.Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add Room.");
            }
        }
    }
}
