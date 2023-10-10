namespace LoginScreen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            pctUsername = new PictureBox();
            pctPassword = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            exitButton = new PictureBox();
            lblError = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 284);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(482, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Login";
            lblTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pctUsername
            // 
            pctUsername.Image = Properties.Resources.icons8_user_40;
            pctUsername.Location = new Point(103, 65);
            pctUsername.Name = "pctUsername";
            pctUsername.Size = new Size(40, 40);
            pctUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pctUsername.TabIndex = 2;
            pctUsername.TabStop = false;
            // 
            // pctPassword
            // 
            pctPassword.Image = Properties.Resources.icons8_password_40;
            pctPassword.Location = new Point(103, 135);
            pctPassword.Name = "pctPassword";
            pctPassword.Size = new Size(40, 40);
            pctPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pctPassword.TabIndex = 3;
            pctPassword.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Location = new Point(103, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(103, 181);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(103, 202);
            button1.Name = "button1";
            button1.Size = new Size(270, 42);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // exitButton
            // 
            exitButton.Image = Properties.Resources.icons8_cross_50;
            exitButton.Location = new Point(432, 0);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(50, 50);
            exitButton.SizeMode = PictureBoxSizeMode.Zoom;
            exitButton.TabIndex = 7;
            exitButton.TabStop = false;
            exitButton.Click += pictureBox2_Click;
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblError.ForeColor = Color.DarkRed;
            lblError.Location = new Point(103, 247);
            lblError.Name = "lblError";
            lblError.Size = new Size(270, 34);
            lblError.TabIndex = 8;
            lblError.Text = "This is an error";
            lblError.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(150, 68);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(223, 31);
            txtUsername.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(150, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "***********";
            txtPassword.Size = new Size(223, 31);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 453);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblError);
            Controls.Add(exitButton);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pctPassword);
            Controls.Add(pctUsername);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblTitle;
        private PictureBox pctUsername;
        private PictureBox pctPassword;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private PictureBox exitButton;
        private Label lblError;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}