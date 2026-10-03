using HotelReservation.App.BusinessLogic.Controller;

namespace HotelReservation.App.UI
{
    public partial class frmDeactHR : Form
    {
        public frmDeactHR()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            ReceptionistAccountController controller = new ReceptionistAccountController();

            dgvActive.DataSource =
            controller.SearchHR(txtHRID.Text.Trim());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmADash = new frmAdminDashboard();
            frmADash.Show();
            this.Hide();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            if (dgvActive.CurrentRow == null)
                return;

            int hrid =
            Convert.ToInt32(
            dgvActive.CurrentRow.Cells["HRID"].Value);

            if (MessageBox.Show(
            "Deactivate this account?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            == DialogResult.Yes)
            {
                ReceptionistAccountController controller =
                new ReceptionistAccountController();

                if (controller.DeactivateHR(hrid))
                {
                    MessageBox.Show(
                    "Account deactivated successfully.");

                    dgvActive.DataSource =
                    controller.GetAllHR();

                    dgvDeac.DataSource =
                    controller.GetDeactivatedHR();
                }
            }
        }

        private void frmDeactHR_Load(object sender, EventArgs e)
        {
            ReceptionistAccountController controller = new ReceptionistAccountController();

            dgvActive.DataSource = controller.GetAllHR();

            dgvDeac.DataSource = controller.GetDeactivatedHR();
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
