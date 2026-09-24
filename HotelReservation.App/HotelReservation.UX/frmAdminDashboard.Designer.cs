namespace HotelReservation.App
{
    partial class frmAdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminDashboard));
            panel1 = new Panel();
            btnLogout = new Button();
            btnMyAccount = new Button();
            btnManagement = new Button();
            label2 = new Label();
            btnDashboard = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 52, 113);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnMyAccount);
            panel1.Controls.Add(btnManagement);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 540);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(213, 64, 64);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Location = new Point(52, 501);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(87, 25);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnMyAccount
            // 
            btnMyAccount.BackColor = Color.FromArgb(48, 91, 171);
            btnMyAccount.FlatStyle = FlatStyle.Popup;
            btnMyAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMyAccount.ForeColor = SystemColors.ControlLightLight;
            btnMyAccount.Location = new Point(20, 158);
            btnMyAccount.Name = "btnMyAccount";
            btnMyAccount.Size = new Size(152, 35);
            btnMyAccount.TabIndex = 6;
            btnMyAccount.Text = "MY ACCOUNT";
            btnMyAccount.UseVisualStyleBackColor = false;
            // 
            // btnManagement
            // 
            btnManagement.BackColor = Color.FromArgb(48, 91, 171);
            btnManagement.FlatStyle = FlatStyle.Popup;
            btnManagement.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagement.ForeColor = SystemColors.ControlLightLight;
            btnManagement.Location = new Point(20, 107);
            btnManagement.Name = "btnManagement";
            btnManagement.Size = new Size(152, 35);
            btnManagement.TabIndex = 7;
            btnManagement.Text = "MANAGEMENT";
            btnManagement.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(101, 138, 208);
            label2.Location = new Point(11, 21);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 6;
            label2.Text = "Navigation";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(48, 91, 171);
            btnDashboard.FlatStyle = FlatStyle.Popup;
            btnDashboard.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = SystemColors.ControlLightLight;
            btnDashboard.Location = new Point(20, 57);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(152, 35);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "DASHBOARD";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(3, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 218, 224);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-6, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 64);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 18);
            label1.Name = "label1";
            label1.Size = new Size(212, 28);
            label1.TabIndex = 3;
            label1.Text = "Admin Dashboard";
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnDashboard;
        private Button btnMyAccount;
        private Button btnManagement;
        private Label label2;
        private Button btnLogout;
    }
}