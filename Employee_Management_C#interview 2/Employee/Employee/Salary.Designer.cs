namespace Employee
{
    partial class Salary
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            UpdateBtn = new Button();
            AddBtn = new Button();
            PeriodTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            EmpCb = new ComboBox();
            DayTb = new TextBox();
            LogoutLbl = new Label();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            pictureBox3 = new PictureBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            SalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            AmountTb = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 74);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(543, 20);
            label1.Name = "label1";
            label1.Size = new Size(276, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Mangement System";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.PaleTurquoise;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.Black;
            UpdateBtn.Location = new Point(223, 688);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(167, 41);
            UpdateBtn.TabIndex = 43;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(36, 688);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(167, 41);
            AddBtn.TabIndex = 42;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // PeriodTb
            // 
            PeriodTb.Checked = true;
            PeriodTb.CustomizableEdges = customizableEdges1;
            PeriodTb.FillColor = Color.Teal;
            PeriodTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PeriodTb.Format = DateTimePickerFormat.Long;
            PeriodTb.Location = new Point(36, 389);
            PeriodTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            PeriodTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            PeriodTb.Size = new Size(354, 45);
            PeriodTb.TabIndex = 40;
            PeriodTb.Value = new DateTime(2023, 8, 6, 11, 38, 5, 921);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(152, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(36, 437);
            label8.Name = "label8";
            label8.Size = new Size(141, 28);
            label8.TabIndex = 33;
            label8.Text = "Salary Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(36, 358);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 32;
            label5.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(36, 262);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 30;
            label4.Text = "Days Attented";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(36, 173);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 29;
            label3.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(768, 173);
            label2.Name = "label2";
            label2.Size = new Size(153, 28);
            label2.TabIndex = 27;
            label2.Text = "Manage Salary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 741);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 26);
            panel2.TabIndex = 44;
            // 
            // EmpCb
            // 
            EmpCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpCb.FormattingEnabled = true;
            EmpCb.Items.AddRange(new object[] { "Male ", "Female" });
            EmpCb.Location = new Point(36, 212);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new Size(354, 36);
            EmpCb.TabIndex = 38;
            EmpCb.SelectedIndexChanged += EmpCb_SelectedIndexChanged;
            // 
            // DayTb
            // 
            DayTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DayTb.Location = new Point(36, 307);
            DayTb.Name = "DayTb";
            DayTb.Size = new Size(354, 34);
            DayTb.TabIndex = 45;
            // 
            // LogoutLbl
            // 
            LogoutLbl.AutoSize = true;
            LogoutLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutLbl.ForeColor = Color.Teal;
            LogoutLbl.Location = new Point(1177, 116);
            LogoutLbl.Name = "LogoutLbl";
            LogoutLbl.Size = new Size(75, 28);
            LogoutLbl.TabIndex = 61;
            LogoutLbl.Text = "Logout";
            LogoutLbl.Click += LogoutLbl_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1102, 107);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 60;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(945, 116);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 59;
            label7.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(870, 107);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(713, 116);
            label9.Name = "label9";
            label9.Size = new Size(125, 28);
            label9.TabIndex = 57;
            label9.Text = "Departments";
            label9.Click += label9_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(638, 107);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(471, 116);
            label10.Name = "label10";
            label10.Size = new Size(98, 28);
            label10.TabIndex = 55;
            label10.Text = "Employee";
            label10.Click += label10_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(396, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // SalaryList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            SalaryList.ColumnHeadersHeight = 25;
            SalaryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle3;
            SalaryList.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.Location = new Point(498, 212);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersVisible = false;
            SalaryList.RowHeadersWidth = 51;
            SalaryList.RowTemplate.Height = 29;
            SalaryList.Size = new Size(763, 475);
            SalaryList.TabIndex = 63;
            SalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            SalaryList.ThemeStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            SalaryList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            SalaryList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            SalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryList.ThemeStyle.HeaderStyle.Height = 25;
            SalaryList.ThemeStyle.ReadOnly = false;
            SalaryList.ThemeStyle.RowsStyle.BackColor = Color.White;
            SalaryList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            SalaryList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.ThemeStyle.RowsStyle.Height = 29;
            SalaryList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            SalaryList.CellContentClick += SalaryList_CellContentClick;
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.White;
            AmountTb.BorderStyle = BorderStyle.None;
            AmountTb.Enabled = false;
            AmountTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Teal;
            AmountTb.Location = new Point(36, 468);
            AmountTb.Name = "AmountTb";
            AmountTb.Size = new Size(354, 27);
            AmountTb.TabIndex = 64;
            AmountTb.TextAlign = HorizontalAlignment.Right;
            // 
            // Salary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 767);
            Controls.Add(AmountTb);
            Controls.Add(SalaryList);
            Controls.Add(LogoutLbl);
            Controls.Add(pictureBox5);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(label9);
            Controls.Add(pictureBox3);
            Controls.Add(label10);
            Controls.Add(pictureBox2);
            Controls.Add(DayTb);
            Controls.Add(EmpCb);
            Controls.Add(panel2);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(PeriodTb);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label8);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Salary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Salary";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button UpdateBtn;
        private Button AddBtn;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodTb;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private ComboBox EmpCb;
        private TextBox DayTb;
        private Label LogoutLbl;
        private PictureBox pictureBox5;
        private Label label7;
        private PictureBox pictureBox4;
        private Label label9;
        private PictureBox pictureBox3;
        private Label label10;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryList;
        private TextBox AmountTb;
    }
}