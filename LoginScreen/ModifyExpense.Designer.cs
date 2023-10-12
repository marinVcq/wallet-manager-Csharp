namespace ExpensesManager
{
    partial class ModifyExpense
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
            txtLabel = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            txtAmount = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            txtDate = new TextBox();
            panel4 = new Panel();
            label5 = new Label();
            comboBoxType = new ComboBox();
            buttonModify = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MidnightBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(439, 50);
            label1.TabIndex = 0;
            label1.Text = "Modify Expense";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLabel
            // 
            txtLabel.BorderStyle = BorderStyle.None;
            txtLabel.Location = new Point(124, 83);
            txtLabel.Multiline = true;
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(268, 34);
            txtLabel.TabIndex = 1;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(28, 83);
            label2.Name = "label2";
            label2.Size = new Size(87, 40);
            label2.TabIndex = 2;
            label2.Text = "Label:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(124, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 2);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(124, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 2);
            panel2.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(28, 142);
            label3.Name = "label3";
            label3.Size = new Size(87, 40);
            label3.TabIndex = 5;
            label3.Text = "Amnt:";
            // 
            // txtAmount
            // 
            txtAmount.BorderStyle = BorderStyle.None;
            txtAmount.Location = new Point(124, 142);
            txtAmount.Multiline = true;
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(240, 34);
            txtAmount.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_us_dollar_24;
            pictureBox1.Location = new Point(370, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Location = new Point(124, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 2);
            panel3.TabIndex = 6;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(28, 202);
            label4.Name = "label4";
            label4.Size = new Size(87, 40);
            label4.TabIndex = 5;
            label4.Text = "Date:";
            // 
            // txtDate
            // 
            txtDate.BorderStyle = BorderStyle.None;
            txtDate.Location = new Point(124, 202);
            txtDate.Multiline = true;
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(268, 34);
            txtDate.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(124, 306);
            panel4.Name = "panel4";
            panel4.Size = new Size(268, 2);
            panel4.TabIndex = 6;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MidnightBlue;
            label5.Location = new Point(28, 268);
            label5.Name = "label5";
            label5.Size = new Size(87, 40);
            label5.TabIndex = 5;
            label5.Text = "Type:";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.WhiteSmoke;
            comboBoxType.FlatStyle = FlatStyle.Flat;
            comboBoxType.Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Daily expenses", "Home rent", "Fuel", "Health", "Outing", "Others" });
            comboBoxType.Location = new Point(124, 271);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(268, 29);
            comboBoxType.TabIndex = 24;
            comboBoxType.Text = "Select type...";
            // 
            // buttonModify
            // 
            buttonModify.BackColor = Color.MidnightBlue;
            buttonModify.Cursor = Cursors.Hand;
            buttonModify.FlatStyle = FlatStyle.Flat;
            buttonModify.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModify.ForeColor = Color.White;
            buttonModify.Location = new Point(28, 338);
            buttonModify.Name = "buttonModify";
            buttonModify.Size = new Size(173, 39);
            buttonModify.TabIndex = 25;
            buttonModify.Text = "Modify";
            buttonModify.UseVisualStyleBackColor = false;
            buttonModify.Click += buttonModify_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(222, 338);
            button1.Name = "button1";
            button1.Size = new Size(174, 39);
            button1.TabIndex = 26;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ModifyExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(439, 406);
            Controls.Add(button1);
            Controls.Add(buttonModify);
            Controls.Add(comboBoxType);
            Controls.Add(panel4);
            Controls.Add(label5);
            Controls.Add(panel3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(txtDate);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(txtAmount);
            Controls.Add(label2);
            Controls.Add(txtLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ModifyExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modify Expense";
            Load += ModifyExpense_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLabel;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private TextBox txtAmount;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label label4;
        private TextBox txtDate;
        private Panel panel4;
        private Label label5;
        private ComboBox comboBoxType;
        private Button buttonModify;
        private Button button1;
    }
}