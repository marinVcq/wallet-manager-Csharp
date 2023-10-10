namespace LoginScreen
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtLabel = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtAmount = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            txtDate = new TextBox();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            comboBoxType = new ComboBox();
            buttonAdd = new Button();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MediumBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(933, 59);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(148, 42);
            label2.TabIndex = 2;
            label2.Text = "Label:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Location = new Point(90, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 2);
            panel1.TabIndex = 5;
            // 
            // txtLabel
            // 
            txtLabel.Location = new Point(90, 101);
            txtLabel.Name = "txtLabel";
            txtLabel.PlaceholderText = "Cinema";
            txtLabel.Size = new Size(161, 27);
            txtLabel.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(267, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(654, 470);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(646, 437);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Overview";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(646, 437);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Graph";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(89, 156);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "1283";
            txtAmount.Size = new Size(112, 27);
            txtAmount.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkBlue;
            panel2.Location = new Point(89, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 2);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(11, 156);
            label3.Name = "label3";
            label3.Size = new Size(148, 42);
            label3.TabIndex = 13;
            label3.Text = "Amnt:";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(90, 217);
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "DD/MM/YYYY";
            txtDate.Size = new Size(161, 27);
            txtDate.TabIndex = 18;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkBlue;
            panel3.Location = new Point(90, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(160, 2);
            panel3.TabIndex = 17;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(148, 42);
            label4.TabIndex = 16;
            label4.Text = "Date:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkBlue;
            panel4.Location = new Point(90, 313);
            panel4.Name = "panel4";
            panel4.Size = new Size(160, 2);
            panel4.TabIndex = 20;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(12, 280);
            label5.Name = "label5";
            label5.Size = new Size(148, 42);
            label5.TabIndex = 19;
            label5.Text = "Type:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_us_dollar_24;
            pictureBox1.Location = new Point(208, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Daily expenses", "Home rent", "Fuel", "Health", "Outing", "Others" });
            comboBoxType.Location = new Point(90, 279);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(159, 28);
            comboBoxType.TabIndex = 23;
            comboBoxType.Text = "Select type...";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Navy;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(12, 338);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(238, 36);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add Spend";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(933, 646);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxType);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(txtDate);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(txtAmount);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(tabControl1);
            Controls.Add(txtLabel);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wallet Manager";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txtLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtAmount;
        private Panel panel2;
        private Label label3;
        private TextBox txtDate;
        private Panel panel3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private PictureBox pictureBox1;
        private ComboBox comboBoxType;
        private Button button1;
        private Button buttonAdd;
    }
}