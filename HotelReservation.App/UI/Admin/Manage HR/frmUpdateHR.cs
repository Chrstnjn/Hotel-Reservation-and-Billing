using HotelReservation.App.BusinessLogic.Controller;
using HotelReservation.App.Model;

namespace HotelReservation.App.UI
{
    public partial class frmUpdateHR : Form
    {
        public frmUpdateHR()
        {
            InitializeComponent();
        }

        private void frmUpdateHR_Load(object sender, EventArgs e)
        {
            ReceptionistAccountController controller =
  new ReceptionistAccountController();

            List<ReceptionistAccountModel> hrList =
            controller.GetAllHR();

            dgvUpdate.DataSource = hrList;

            cmbHRID.DataSource = hrList;
            cmbHRID.DisplayMember = "HRID";
            cmbHRID.ValueMember = "HRID";

            cmbHRID.SelectedIndex = -1;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbHRID.Text, out int hrid))
            {
                MessageBox.Show("Invalid HR ID.");
                return;
            }

            ReceptionistAccountModel hr =
            new ReceptionistAccountModel()
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

            ReceptionistAccountController controller =
            new ReceptionistAccountController();

            if (controller.UpdateHR(hr))
            {
                MessageBox.Show("HR Account Updated Successfully!");
            }
            else
            {
                MessageBox.Show("Update Failed.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbHRID.Text, out int hrid))
            {
                MessageBox.Show("Enter a valid HR ID.");
                return;
            }

            ReceptionistAccountController controller =
            new ReceptionistAccountController();

            ReceptionistAccountModel hr =
            controller.GetHRByID(hrid);

            if (hr == null)
            {
                MessageBox.Show("HR Account not found.");
                return;
            }

            txtFirstName.Text = hr.FirstName;
            txtLastName.Text = hr.LastName;
            txtMiddle.Text = hr.MiddleInitial;
            txtPhone.Text = hr.ContactNo;
            txtEmail.Text = hr.Email;
            txtUsername.Text = hr.Username;
            txtPassword.Text = hr.Password;
            dtpBirthDate.Value = hr.DateOfBirth;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            frmAdminManagement frmBoard = new frmAdminManagement();
            frmBoard.Show();
            this.Hide();
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

        private void cmbHRID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHRID.SelectedItem == null)
                return;

            ReceptionistAccountModel hr =
            (ReceptionistAccountModel)cmbHRID.SelectedItem;

            txtFirstName.Text = hr.FirstName;
            txtLastName.Text = hr.LastName;
            txtMiddle.Text = hr.MiddleInitial;
            txtPhone.Text = hr.ContactNo;
            txtEmail.Text = hr.Email;
            txtUsername.Text = hr.Username;
            txtPassword.Text = hr.Password;
            dtpBirthDate.Value = hr.DateOfBirth;
        }
    }
}
