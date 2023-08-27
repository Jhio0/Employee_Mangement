namespace Employee
{
    partial class Departments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departments));
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            EditBtn = new Button();
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            DepNameTb = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            EmpLbl = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            SalryLbl = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox5 = new PictureBox();
            DeleteBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            label1.Location = new Point(529, 23);
            label1.Name = "label1";
            label1.Size = new Size(276, 28);
            label1.TabIndex = 0;
            label1.Text = "Employee Mangement System";
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(219, 310);
            button2.Name = "button2";
            button2.Size = new Size(167, 41);
            button2.TabIndex = 43;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.Teal;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = Color.White;
            EditBtn.Location = new Point(32, 310);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(167, 41);
            EditBtn.TabIndex = 42;
            EditBtn.Text = "Add";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditRtn_Click;
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DepList.ColumnHeadersHeight = 25;
            DepList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle3;
            DepList.GridColor = Color.FromArgb(231, 229, 255);
            DepList.Location = new Point(502, 246);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.RowHeadersWidth = 51;
            DepList.RowTemplate.Height = 29;
            DepList.Size = new Size(763, 475);
            DepList.TabIndex = 39;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DepList.ThemeStyle.BackColor = Color.White;
            DepList.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = Color.Teal;
            DepList.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 25;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            DepList.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 29;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(148, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(32, 189);
            label3.Name = "label3";
            label3.Size = new Size(174, 28);
            label3.TabIndex = 29;
            label3.Text = "Department Name";
            // 
            // DepNameTb
            // 
            DepNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DepNameTb.Location = new Point(32, 228);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new Size(354, 34);
            DepNameTb.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(682, 151);
            label2.Name = "label2";
            label2.Size = new Size(218, 28);
            label2.TabIndex = 27;
            label2.Text = "Manage Departments";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(779, 189);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 45;
            label4.Text = "Department List";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(391, 104);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.BackColor = Color.White;
            EmpLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmpLbl.ForeColor = Color.Teal;
            EmpLbl.Location = new Point(466, 113);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new Size(98, 28);
            EmpLbl.TabIndex = 47;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(708, 113);
            label6.Name = "label6";
            label6.Size = new Size(125, 28);
            label6.TabIndex = 49;
            label6.Text = "Departments";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(633, 104);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // SalryLbl
            // 
            SalryLbl.AutoSize = true;
            SalryLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SalryLbl.ForeColor = Color.Teal;
            SalryLbl.Location = new Point(940, 113);
            SalryLbl.Name = "SalryLbl";
            SalryLbl.Size = new Size(65, 28);
            SalryLbl.TabIndex = 51;
            SalryLbl.Text = "Salary";
            SalryLbl.Click += SalryLbl_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(865, 104);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 37);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(1172, 113);
            label8.Name = "label8";
            label8.Size = new Size(75, 28);
            label8.TabIndex = 53;
            label8.Text = "Logout";
            label8.Click += label8_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(1097, 104);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 52;
            pictureBox5.TabStop = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.Crimson;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = Color.Black;
            DeleteBtn.Location = new Point(115, 367);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(167, 41);
            DeleteBtn.TabIndex = 54;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += button1_Click;
            // 
            // Departments
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1300, 767);
            Controls.Add(DeleteBtn);
            Controls.Add(label8);
            Controls.Add(pictureBox5);
            Controls.Add(SalryLbl);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(pictureBox3);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(EditBtn);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(DepNameTb);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Departments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Departments";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button EditBtn;
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox DepNameTb;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox2;
        private Label EmpLbl;
        private Label label6;
        private PictureBox pictureBox3;
        private Label SalryLbl;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox5;
        private Button DeleteBtn;
    }
}