namespace ExpensesManagerV2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            navbarPanel = new Panel();
            navbarTitle = new Label();
            burgerBtn = new PictureBox();
            menuPanel = new Panel();
            versionLabel = new Label();
            slidePanel = new Panel();
            settingsLink = new Button();
            graphicsLink = new Button();
            dashboardLink = new Button();
            homeLink = new Button();
            mainPanel = new Panel();
            panel1 = new Panel();
            navbarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)burgerBtn).BeginInit();
            menuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navbarPanel
            // 
            navbarPanel.BackColor = Color.FromArgb(28, 52, 116);
            navbarPanel.Controls.Add(navbarTitle);
            navbarPanel.Controls.Add(burgerBtn);
            navbarPanel.Dock = DockStyle.Top;
            navbarPanel.Location = new Point(0, 0);
            navbarPanel.Name = "navbarPanel";
            navbarPanel.Size = new Size(1382, 69);
            navbarPanel.TabIndex = 0;
            // 
            // navbarTitle
            // 
            navbarTitle.BackColor = Color.Transparent;
            navbarTitle.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            navbarTitle.ForeColor = Color.White;
            navbarTitle.Location = new Point(103, 0);
            navbarTitle.Name = "navbarTitle";
            navbarTitle.Size = new Size(306, 69);
            navbarTitle.TabIndex = 1;
            navbarTitle.Text = "Home";
            navbarTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // burgerBtn
            // 
            burgerBtn.BackColor = Color.FromArgb(30, 52, 116);
            burgerBtn.Cursor = Cursors.Hand;
            burgerBtn.Image = Properties.Resources.icons8_menu_50;
            burgerBtn.Location = new Point(38, 12);
            burgerBtn.Name = "burgerBtn";
            burgerBtn.Size = new Size(50, 51);
            burgerBtn.SizeMode = PictureBoxSizeMode.Zoom;
            burgerBtn.TabIndex = 0;
            burgerBtn.TabStop = false;
            burgerBtn.Click += burgerBtn_Click;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = Color.WhiteSmoke;
            menuPanel.Controls.Add(versionLabel);
            menuPanel.Controls.Add(slidePanel);
            menuPanel.Controls.Add(settingsLink);
            menuPanel.Controls.Add(graphicsLink);
            menuPanel.Controls.Add(dashboardLink);
            menuPanel.Controls.Add(homeLink);
            menuPanel.Controls.Add(panel1);
            menuPanel.Cursor = Cursors.Hand;
            menuPanel.Dock = DockStyle.Left;
            menuPanel.Location = new Point(0, 69);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(304, 820);
            menuPanel.TabIndex = 1;
            // 
            // versionLabel
            // 
            versionLabel.Dock = DockStyle.Bottom;
            versionLabel.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            versionLabel.ForeColor = Color.FromArgb(28, 52, 116);
            versionLabel.Location = new Point(0, 790);
            versionLabel.Name = "versionLabel";
            versionLabel.Padding = new Padding(30, 0, 30, 0);
            versionLabel.Size = new Size(304, 30);
            versionLabel.TabIndex = 7;
            versionLabel.Text = "Version 2.0";
            versionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // slidePanel
            // 
            slidePanel.BackColor = Color.FromArgb(28, 52, 116);
            slidePanel.Location = new Point(3, 109);
            slidePanel.Name = "slidePanel";
            slidePanel.Size = new Size(10, 69);
            slidePanel.TabIndex = 2;
            // 
            // settingsLink
            // 
            settingsLink.Dock = DockStyle.Top;
            settingsLink.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            settingsLink.ForeColor = Color.FromArgb(28, 52, 116);
            settingsLink.Image = Properties.Resources.icons8_paramètres_50;
            settingsLink.ImageAlign = ContentAlignment.MiddleLeft;
            settingsLink.Location = new Point(0, 316);
            settingsLink.Name = "settingsLink";
            settingsLink.Padding = new Padding(30, 0, 0, 0);
            settingsLink.Size = new Size(304, 69);
            settingsLink.TabIndex = 6;
            settingsLink.Text = "   Settings";
            settingsLink.TextAlign = ContentAlignment.MiddleLeft;
            settingsLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsLink.UseVisualStyleBackColor = true;
            // 
            // graphicsLink
            // 
            graphicsLink.Dock = DockStyle.Top;
            graphicsLink.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            graphicsLink.ForeColor = Color.FromArgb(28, 52, 116);
            graphicsLink.Image = Properties.Resources.icons8_panneau_de_contrôle_50;
            graphicsLink.ImageAlign = ContentAlignment.MiddleLeft;
            graphicsLink.Location = new Point(0, 247);
            graphicsLink.Name = "graphicsLink";
            graphicsLink.Padding = new Padding(30, 0, 0, 0);
            graphicsLink.Size = new Size(304, 69);
            graphicsLink.TabIndex = 5;
            graphicsLink.Text = "   Graphics";
            graphicsLink.TextAlign = ContentAlignment.MiddleLeft;
            graphicsLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            graphicsLink.UseVisualStyleBackColor = true;
            // 
            // dashboardLink
            // 
            dashboardLink.Dock = DockStyle.Top;
            dashboardLink.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardLink.ForeColor = Color.FromArgb(28, 52, 116);
            dashboardLink.Image = Properties.Resources.icons8_tableau_de_bord_50;
            dashboardLink.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardLink.Location = new Point(0, 178);
            dashboardLink.Name = "dashboardLink";
            dashboardLink.Padding = new Padding(30, 0, 0, 0);
            dashboardLink.Size = new Size(304, 69);
            dashboardLink.TabIndex = 4;
            dashboardLink.Text = "   Dashboard";
            dashboardLink.TextAlign = ContentAlignment.MiddleLeft;
            dashboardLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardLink.UseVisualStyleBackColor = true;
            // 
            // homeLink
            // 
            homeLink.Dock = DockStyle.Top;
            homeLink.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            homeLink.ForeColor = Color.FromArgb(28, 52, 116);
            homeLink.Image = Properties.Resources.icons8_accueil_50;
            homeLink.ImageAlign = ContentAlignment.MiddleLeft;
            homeLink.Location = new Point(0, 109);
            homeLink.Name = "homeLink";
            homeLink.Padding = new Padding(30, 0, 0, 0);
            homeLink.Size = new Size(304, 69);
            homeLink.TabIndex = 3;
            homeLink.Text = "   Home";
            homeLink.TextAlign = ContentAlignment.MiddleLeft;
            homeLink.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeLink.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(304, 69);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1078, 820);
            mainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 109);
            panel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1382, 889);
            Controls.Add(mainPanel);
            Controls.Add(menuPanel);
            Controls.Add(navbarPanel);
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            SizeChanged += MainForm_SizeChanged;
            navbarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)burgerBtn).EndInit();
            menuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel navbarPanel;
        private PictureBox burgerBtn;
        private Label navbarTitle;
        private Panel menuPanel;
        protected Button settingsLink;
        protected Button graphicsLink;
        protected Button dashboardLink;
        protected Button homeLink;
        private Panel slidePanel;
        private Panel mainPanel;
        private Label versionLabel;
        private Panel panel1;
    }
}