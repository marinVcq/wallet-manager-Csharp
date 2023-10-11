namespace LoginScreen
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtLabel = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel5 = new Panel();
            comboBoxFilter = new ComboBox();
            label6 = new Label();
            dataGridView1 = new DataGridView();
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
            pictureBox2 = new PictureBox();
            buttonAdd = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1211, 59);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            txtLabel.BackColor = Color.WhiteSmoke;
            txtLabel.BorderStyle = BorderStyle.None;
            txtLabel.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabel.Location = new Point(90, 101);
            txtLabel.Multiline = true;
            txtLabel.Name = "txtLabel";
            txtLabel.PlaceholderText = "Cinema";
            txtLabel.Size = new Size(161, 27);
            txtLabel.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(278, 76);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(921, 558);
            tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(comboBoxFilter);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(913, 525);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Overview";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkBlue;
            panel5.Location = new Point(747, 36);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 2);
            panel5.TabIndex = 21;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.BackColor = Color.WhiteSmoke;
            comboBoxFilter.FlatStyle = FlatStyle.Flat;
            comboBoxFilter.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "Daily expenses", "Home rent", "Fuel", "Health", "Outing", "Others" });
            comboBoxFilter.Location = new Point(748, 3);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(159, 29);
            comboBoxFilter.TabIndex = 27;
            comboBoxFilter.Text = "Select type...";
            comboBoxFilter.SelectedValueChanged += comboBoxFilter_SelectedValueChanged;
            // 
            // label6
            // 
            label6.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(635, 3);
            label6.Name = "label6";
            label6.Size = new Size(116, 42);
            label6.TabIndex = 26;
            label6.Text = "Filter Type:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.Navy;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.MidnightBlue;
            dataGridView1.Location = new Point(3, 54);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Navy;
            dataGridViewCellStyle3.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.ShowCellToolTips = false;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.ShowRowErrors = false;
            dataGridView1.Size = new Size(904, 468);
            dataGridView1.TabIndex = 0;
            dataGridView1.TabStop = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(913, 525);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Graph";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.BackColor = Color.WhiteSmoke;
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(89, 156);
            txtAmount.Multiline = true;
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
            label3.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(11, 156);
            label3.Name = "label3";
            label3.Size = new Size(148, 42);
            label3.TabIndex = 13;
            label3.Text = "Amnt:";
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.WhiteSmoke;
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.Location = new Point(90, 217);
            txtDate.Multiline = true;
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
            label4.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            label5.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
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
            comboBoxType.BackColor = Color.WhiteSmoke;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Daily expenses", "Home rent", "Fuel", "Health", "Outing", "Others" });
            comboBoxType.Location = new Point(90, 279);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(159, 29);
            comboBoxType.TabIndex = 23;
            comboBoxType.Text = "Select type...";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.techny_business_model_and_income_growth;
            pictureBox2.Location = new Point(0, 380);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MidnightBlue;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(12, 338);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(238, 39);
            buttonAdd.TabIndex = 24;
            buttonAdd.Text = "Add Expense";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1211, 646);
            Controls.Add(pictureBox2);
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
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Wallet Manager";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private DataGridView dataGridView1;
        private PictureBox pictureBox2;
        private Label label6;
        private Panel panel5;
        private ComboBox comboBoxFilter;
        private DataGridViewTextBoxColumn ExpenseType;
        private Button buttonAdd;
    }
}