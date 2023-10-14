namespace ExpensesManagerV2.User_Controls
{
    partial class HomeUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUserControl));
            homeTitle = new RichTextBox();
            homeTextPanel = new Panel();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            homeTextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // homeTitle
            // 
            homeTitle.BackColor = Color.White;
            homeTitle.BorderStyle = BorderStyle.None;
            homeTitle.Dock = DockStyle.Top;
            homeTitle.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            homeTitle.ForeColor = Color.FromArgb(40, 40, 40);
            homeTitle.Location = new Point(30, 30);
            homeTitle.Name = "homeTitle";
            homeTitle.ScrollBars = RichTextBoxScrollBars.None;
            homeTitle.ShortcutsEnabled = false;
            homeTitle.Size = new Size(988, 122);
            homeTitle.TabIndex = 0;
            homeTitle.Text = "Empower Your Financial Journey: Navigate, Understand, Thrive.";
            // 
            // homeTextPanel
            // 
            homeTextPanel.Controls.Add(pictureBox2);
            homeTextPanel.Controls.Add(pictureBox1);
            homeTextPanel.Controls.Add(richTextBox3);
            homeTextPanel.Controls.Add(richTextBox2);
            homeTextPanel.Controls.Add(richTextBox1);
            homeTextPanel.Controls.Add(homeTitle);
            homeTextPanel.Dock = DockStyle.Fill;
            homeTextPanel.Location = new Point(0, 0);
            homeTextPanel.Name = "homeTextPanel";
            homeTextPanel.Padding = new Padding(30);
            homeTextPanel.Size = new Size(1048, 930);
            homeTextPanel.TabIndex = 2;
            homeTextPanel.SizeChanged += homeTextPanel_SizeChanged;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = Color.White;
            richTextBox3.BorderStyle = BorderStyle.None;
            richTextBox3.Dock = DockStyle.Top;
            richTextBox3.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox3.ForeColor = Color.FromArgb(40, 40, 40);
            richTextBox3.Location = new Point(30, 335);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox3.Size = new Size(988, 123);
            richTextBox3.TabIndex = 3;
            richTextBox3.Text = resources.GetString("richTextBox3.Text");
            richTextBox3.TextChanged += richTextBox3_TextChanged_1;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.BorderStyle = BorderStyle.None;
            richTextBox2.Dock = DockStyle.Top;
            richTextBox2.Font = new Font("Microsoft JhengHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox2.ForeColor = Color.FromArgb(40, 40, 40);
            richTextBox2.Location = new Point(30, 283);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox2.Size = new Size(988, 52);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "Get Started Today:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.FromArgb(40, 40, 40);
            richTextBox1.Location = new Point(30, 152);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(988, 131);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.undraw_Transfer_money_re_6o1h;
            pictureBox1.Location = new Point(-26, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 381);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.undraw_Finance_re_gnv2;
            pictureBox2.Location = new Point(349, 422);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(669, 401);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(homeTextPanel);
            Name = "HomeUserControl";
            Size = new Size(1048, 930);
            homeTextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox homeTitle;
        private Panel homeTextPanel;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
