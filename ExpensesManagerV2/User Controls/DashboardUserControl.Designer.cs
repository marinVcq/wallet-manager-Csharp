namespace ExpensesManagerV2.User_Controls
{
    partial class DashboardUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            expensesPanel = new Panel();
            dataGridViewExpenses = new DataGridView();
            panel2 = new Panel();
            panel8 = new Panel();
            comboBoxFilter = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            buttonAdd = new Button();
            txtLabel = new TextBox();
            panel7 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            txtAmount = new TextBox();
            panel6 = new Panel();
            label5 = new Label();
            txtDate = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            comboBoxType = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label2 = new Label();
            expensesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).BeginInit();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // expensesPanel
            // 
            expensesPanel.BackColor = Color.WhiteSmoke;
            expensesPanel.Controls.Add(dataGridViewExpenses);
            expensesPanel.Controls.Add(panel2);
            expensesPanel.Dock = DockStyle.Top;
            expensesPanel.Location = new Point(30, 30);
            expensesPanel.Name = "expensesPanel";
            expensesPanel.Size = new Size(1007, 547);
            expensesPanel.TabIndex = 1;
            // 
            // dataGridViewExpenses
            // 
            dataGridViewExpenses.AllowUserToAddRows = false;
            dataGridViewExpenses.AllowUserToDeleteRows = false;
            dataGridViewExpenses.AllowUserToOrderColumns = true;
            dataGridViewExpenses.AllowUserToResizeColumns = false;
            dataGridViewExpenses.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightCyan;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewExpenses.BackgroundColor = Color.White;
            dataGridViewExpenses.BorderStyle = BorderStyle.None;
            dataGridViewExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewExpenses.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewExpenses.Dock = DockStyle.Fill;
            dataGridViewExpenses.Location = new Point(0, 49);
            dataGridViewExpenses.Name = "dataGridViewExpenses";
            dataGridViewExpenses.RowHeadersWidth = 51;
            dataGridViewExpenses.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewExpenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewExpenses.RowTemplate.Height = 29;
            dataGridViewExpenses.ScrollBars = ScrollBars.Vertical;
            dataGridViewExpenses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewExpenses.ShowCellErrors = false;
            dataGridViewExpenses.ShowCellToolTips = false;
            dataGridViewExpenses.ShowRowErrors = false;
            dataGridViewExpenses.Size = new Size(1007, 498);
            dataGridViewExpenses.StandardTab = true;
            dataGridViewExpenses.TabIndex = 1;
            dataGridViewExpenses.TabStop = false;
            dataGridViewExpenses.CellContentClick += dataGridViewExpenses_CellContentClick;
            dataGridViewExpenses.CellEndEdit += dataGridViewExpenses_CellEndEdit;
            dataGridViewExpenses.CellFormatting += dataGridViewExpenses_CellFormatting;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 52, 116);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1007, 49);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(comboBoxFilter);
            panel8.Controls.Add(label7);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(700, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(307, 49);
            panel8.TabIndex = 1;
            // 
            // comboBoxFilter
            // 
            comboBoxFilter.FlatStyle = FlatStyle.Flat;
            comboBoxFilter.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFilter.ForeColor = Color.FromArgb(33, 33, 33);
            comboBoxFilter.FormattingEnabled = true;
            comboBoxFilter.Items.AddRange(new object[] { "All", "Dining", "Entertainment", "Health", "Travel", "Shopping" });
            comboBoxFilter.Location = new Point(94, 8);
            comboBoxFilter.Name = "comboBoxFilter";
            comboBoxFilter.Size = new Size(196, 30);
            comboBoxFilter.TabIndex = 15;
            comboBoxFilter.Text = "All";
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(13, 10);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 0;
            label7.Text = "Filter by:";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(196, 29);
            label1.TabIndex = 0;
            label1.Text = "Last Expenses";
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(buttonAdd);
            panel3.Controls.Add(txtLabel);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(txtAmount);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtDate);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(comboBoxType);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(30, 577);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 20, 0, 0);
            panel3.Size = new Size(1007, 211);
            panel3.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.MidnightBlue;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(748, 137);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(230, 36);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Add Expense";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // txtLabel
            // 
            txtLabel.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtLabel.ForeColor = Color.FromArgb(33, 33, 33);
            txtLabel.Location = new Point(505, 143);
            txtLabel.Multiline = true;
            txtLabel.Name = "txtLabel";
            txtLabel.PlaceholderText = "Cinema ...";
            txtLabel.Size = new Size(209, 27);
            txtLabel.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(28, 52, 116);
            panel7.Location = new Point(505, 171);
            panel7.Name = "panel7";
            panel7.Size = new Size(210, 2);
            panel7.TabIndex = 12;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(444, 143);
            label6.Name = "label6";
            label6.Size = new Size(67, 25);
            label6.TabIndex = 11;
            label6.Text = "Label:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dollar;
            pictureBox1.Location = new Point(670, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.ForeColor = Color.FromArgb(33, 33, 33);
            txtAmount.Location = new Point(505, 85);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "185,45";
            txtAmount.Size = new Size(155, 27);
            txtAmount.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(28, 52, 116);
            panel6.Location = new Point(505, 115);
            panel6.Name = "panel6";
            panel6.Size = new Size(159, 2);
            panel6.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(419, 87);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 7;
            label5.Text = "Amount:";
            // 
            // txtDate
            // 
            txtDate.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtDate.ForeColor = Color.FromArgb(33, 33, 33);
            txtDate.Location = new Point(140, 141);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.PlaceholderText = "DD/MM/YYYYY";
            txtDate.Size = new Size(243, 27);
            txtDate.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(28, 52, 116);
            panel5.Location = new Point(140, 169);
            panel5.Name = "panel5";
            panel5.Size = new Size(243, 2);
            panel5.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 141);
            label4.Name = "label4";
            label4.Size = new Size(157, 25);
            label4.TabIndex = 4;
            label4.Text = "Expense Date:";
            // 
            // comboBoxType
            // 
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Microsoft JhengHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.ForeColor = Color.FromArgb(33, 33, 33);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Dining", "Entertainment", "Health", "Travel", "Shopping" });
            comboBoxType.Location = new Point(140, 84);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(243, 30);
            comboBoxType.TabIndex = 3;
            comboBoxType.Text = "Select Type...";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(28, 52, 116);
            panel1.Location = new Point(140, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 2);
            panel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 87);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 1;
            label3.Text = "Expense Type:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(28, 52, 116);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 49);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(196, 29);
            label2.TabIndex = 0;
            label2.Text = "Add Expenses";
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(expensesPanel);
            Name = "DashboardUserControl";
            Padding = new Padding(30);
            Size = new Size(1067, 930);
            Load += DashboardUserControl_Load;
            expensesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpenses).EndInit();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel expensesPanel;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private DataGridView dataGridViewExpenses;
        private ComboBox comboBoxType;
        private Panel panel1;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox txtAmount;
        private Panel panel6;
        private Label label5;
        private TextBox txtDate;
        private Button buttonAdd;
        private TextBox txtLabel;
        private Panel panel7;
        private Label label6;
        private Panel panel8;
        private ComboBox comboBoxFilter;
        private Label label7;
    }
}
