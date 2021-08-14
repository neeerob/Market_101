using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MMS
{
    public partial class profilePage_Employee : Form
    {
        public profilePage_Employee()
        {
            InitializeComponent();
        }

        private void profilePage_Employee_Load(object sender, EventArgs e)
        {
            lbl_LoginCode.Text = login_Employee.LoginIDCodeEmp;
            string loginIDcodeEmp = login_Employee.LoginIDCodeEmp;
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Employee where EmpID = '" + loginIDcodeEmp + "' ";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            txt_empName.Text = dt.Rows[0]["EmpName"].ToString();
            txt_empID.Text = dt.Rows[0]["EmpID"].ToString();
            lbl_sal.Text = dt.Rows[0]["EmpSalary"].ToString();
            assigned_Shop.Text = dt.Rows[0]["EmpAssignedShop"].ToString();
            if (dt.Rows[0]["IsManagerOfAShop"].ToString() == "YES")
            {
                lbl_yesOrNo.Text = " a ";
            }
            else
            {
                lbl_yesOrNo.Text = " not ";
            }
            txt_EmpPhoneNumber.Text = dt.Rows[0]["EmpPhoneNumber"].ToString();
            txt_EmpPhoneNumber.Text = dt.Rows[0]["EmpPhoneNumber"].ToString();
            txt_EmpEmail.Text  = dt.Rows[0]["EmpEmail"].ToString();
            if(dt.Rows[0]["EmpGender"].ToString() == "Male")
            {
                rdo_Male.Checked = true;
            }
            else
            {
                rdo_Female.Checked = true;
            }
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = (DateTime)dt.Rows[0]["EmpDateOfBirth"];

        }

        private void btn_Admin_Login_Click(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            this.Close();
            mainPage.Show();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            ChangePassword_Employee changePassEmp = new ChangePassword_Employee();
            this.Hide();
            changePassEmp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string empName = txt_empName.Text;
            //string emp
            string empPhoneNumber = txt_EmpPhoneNumber.Text;
            string empEmail = txt_EmpEmail.Text;
            string gender = "";
            DateTime DOB = dateTimePicker1.Value;
            string empID = txt_empID.Text;
            if (rdo_Male.Checked)
            {
                gender = "Male";
            }
            if (rdo_Female.Checked)
            {
                gender = "Female";
            }
            if (empName != "" && empEmail != "" && empPhoneNumber != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query2 = "update DB_Employee set EmpName = '" + empName + "' , EmpPhoneNumber = '" + empPhoneNumber + "', EmpEmail = '" + empEmail + "', EmpGender = '" + gender + "', EmpDateOfBirth = '" + DOB + "' where EmpID = '" + empID + "'";
                SqlCommand cmd2 = new SqlCommand(query2, DCon);
                int row = cmd2.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    //data_AdminProfile.Refresh();
                    DCon.Close();
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Something went wrong!");
                }

            }
            else
            {
                MessageBox.Show("Warning: \n" + "Texstbox can not be empty.");
            }
        }
    }
}
