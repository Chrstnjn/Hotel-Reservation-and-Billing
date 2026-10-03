namespace HotelReservation.App.UI
{
    partial class frmAdminManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminManagement));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnLogout = new Button();
            btnMyAccount = new Button();
            btnManagement = new Button();
            label2 = new Label();
            btnHome = new Button();
            label12 = new Label();
            label13 = new Label();
            pictureBox4 = new PictureBox();
            btnCreateRooms = new Button();
            panel5 = new Panel();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            btnUpdateRoom = new Button();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            btnCreateHrAccount = new Button();
            panel3 = new Panel();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            btnUpdateHrAccount = new Button();
            label11 = new Label();
            label14 = new Label();
            pictureBox6 = new PictureBox();
            btnDeleteHrAccount = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 5;
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
            panel1.TabIndex = 4;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(102, 108, 130);
            label12.Location = new Point(238, 119);
            label12.Name = "label12";
            label12.Size = new Size(94, 12);
            label12.TabIndex = 109;
            label12.Text = "Creating new room";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.White;
            label13.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(102, 108, 130);
            label13.Location = new Point(236, 100);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 108;
            label13.Text = "CREATE ROOMS";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Cursor = Cursors.SizeNESW;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = (Image)resources.GetObject("pictureBox4.InitialImage");
            pictureBox4.Location = new Point(176, 90);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 107;
            pictureBox4.TabStop = false;
            // 
            // btnCreateRooms
            // 
            btnCreateRooms.BackColor = Color.White;
            btnCreateRooms.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateRooms.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateRooms.Location = new Point(172, 80);
            btnCreateRooms.Margin = new Padding(3, 2, 3, 2);
            btnCreateRooms.Name = "btnCreateRooms";
            btnCreateRooms.Size = new Size(204, 74);
            btnCreateRooms.TabIndex = 106;
            btnCreateRooms.UseVisualStyleBackColor = false;
            btnCreateRooms.Click += btnCreateRooms_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(176, 176, 176);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(169, 47);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(631, 24);
            panel5.TabIndex = 105;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(5, 5);
            label5.Name = "label5";
            label5.Size = new Size(169, 14);
            label5.TabIndex = 64;
            label5.Text = "ROOM BOARD MANAGEMENT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(102, 108, 130);
            label3.Location = new Point(449, 119);
            label3.Name = "label3";
            label3.Size = new Size(75, 12);
            label3.TabIndex = 113;
            label3.Text = "Updating room";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Constantia", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(102, 108, 130);
            label4.Location = new Point(446, 100);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 112;
            label4.Text = "UPDATE ROOM";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Cursor = Cursors.SizeNESW;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(386, 90);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 111;
            pictureBox2.TabStop = false;
            // 
            // btnUpdateRoom
            // 
            btnUpdateRoom.BackColor = Color.White;
            btnUpdateRoom.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRoom.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateRoom.Location = new Point(382, 80);
            btnUpdateRoom.Margin = new Padding(3, 2, 3, 2);
            btnUpdateRoom.Name = "btnUpdateRoom";
            btnUpdateRoom.Size = new Size(204, 74);
            btnUpdateRoom.TabIndex = 110;
            btnUpdateRoom.UseVisualStyleBackColor = false;
            btnUpdateRoom.Click += btnUpdateRoom_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(102, 108, 130);
            label6.Location = new Point(239, 235);
            label6.Name = "label6";
            label6.Size = new Size(100, 12);
            label6.TabIndex = 117;
            label6.Text = "Creating HR account";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(102, 108, 130);
            label7.Location = new Point(236, 216);
            label7.Name = "label7";
            label7.Size = new Size(134, 14);
            label7.TabIndex = 116;
            label7.Text = "CREATE HR ACCOUNT";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Cursor = Cursors.SizeNESW;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(176, 206);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 115;
            pictureBox3.TabStop = false;
            // 
            // btnCreateHrAccount
            // 
            btnCreateHrAccount.BackColor = Color.White;
            btnCreateHrAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateHrAccount.ForeColor = SystemColors.ActiveCaptionText;
            btnCreateHrAccount.Location = new Point(172, 196);
            btnCreateHrAccount.Margin = new Padding(3, 2, 3, 2);
            btnCreateHrAccount.Name = "btnCreateHrAccount";
            btnCreateHrAccount.Size = new Size(204, 74);
            btnCreateHrAccount.TabIndex = 114;
            btnCreateHrAccount.UseVisualStyleBackColor = false;
            btnCreateHrAccount.Click += btnCreateHrAccount_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(176, 176, 176);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(169, 164);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(631, 24);
            panel3.TabIndex = 118;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 9F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(64, 64, 64);
            label8.Location = new Point(5, 5);
            label8.Name = "label8";
            label8.Size = new Size(216, 14);
            label8.TabIndex = 64;
            label8.Text = "HOTEL RECEPTIONIST MANAGEMENT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(102, 108, 130);
            label9.Location = new Point(449, 235);
            label9.Name = "label9";
            label9.Size = new Size(103, 12);
            label9.TabIndex = 122;
            label9.Text = "Updating HR account";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(102, 108, 130);
            label10.Location = new Point(444, 216);
            label10.Name = "label10";
            label10.Size = new Size(137, 14);
            label10.TabIndex = 121;
            label10.Text = "UPDATE HR ACCOUNT";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Cursor = Cursors.SizeNESW;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = (Image)resources.GetObject("pictureBox5.InitialImage");
            pictureBox5.Location = new Point(386, 206);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 120;
            pictureBox5.TabStop = false;
            // 
            // btnUpdateHrAccount
            // 
            btnUpdateHrAccount.BackColor = Color.White;
            btnUpdateHrAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateHrAccount.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdateHrAccount.Location = new Point(382, 196);
            btnUpdateHrAccount.Margin = new Padding(3, 2, 3, 2);
            btnUpdateHrAccount.Name = "btnUpdateHrAccount";
            btnUpdateHrAccount.Size = new Size(204, 74);
            btnUpdateHrAccount.TabIndex = 119;
            btnUpdateHrAccount.UseVisualStyleBackColor = false;
            btnUpdateHrAccount.Click += btnUpdateHrAccount_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Cambria", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(102, 108, 130);
            label11.Location = new Point(659, 236);
            label11.Name = "label11";
            label11.Size = new Size(119, 12);
            label11.TabIndex = 126;
            label11.Text = "Deactivating HR account";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.White;
            label14.Font = new Font("Constantia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(102, 108, 130);
            label14.Location = new Point(656, 217);
            label14.Name = "label14";
            label14.Size = new Size(79, 14);
            label14.TabIndex = 125;
            label14.Text = "DEACTIVATE";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Cursor = Cursors.SizeNESW;
            pictureBox6.ErrorImage = null;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = (Image)resources.GetObject("pictureBox6.InitialImage");
            pictureBox6.Location = new Point(596, 207);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 124;
            pictureBox6.TabStop = false;
            // 
            // btnDeleteHrAccount
            // 
            btnDeleteHrAccount.BackColor = Color.White;
            btnDeleteHrAccount.Font = new Font("Franklin Gothic Book", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteHrAccount.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteHrAccount.Location = new Point(592, 197);
            btnDeleteHrAccount.Margin = new Padding(3, 2, 3, 2);
            btnDeleteHrAccount.Name = "btnDeleteHrAccount";
            btnDeleteHrAccount.Size = new Size(204, 74);
            btnDeleteHrAccount.TabIndex = 123;
            btnDeleteHrAccount.UseVisualStyleBackColor = false;
            btnDeleteHrAccount.Click += btnDeleteHrAccount_Click;
            // 
            // frmAdminManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label11);
            Controls.Add(label14);
            Controls.Add(pictureBox6);
            Controls.Add(btnDeleteHrAccount);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(pictureBox5);
            Controls.Add(btnUpdateHrAccount);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox3);
            Controls.Add(btnCreateHrAccount);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(btnUpdateRoom);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(pictureBox4);
            Controls.Add(btnCreateRooms);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmAdminManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdminManagement";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnLogout;
        private Button btnMyAccount;
        private Button btnManagement;
        private Label label2;
        private Button btnHome;
        private Label label12;
        private Label label13;
        private PictureBox pictureBox4;
        private Button btnCreateRooms;
        private Panel panel5;
        private Label label5;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Button btnUpdateRoom;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Button btnCreateHrAccount;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private Button btnUpdateHrAccount;
        private Label label11;
        private Label label14;
        private PictureBox pictureBox6;
        private Button btnDeleteHrAccount;
    }
}