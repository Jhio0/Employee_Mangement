using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Salary : Form
    {
        Functions Con;
        public Salary()
        {
            InitializeComponent();
            Con = new Functions();
            ShowSalaries();
            GetEmployees();
        }

        private void GetEmployees()
        {
            string Query = "select * from EmployeeTbl";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["EmpId"].ToString();
            EmpCb.DataSource = Con.GetData(Query);
        }

        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "select EmpSal from EmployeeTbl where EmpId = {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in Con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            /* MessageBox.Show("" + DSal);*/

            if (DayTb.Text == "")
            {
                AmountTb.Text = "$" + (D * DSal);
            }
            else if (Convert.ToInt32(DayTb.Text) > 31)
            {
                MessageBox.Show("Days Can not be Greater Than 31");
            }
            else
            {
                D = Convert.ToInt32(DayTb.Text);
                AmountTb.Text = "$" + (D * DSal);
            }

        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTbl";
                SalaryList.DataSource = Con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int D = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DayTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DayTb.Text);

                    int Days = Convert.ToInt32(DayTb.Text); ;

                    string Query = "insert into SalaryTbl values({0},{1},'{2}',{3},'{4}')";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    Con.SetData(Query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid");
                    DayTb.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }
    }
}
