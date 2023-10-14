namespace ExpensesManagerV2.User_Controls
{
    partial class GraphicsUserControl
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
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            plotView2 = new OxyPlot.WindowsForms.PlotView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // plotView1
            // 
            plotView1.AllowDrop = true;
            plotView1.BackColor = Color.White;
            plotView1.Dock = DockStyle.Top;
            plotView1.Font = new Font("Microsoft JhengHei UI Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            plotView1.ForeColor = Color.MidnightBlue;
            plotView1.Location = new Point(0, 0);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(1050, 446);
            plotView1.TabIndex = 0;
            plotView1.Text = "Line Series";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(plotView2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(1050, 484);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(847, 130);
            label1.Name = "label1";
            label1.Size = new Size(115, 35);
            label1.TabIndex = 22;
            label1.Text = "Shopping";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(847, 82);
            label2.Name = "label2";
            label2.Size = new Size(147, 35);
            label2.TabIndex = 21;
            label2.Text = "Health";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(847, 35);
            label3.Name = "label3";
            label3.Size = new Size(115, 35);
            label3.TabIndex = 20;
            label3.Text = "Utilities";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Olive;
            panel5.Location = new Point(776, 133);
            panel5.Name = "panel5";
            panel5.Size = new Size(65, 32);
            panel5.TabIndex = 19;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Purple;
            panel6.Location = new Point(776, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(65, 32);
            panel6.TabIndex = 18;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Yellow;
            panel7.Location = new Point(776, 38);
            panel7.Name = "panel7";
            panel7.Size = new Size(65, 32);
            panel7.TabIndex = 17;
            // 
            // plotView2
            // 
            plotView2.BackColor = Color.White;
            plotView2.Dock = DockStyle.Left;
            plotView2.Location = new Point(0, 0);
            plotView2.Name = "plotView2";
            plotView2.PanCursor = Cursors.Hand;
            plotView2.Size = new Size(558, 484);
            plotView2.TabIndex = 16;
            plotView2.Text = "plotView2";
            plotView2.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView2.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView2.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(635, 130);
            label4.Name = "label4";
            label4.Size = new Size(115, 35);
            label4.TabIndex = 15;
            label4.Text = "Travel";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(635, 82);
            label5.Name = "label5";
            label5.Size = new Size(147, 35);
            label5.TabIndex = 13;
            label5.Text = "Entertainment";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft JhengHei UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(635, 35);
            label6.Name = "label6";
            label6.Size = new Size(115, 35);
            label6.TabIndex = 11;
            label6.Text = "Dining";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.Location = new Point(564, 133);
            panel4.Name = "panel4";
            panel4.Size = new Size(65, 32);
            panel4.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Lime;
            panel3.Location = new Point(564, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(65, 32);
            panel3.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Location = new Point(564, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(65, 32);
            panel2.TabIndex = 3;
            // 
            // GraphicsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(plotView1);
            Name = "GraphicsUserControl";
            Size = new Size(1050, 930);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plotView1;
        private Label labelDetail;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}
