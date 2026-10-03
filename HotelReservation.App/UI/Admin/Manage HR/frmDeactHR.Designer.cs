namespace HotelReservation.App.UI
{
    partial class frmDeactHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeactHR));
            panel3 = new Panel();
            dgvDeac = new DataGridView();
            label4 = new Label();
            dgvActive = new DataGridView();
            txtHRID = new TextBox();
            btnDeactivate = new Button();
            btnFind = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvDeac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvActive).BeginInit();
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
            panel3.Controls.Add(dgvDeac);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dgvActive);
            panel3.Controls.Add(txtHRID);
            panel3.Controls.Add(btnDeactivate);
            panel3.Controls.Add(btnFind);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(191, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(588, 338);
            panel3.TabIndex = 121;
            // 
            // dgvDeac
            // 
            dgvDeac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDeac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeac.Location = new Point(0, 236);
            dgvDeac.Name = "dgvDeac";
            dgvDeac.Size = new Size(588, 102);
            dgvDeac.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(19, 52, 113);
            label4.Location = new Point(2, 213);
            label4.Name = "label4";
            label4.Size = new Size(323, 25);
            label4.TabIndex = 94;
            label4.Text = "DEACTIVATE ACCOUNT HISTORY";
            // 
            // dgvActive
            // 
            dgvActive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvActive.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActive.Location = new Point(0, 95);
            dgvActive.Name = "dgvActive";
            dgvActive.Size = new Size(588, 102);
            dgvActive.TabIndex = 93;
            // 
            // txtHRID
            // 
            txtHRID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHRID.Location = new Point(333, 68);
            txtHRID.Name = "txtHRID";
            txtHRID.Size = new Size(166, 25);
            txtHRID.TabIndex = 92;
            // 
            // btnDeactivate
            // 
            btnDeactivate.BackColor = Color.FromArgb(192, 0, 0);
            btnDeactivate.FlatStyle = FlatStyle.Flat;
            btnDeactivate.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeactivate.ForeColor = SystemColors.ButtonHighlight;
            btnDeactivate.Location = new Point(477, 203);
            btnDeactivate.Name = "btnDeactivate";
            btnDeactivate.Size = new Size(106, 27);
            btnDeactivate.TabIndex = 74;
            btnDeactivate.Text = "DEACTIVATE";
            btnDeactivate.UseVisualStyleBackColor = false;
            btnDeactivate.Click += btnDeactivate_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Teal;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = SystemColors.ButtonHighlight;
            btnFind.Location = new Point(505, 71);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(76, 22);
            btnFind.TabIndex = 72;
            btnFind.Text = "FIND";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
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
            label3.Location = new Point(61, 22);
            label3.Name = "label3";
            label3.Size = new Size(459, 25);
            label3.TabIndex = 65;
            label3.Text = "CHOOSE ACCOUNT YOU WANT TO DEACTIVATE";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(176, 176, 176);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(169, 47);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(631, 24);
            panel5.TabIndex = 120;
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
            panel2.TabIndex = 119;
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
            panel1.TabIndex = 118;
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
            // frmDeactHR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmDeactHR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Management Page";
            Load += frmDeactHR_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeac).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvActive).EndInit();
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
        private TextBox txtHRID;
        private DataGridView dgvDeac;
        private Button btnDeactivate;
        private Button btnFind;
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
        private Label label4;
        private DataGridView dgvActive;
    }
}