using HotelReservation.App.BusinessLogic.Controller;
using HotelReservation.App.Model;

namespace HotelReservation.App.UI
{
    public partial class frmUpdateRoom : Form
    {
        public frmUpdateRoom()
        {
            InitializeComponent();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmADash = new frmAdminDashboard();
            frmADash.Show();
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

        private void btnManagement_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Price must contain digits only.");
                return;
            }

            RoomController controller = new RoomController();

            Room room = new Room()
            {
                RoomNumber = cmbRoomNumber.Text,
                RoomType = txtRoomType.Text,
                BedType = txtBedType.Text,
                Price = price
            };

            if (controller.UpdateRoom(room))
            {
                MessageBox.Show(
                "Room updated successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                "Update failed.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void frmUpdateHR_Load(object sender, EventArgs e)
        {
            RoomController controller = new RoomController();

            List<Room> rooms = controller.GetRooms();

            cmbRoomNumber.DataSource = rooms;
            cmbRoomNumber.DisplayMember = "RoomNumber";
            cmbRoomNumber.ValueMember = "RoomNumber";
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RoomController controller = new RoomController();

            dgvRoomUpdate.DataSource = controller.GetRooms();
        }

        private void cmbRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNumber.SelectedItem is Room room)
            {
                txtRoomType.Text = room.RoomType;
                txtBedType.Text = room.BedType;
                txtPrice.Text = room.Price.ToString();
            }
        }

        private void frmUpdateRoom_Load(object sender, EventArgs e)
        {
            RoomController controller = new RoomController();

            List<Room> rooms = controller.GetRooms();

            cmbRoomNumber.DataSource = rooms;
            cmbRoomNumber.DisplayMember = "RoomNumber";
            cmbRoomNumber.ValueMember = "RoomNumber";
        }
    }
}

