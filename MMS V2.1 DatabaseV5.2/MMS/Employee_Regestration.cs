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
    public partial class Employee_Regestration : Form
    {
        public Employee_Regestration()
        {
            InitializeComponent();
        }

        private void Employee_Regestration_Load(object sender, EventArgs e)
        {
            label7.Text = activate_Emp_AccountLogin.empIDCodeRemember;
            string loginIDCodeEmp = activate_Emp_AccountLogin.empIDCodeRemember;
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Employee where EmpID = '" + loginIDCodeEmp + "' ";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            txt_empName.Text = dt.Rows[0]["EmpName"].ToString();
            txt_empID.Text = dt.Rows[0]["EmpID"].ToString();
            lbl_sal.Text = dt.Rows[0]["EmpSalary"].ToString();
            //string isAManager = "";
            if(dt.Rows[0]["IsManagerOfAShop"].ToString() == "YES")
            {
                lbl_yesOrNo.Text = " a ";
            }
            else
            {
                lbl_yesOrNo.Text = " not ";
            }
            assigned_Shop.Text= dt.Rows[0]["EmpAssignedShop"].ToString();
            DCon.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txt_empName.Text != "" && txt_EmpPhoneNumber.Text != "" && txt_EmpEmail.Text != "" && (rdo_Female.Checked || rdo_Male.Checked) && txt_pass.Text != "" && txt_conPass.Text!= "")
            {
                string loginIDCodeEmp = activate_Emp_AccountLogin.empIDCodeRemember;
                string empName = txt_empName.Text;
                string empPhone = txt_EmpPhoneNumber.Text;
                string empEmail = txt_EmpEmail.Text;
                string password = txt_pass.Text;
                string gender = "";
                string isActivated = "1";
                DateTime DOB = dateTimePicker1.Value;
                if(rdo_Male.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                if(txt_conPass.Text == txt_pass.Text)
                {
                    SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                    DCon.Open();
                    string query2 = "update DB_Employee set EmpName = '"+empName+"', EmpDateOfBirth = '"+DOB +"', EmpPhoneNumber = '"+empPhone+"', EmpEmail = '"+empEmail+"', EmpGender = '"+gender+"', EmpPassword = '"+txt_pass.Text+ "', isActivated = '" + isActivated+"' where EmpID = '"+loginIDCodeEmp+"'";
                    SqlCommand cmd2 = new SqlCommand(query2, DCon);
                    int row = cmd2.ExecuteNonQuery();
                    if(row == 1)
                    {
                        MessageBox.Show("Success: \n" + "Your account activited successfully.");
                        
                        Main_Page mainPage = new Main_Page();
                        mainPage.Show();
                        this.Close();
                        DCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Can not activited. Check your information again");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Password and Confirm password should be same.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Please provide all information!");
            }
        }
    }
}
