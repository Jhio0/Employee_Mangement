namespace Employee
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            UNameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            LoginBtn = new Button();
            ResetLbl = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 553);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UNameTb
            // 
            UNameTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTb.Location = new Point(454, 250);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(354, 34);
            UNameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.Location = new Point(454, 328);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(354, 34);
            PasswordTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(454, 211);
            label2.Name = "label2";
            label2.Size = new Size(108, 28);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(454, 297);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.Teal;
            LoginBtn.Location = new Point(543, 378);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(185, 41);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // ResetLbl
            // 
            ResetLbl.AutoSize = true;
            ResetLbl.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point);
            ResetLbl.ForeColor = Color.Teal;
            ResetLbl.Location = new Point(606, 422);
            ResetLbl.Name = "ResetLbl";
            ResetLbl.Size = new Size(58, 28);
            ResetLbl.TabIndex = 8;
            ResetLbl.Text = "Reset";
            ResetLbl.Click += ResetLbl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(495, 18);
            label4.Name = "label4";
            label4.Size = new Size(276, 28);
            label4.TabIndex = 0;
            label4.Text = "Employee Mangement System";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(966, 553);
            Controls.Add(label4);
            Controls.Add(ResetLbl);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private Label label2;
        private Label label3;
        private Button LoginBtn;
        private Label ResetLbl;
        private Label label4;
    }
}