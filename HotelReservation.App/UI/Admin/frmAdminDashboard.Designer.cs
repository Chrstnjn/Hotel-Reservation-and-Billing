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
            btnHome = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            btnHrDetails = new Button();
            btnTotalBooked = new Button();
            btnTotalRoom = new Button();
            txtSearch = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSearch = new Button();
            pictureBox5 = new PictureBox();
            dgvHR = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHR).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
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
            btnLogout.TabIndex = 8;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnMyAccount
            // 
            btnMyAccount.BackColor = Color.FromArgb(48, 91, 171);
            btnMyAccount.FlatStyle = FlatStyle.Popup;
            btnMyAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnManagement.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            btnHome.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = SystemColors.ControlLightLight;
            btnHome.Location = new Point(18, 43);
            btnHome.Margin = new Padding(3, 2, 3, 2);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(133, 26);
            btnHome.TabIndex = 5;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(215, 218, 224);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-5, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(805, 48);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 14);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 3;
            label1.Text = "Admin Dashboard";
            // 
            // btnHrDetails
            // 
            btnHrDetails.BackColor = Color.White;
            btnHrDetails.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHrDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnHrDetails.Location = new Point(183, 62);
            btnHrDetails.Margin = new Padding(3, 2, 3, 2);
            btnHrDetails.Name = "btnHrDetails";
            btnHrDetails.Size = new Size(197, 44);
            btnHrDetails.TabIndex = 6;
            btnHrDetails.UseVisualStyleBackColor = false;
            btnHrDetails.Click += btnHrDetails_Click;
            // 
            // btnTotalBooked
            // 
            btnTotalBooked.BackColor = Color.White;
            btnTotalBooked.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalBooked.ForeColor = SystemColors.ControlLightLight;
            btnTotalBooked.Location = new Point(592, 62);
            btnTotalBooked.Margin = new Padding(3, 2, 3, 2);
            btnTotalBooked.Name = "btnTotalBooked";
            btnTotalBooked.Size = new Size(197, 44);
            btnTotalBooked.TabIndex = 7;
            btnTotalBooked.UseVisualStyleBackColor = false;
            // 
            // btnTotalRoom
            // 
            btnTotalRoom.BackColor = Color.White;
            btnTotalRoom.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalRoom.ForeColor = SystemColors.ControlLightLight;
            btnTotalRoom.Location = new Point(390, 62);
            btnTotalRoom.Margin = new Padding(3, 2, 3, 2);
            btnTotalRoom.Name = "btnTotalRoom";
            btnTotalRoom.Size = new Size(197, 44);
            btnTotalRoom.TabIndex = 8;
            btnTotalRoom.UseVisualStyleBackColor = false;
            btnTotalRoom.Click += btnTotalRoom_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(470, 118);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 26);
            txtSearch.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.SizeNESW;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(186, 66);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Cursor = Cursors.SizeNESW;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(393, 66);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(46, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Cursor = Cursors.SizeNESW;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(595, 66);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 36);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Constantia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(102, 108, 130);
            label6.Location = new Point(233, 78);
            label6.Name = "label6";
            label6.Size = new Size(135, 13);
            label6.TabIndex = 17;
            label6.Text = "RESEPTIONIST DETAILS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Constantia", 7.8F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(102, 108, 130);
            label7.Location = new Point(440, 78);
            label7.Name = "label7";
            label7.Size = new Size(81, 13);
            label7.TabIndex = 18;
            label7.Text = "TOTAL ROOM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Constantia", 7.8F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(102, 108, 130);
            label8.Location = new Point(642, 78);
            label8.Name = "label8";
            label8.Size = new Size(94, 13);
            label8.TabIndex = 19;
            label8.Text = "TOTAL BOOKED";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(48, 91, 171);
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold);
            btnSearch.ForeColor = SystemColors.ButtonHighlight;
            btnSearch.ImageKey = "(none)";
            btnSearch.Location = new Point(714, 118);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 26);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "SEARCH";
            btnSearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Cursor = Cursors.SizeNESW;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(440, 118);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 26);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // dgvHR
            // 
            dgvHR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHR.Location = new Point(183, 164);
            dgvHR.Name = "dgvHR";
            dgvHR.Size = new Size(605, 274);
            dgvHR.TabIndex = 24;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHR);
            Controls.Add(pictureBox5);
            Controls.Add(btnSearch);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtSearch);
            Controls.Add(btnTotalRoom);
            Controls.Add(btnTotalBooked);
            Controls.Add(btnHrDetails);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnHome;
        private Button btnMyAccount;
        private Button btnManagement;
        private Label label2;
        private Button btnLogout;
        private ListBox lstOverview;
        private Button btnHrDetails;
        private Button btnTotalBooked;
        private Button btnTotalRoom;
        private TextBox txtSearch;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblHrDetails;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTotalRoom;
        private Label lblTotalBooked;
        private Button btnSearch;
        private PictureBox pictureBox5;
        private DataGridView dgvHR;
    }
}