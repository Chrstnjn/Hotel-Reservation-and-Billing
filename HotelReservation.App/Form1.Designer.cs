namespace HotelReservation.App
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnSignin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(200, 209, 217);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnSignin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtLogin);
            panel1.Location = new Point(224, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 514);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(63, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.FromArgb(28, 100, 236);
            btnSignin.FlatStyle = FlatStyle.Popup;
            btnSignin.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignin.ForeColor = SystemColors.ControlLightLight;
            btnSignin.Location = new Point(163, 436);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(154, 44);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "SIGNIN";
            btnSignin.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 337);
            label2.Name = "label2";
            label2.Size = new Size(100, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 257);
            label1.Name = "label1";
            label1.Size = new Size(65, 24);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(63, 364);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(357, 39);
            txtPassword.TabIndex = 1;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLogin.Location = new Point(63, 284);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(357, 39);
            txtLogin.TabIndex = 0;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 69, 115);
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            Text = "Login Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLogin;
        private PictureBox pictureBox1;
        private Button btnSignin;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
    }
}
