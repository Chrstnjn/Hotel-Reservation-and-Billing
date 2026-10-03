namespace HotelReservation.App.UI
{
    partial class frmUpdateHR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateHR));
            panel3 = new Panel();
            cmbHRID = new ComboBox();
            txtPassword = new TextBox();
            label14 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            dtpBirthDate = new DateTimePicker();
            label13 = new Label();
            txtEmail = new TextBox();
            label12 = new Label();
            txtMiddle = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label7 = new Label();
            txtPhone = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            dgvUpdate = new DataGridView();
            button1 = new Button();
            btnUpdate = new Button();
            panel4 = new Panel();
            btnLeave = new Button();
            label3 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnMyAccount = new Button();
            btnManagement = new Button();
            label2 = new Label();
            btnHome = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdate).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(cmbHRID);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtUsername);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtpBirthDate);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtMiddle);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtLastName);
            panel3.Controls.Add(txtFirstName);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dgvUpdate);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(191, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(588, 338);
            panel3.TabIndex = 117;
            // 
            // cmbHRID
            // 
            cmbHRID.FormattingEnabled = true;
            cmbHRID.Location = new Point(71, 70);
            cmbHRID.Name = "cmbHRID";
            cmbHRID.Size = new Size(162, 23);
            cmbHRID.TabIndex = 99;
            cmbHRID.SelectedIndexChanged += cmbHRID_SelectedIndexChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(337, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 25);
            txtPassword.TabIndex = 98;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(64, 64, 64);
            label14.Location = new Point(243, 178);
            label14.Name = "label14";
            label14.Size = new Size(91, 20);
            label14.TabIndex = 97;
            label14.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(100, 173);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(133, 25);
            txtUsername.TabIndex = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(1, 178);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 95;
            label8.Text = "Username:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(363, 139);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(204, 23);
            dtpBirthDate.TabIndex = 94;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(243, 142);
            label13.Name = "label13";
            label13.Size = new Size(114, 20);
            label13.TabIndex = 93;
            label13.Text = "Date of Birth:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(337, 68);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 25);
            txtEmail.TabIndex = 92;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(273, 73);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 91;
            label12.Text = "Email:";
            // 
            // txtMiddle
            // 
            txtMiddle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddle.Location = new Point(516, 102);
            txtMiddle.Name = "txtMiddle";
            txtMiddle.Size = new Size(51, 25);
            txtMiddle.TabIndex = 90;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(470, 108);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 89;
            label11.Text = "M.I.:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(239, 107);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 88;
            label10.Text = "Last Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(64, 64, 64);
            label7.Location = new Point(6, 141);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 87;
            label7.Text = "Number:";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(85, 136);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(148, 25);
            txtPhone.TabIndex = 86;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(337, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(127, 25);
            txtLastName.TabIndex = 85;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(106, 102);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(127, 25);
            txtFirstName.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(6, 108);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 83;
            label6.Text = "First Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(10, 73);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 82;
            label4.Text = "HRID:";
            // 
            // dgvUpdate
            // 
            dgvUpdate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpdate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpdate.Location = new Point(0, 226);
            dgvUpdate.Name = "dgvUpdate";
            dgvUpdate.Size = new Size(588, 112);
            dgvUpdate.TabIndex = 75;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 91, 171);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(418, 202);
            button1.Name = "button1";
            button1.Size = new Size(74, 22);
            button1.TabIndex = 74;
            button1.Text = "REFRESH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(498, 202);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(76, 22);
            btnUpdate.TabIndex = 72;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(19, 52, 113);
            panel4.Controls.Add(btnLeave);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(588, 63);
            panel4.TabIndex = 0;
            // 
            // btnLeave
            // 
            btnLeave.BackColor = Color.Brown;
            btnLeave.FlatStyle = FlatStyle.Popup;
            btnLeave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeave.ForeColor = SystemColors.ControlLightLight;
            btnLeave.Location = new Point(550, 12);
            btnLeave.Name = "btnLeave";
            btnLeave.Size = new Size(24, 23);
            btnLeave.TabIndex = 66;
            btnLeave.Text = "X";
            btnLeave.UseVisualStyleBackColor = false;
            btnLeave.Click += btnLeave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(102, 22);
            label3.Name = "label3";
            label3.Size = new Size(385, 25);
            label3.TabIndex = 65;
            label3.Text = "INPUT DETAILS YOU WANT TO UPDATE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(176, 176, 176);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(169, 47);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(631, 24);
            panel5.TabIndex = 116;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(5, 5);
            label5.Name = "label5";
            label5.Size = new Size(216, 28);
            label5.TabIndex = 64;
            label5.Text = "HOTEL RECEPTIONIST MANAGEMENT\r\n\r\n";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 218, 224);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-5, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 48);
            panel2.TabIndex = 115;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 14);
            label1.Name = "label1";
            label1.Size = new Size(193, 23);
            label1.TabIndex = 3;
            label1.Text = "Admin Management";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, -2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMyAccount);
            panel1.Controls.Add(btnManagement);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(1, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 405);
            panel1.TabIndex = 114;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(213, 64, 64);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(46, 372);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(76, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyAccount
            // 
            btnMyAccount.BackColor = Color.FromArgb(48, 91, 171);
            btnMyAccount.FlatStyle = FlatStyle.Popup;
            btnMyAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold);
            btnMyAccount.ForeColor = SystemColors.ControlLightLight;
            btnMyAccount.Location = new Point(18, 118);
            btnMyAccount.Margin = new Padding(3, 2, 3, 2);
            btnMyAccount.Name = "btnMyAccount";
            btnMyAccount.Size = new Size(133, 26);
            btnMyAccount.TabIndex = 6;
            btnMyAccount.Text = "MY ACCOUNT";
            btnMyAccount.UseVisualStyleBackColor = false;
            // 
            // btnManagement
            // 
            btnManagement.BackColor = Color.FromArgb(48, 91, 171);
            btnManagement.FlatStyle = FlatStyle.Popup;
            btnManagement.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold);
            btnManagement.ForeColor = SystemColors.ControlLightLight;
            btnManagement.Location = new Point(18, 80);
            btnManagement.Margin = new Padding(3, 2, 3, 2);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(133, 26);
            btnManagement.TabIndex = 7;
            btnManagement.Text = "MANAGEMENT";
            btnManagement.UseVisualStyleBackColor = false;
            btnManagement.Click += btnManagement_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(10, 16);
            label2.Name = "label2";
            label2.Size = new Size(65, 13);
            label2.TabIndex = 6;
            label2.Text = "Navigation";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(48, 91, 171);
            btnHome.FlatStyle = FlatStyle.Popup;
            btnHome.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(18, 43);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(133, 26);
            btnHome.TabIndex = 5;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // frmUpdateHR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmUpdateHR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Management Page";
            Load += frmUpdateHR_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpdate).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dgvUpdate;
        private Button button1;
        private Button btnUpdate;
        private Panel panel4;
        private Button btnLeave;
        private Label label3;
        private Panel panel5;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLogout;
        private Button btnMyAccount;
        private Button btnManagement;
        private Label label2;
        private Button btnHome;
        private DateTimePicker dtpBirthDate;
        private Label label13;
        private TextBox txtEmail;
        private Label label12;
        private TextBox txtMiddle;
        private Label label11;
        private Label label10;
        private Label label7;
        private TextBox txtPhone;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label4;
        private TextBox txtPassword;
        private Label label14;
        private TextBox txtUsername;
        private Label label8;
        private ComboBox cmbHRID;
    }
}