using HotelReservation.App.BusinessLogic.Controller;
using HotelReservation.App.Model;

namespace HotelReservation.App
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();
            UserModel user = controller.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    frmAdminDashboard adminForm = new frmAdminDashboard();
                    adminForm.Show();
                }
                else if (user.Role == "Receptionist")
                {
                    frmReceptionistDashboard recepForm = new frmReceptionistDashboard();
                    recepForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}

