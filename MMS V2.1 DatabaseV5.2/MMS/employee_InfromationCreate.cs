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
    public partial class employee_InfromationCreate : Form
    {
        public employee_InfromationCreate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
            this.Close();
        }

        private void btn_Emp_Login_Click(object sender, EventArgs e)
        {
            string EmpName = "";
            string EmpID = "";
            String EmpPass = "";
            String IsManagerOfAShop = "";
            String empSal = "";
            String EmpAssShop = "";
            bool bName = false;
            bool bID = false;
            bool bPass = false;
            bool bIsMng = false;
            bool bSal = false;
            bool bAssShop = false;
            string correctness = "";

            if(txt_EmpName.Text != "")
            {
                EmpName = txt_EmpName.Text;
                bName = true;
            }
            if(txt_EmpID.Text != "")
            {
                EmpID = txt_EmpID.Text;
                bID = true;
            }
            if(txt_EmpPassword.Text != "")
            {
                EmpPass = txt_EmpPassword.Text;
                bPass = true;
            }
            if(txt_EmpSalary.Text != "")
            {
                empSal = txt_EmpSalary.Text;
                bSal = true;
            }
            if(txt_AssignedShop.Text != "")
            {
                EmpAssShop = txt_AssignedShop.Text;
                bAssShop = true;
            }
            if (rad_yes.Checked)
            {
                IsManagerOfAShop = "YES";
                bIsMng = true;
            }
            else if (rad_No.Checked)
            {
                IsManagerOfAShop = "NO";
                bIsMng = true;
            }
            else
                bIsMng = false;

            if (bName == false)
                correctness += " Employee Name ";
            if (bID == false)
                correctness += " Employee ID ";
            if (bPass == false)
                correctness += " Employee password ";
            if (bIsMng == false)
                correctness += " Check one from redio box ";
            if (bSal == false)
                correctness += " Salary ";
            if (bAssShop == false)
                correctness += " Assigned Shop ";


            if(bName == true && bID == true && bPass == true && bIsMng == true && bSal == true && bAssShop == true)
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Employee where EmpId = '"+EmpID+"'";
                
                SqlDataAdapter cmd = new SqlDataAdapter(query, DCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);
                DCon.Close();
                if (dtb1.Rows.Count == 0)
                {

                    string query4 = "select * from DB_Shop where shopID = '"+EmpAssShop+"'";
                    //SqlCommand cmd3 = new SqlCommand(query3, DCon);
                    //SqlDataAdapter cmd3 = new SqlDataAdapter(query3, DCon);
                    //DataTable dtb2 = new DataTable();
                    //int row3 = cmd3.ExecuteNonQuery();
                    //cmd.Fill(dtb2);

                    //SqlDataAdapter cmd3 = new SqlDataAdapter(query3, DCon);
                    //DataTable dtb3 = new DataTable();
                    //cmd.Fill(dtb3);
                    DCon.Open();
                    SqlDataAdapter cmd5 = new SqlDataAdapter(query4, DCon);
                    DataTable dtb5 = new DataTable();
                    cmd5.Fill(dtb5);

                    if (dtb5.Rows.Count == 1)
                    {
                        string query2 =
                        "insert into DB_Employee(EmpName, EmpID, EmpPassword, IsManagerOfAShop, EmpSalary, EmpAssignedShop) values('" + EmpName + "','" + EmpID + "','" + EmpPass + "','" + IsManagerOfAShop + "','" + empSal + "','" + EmpAssShop + "')";
                        SqlCommand cmd2 = new SqlCommand(query2, DCon);
                        int row2 = cmd2.ExecuteNonQuery();
                        if (row2 == 1)
                        {
                            MessageBox.Show("Successfully created account! ");
                            this.Close();
                            DCon.Close();
                            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
                            adminProfile.Show();
                        }
                        else
                        {
                            MessageBox.Show("Warning: \n" + "Something went wrong!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Shop doesn't exist!! Enter a valid shop ID.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Employee ID EXISTED!! ID must be unique!");
                }
                
            }
            else
                MessageBox.Show("Warning: \n" + "Missing input! You need to check your '" + correctness + "' field.");


        }
    }
}
