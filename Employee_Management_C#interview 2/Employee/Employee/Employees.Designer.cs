namespace Employee
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EmpNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            DailySalTb = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            GenCb = new ComboBox();
            DepCb = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            DOBTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            JDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            AddBtn = new Button();
            UpdateBtn = new Button();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
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
            panel1.TabIndex = 0;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(782, 126);
            label2.Name = "label2";
            label2.Size = new Size(195, 28);
            label2.TabIndex = 1;
            label2.Text = "Manage Employees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(33, 164);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 7;
            label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpNameTb.Location = new Point(33, 203);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(354, 34);
            EmpNameTb.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(33, 253);
            label4.Name = "label4";
            label4.Size = new Size(167, 28);
            label4.TabIndex = 9;
            label4.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(33, 435);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 13;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(33, 346);
            label6.Name = "label6";
            label6.Size = new Size(208, 28);
            label6.TabIndex = 11;
            label6.Text = "Employee Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(33, 600);
            label7.Name = "label7";
            label7.Size = new Size(205, 28);
            label7.TabIndex = 17;
            label7.Text = "Employee Daily Salary";
            // 
            // DailySalTb
            // 
            DailySalTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DailySalTb.Location = new Point(33, 639);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new Size(354, 34);
            DailySalTb.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(33, 511);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 15;
            label8.Text = "Join Date";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 741);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 26);
            panel2.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // GenCb
            // 
            GenCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male ", "Female" });
            GenCb.Location = new Point(33, 296);
            GenCb.Name = "GenCb";
            GenCb.Size = new Size(354, 36);
            GenCb.TabIndex = 20;
            // 
            // DepCb
            // 
            DepCb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepCb.FormattingEnabled = true;
            DepCb.Location = new Point(33, 387);
            DepCb.Name = "DepCb";
            DepCb.Size = new Size(354, 36);
            DepCb.TabIndex = 21;
            // 
            // DOBTb
            // 
            DOBTb.Checked = true;
            DOBTb.CustomizableEdges = customizableEdges1;
            DOBTb.FillColor = Color.Teal;
            DOBTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DOBTb.Format = DateTimePickerFormat.Short;
            DOBTb.Location = new Point(33, 466);
            DOBTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DOBTb.Name = "DOBTb";
            DOBTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DOBTb.Size = new Size(354, 45);
            DOBTb.TabIndex = 23;
            DOBTb.Value = new DateTime(2023, 8, 6, 11, 38, 5, 921);
            // 
            // JDateTb
            // 
            JDateTb.Checked = true;
            JDateTb.CustomizableEdges = customizableEdges3;
            JDateTb.FillColor = Color.Teal;
            JDateTb.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            JDateTb.Format = DateTimePickerFormat.Short;
            JDateTb.Location = new Point(33, 552);
            JDateTb.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            JDateTb.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            JDateTb.Size = new Size(354, 45);
            JDateTb.TabIndex = 24;
            JDateTb.Value = new DateTime(2023, 8, 6, 11, 38, 23, 849);
            JDateTb.ValueChanged += guna2DateTimePicker2_ValueChanged;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Teal;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = Color.White;
            AddBtn.Location = new Point(33, 679);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(167, 41);
            AddBtn.TabIndex = 25;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.PaleTurquoise;
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.ForeColor = Color.Black;
            UpdateBtn.Location = new Point(220, 679);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(167, 41);
            UpdateBtn.TabIndex = 26;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(1170, 98);
            label9.Name = "label9";
            label9.Size = new Size(75, 28);
            label9.TabIndex = 61;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1095, 89);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 60;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(938, 98);
            label10.Name = "label10";
            label10.Size = new Size(65, 28);
            label10.TabIndex = 59;
            label10.Text = "Salary";
            label10.Click += label10_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(863, 89);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 58;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Teal;
            label11.Location = new Point(706, 98);
            label11.Name = "label11";
            label11.Size = new Size(125, 28);
            label11.TabIndex = 57;
            label11.Text = "Departments";
            label11.Click += label11_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(631, 89);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.White;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Teal;
            label12.Location = new Point(464, 98);
            label12.Name = "label12";
            label12.Size = new Size(98, 28);
            label12.TabIndex = 55;
            label12.Text = "Employee";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(389, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeeList.ColumnHeadersHeight = 25;
            EmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeeList.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.Location = new Point(496, 198);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersVisible = false;
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.RowTemplate.Height = 29;
            EmployeeList.Size = new Size(763, 475);
            EmployeeList.TabIndex = 62;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeList.ThemeStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeList.ThemeStyle.HeaderStyle.Height = 25;
            EmployeeList.ThemeStyle.ReadOnly = false;
            EmployeeList.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.ThemeStyle.RowsStyle.Height = 29;
            EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(800, 679);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(167, 41);
            DeleteBtn.TabIndex = 63;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 767);
            Controls.Add(DeleteBtn);
            Controls.Add(EmployeeList);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(label11);
            Controls.Add(pictureBox3);
            Controls.Add(label12);
            Controls.Add(pictureBox2);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(DailySalTb);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(EmpNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EmpNameTb;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox DailySalTb;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox GenCb;
        private ComboBox DepCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker JDateTb;
        private Button AddBtn;
        private Button UpdateBtn;
        private Label label9;
        private PictureBox pictureBox5;
        private Label label10;
        private PictureBox pictureBox4;
        private Label label11;
        private PictureBox pictureBox3;
        private Label label12;
        private PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private Button DeleteBtn;
    }
}