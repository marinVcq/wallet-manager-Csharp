namespace ExpensesManagerV2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            buttonLogin = new Button();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            labelError = new Label();
            closeButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(516, 74);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_utilisateur_48;
            pictureBox1.Location = new Point(67, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(121, 155);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 3);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(121, 248);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 3);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_mot_de_passe_48;
            pictureBox2.Location = new Point(67, 203);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.FromArgb(28, 52, 116);
            buttonLogin.Location = new Point(121, 326);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(273, 52);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Se Connecter";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(28, 52, 116);
            textBoxUsername.BorderStyle = BorderStyle.None;
            textBoxUsername.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.ForeColor = Color.White;
            textBoxUsername.Location = new Point(121, 122);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username...";
            textBoxUsername.Size = new Size(273, 26);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(28, 52, 116);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(121, 216);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password...";
            textBoxPassword.Size = new Size(273, 26);
            textBoxPassword.TabIndex = 7;
            // 
            // labelError
            // 
            labelError.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.White;
            labelError.Location = new Point(121, 284);
            labelError.Name = "labelError";
            labelError.Size = new Size(273, 39);
            labelError.TabIndex = 8;
            labelError.TextAlign = ContentAlignment.MiddleLeft;
            labelError.Click += label2_Click;
            // 
            // closeButton
            // 
            closeButton.Cursor = Cursors.Hand;
            closeButton.Image = Properties.Resources.icons8_multiplier_50;
            closeButton.Location = new Point(466, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 50);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.TabIndex = 9;
            closeButton.TabStop = false;
            closeButton.Click += closeButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 52, 116);
            ClientSize = new Size(516, 459);
            Controls.Add(closeButton);
            Controls.Add(labelError);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogin);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)closeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button buttonLogin;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label labelError;
        private PictureBox closeButton;
    }
}