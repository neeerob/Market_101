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
    public partial class Admin_ProfilePage : Form
    {
        public Admin_ProfilePage()
        {
            InitializeComponent();
        }

        private void btn_Admin_Login_Click(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            mainPage.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employee_InfromationCreate createAccountEmp = new employee_InfromationCreate();
            createAccountEmp.Show();
            this.Hide();
        }

        private void AdminProfilePage_Load(object sender, EventArgs e)
        {

            label7.Text = login_Admin.loginIDCodeP;
            string loginIDCode = login_Admin.loginIDCodeP;
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Manager where MngID = '"+loginIDCode+"' ";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            /*
            //data_AdminProfile.DataSource = dt;
            //data_AdminProfile.Refresh();
            //DCon.Close();
            //string empID = data_AdminProfile.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(empID);
            string empID = Admin_Login.loginIDCodeP;
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Manager where MngID = '" + empID + "' ";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            */
            txt_adminName.Text = dt.Rows[0]["MngName"].ToString();
            txt_adminID.Text = dt.Rows[0]["MngID"].ToString();
            txt_adminPhoneNumber.Text = dt.Rows[0]["MngPhoneNumber"].ToString();
            txt_adminEmail.Text = dt.Rows[0]["MngEmail"].ToString();
            string gender = dt.Rows[0]["MngGender"].ToString();
            if (gender == "Male")
            {
                rdo_Male.Checked = true;
            }
            else
            {
                rdo_Female.Checked = true;
            }
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = (DateTime)dt.Rows[0]["MngDateOfBirth"];
            DCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            create_Shop createShop = new create_Shop();
            createShop.Show();
            this.Hide();
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword_Admin changePass = new ChangePassword_Admin();
            changePass.Show();
        }

        /*
        private void data_AdminProfile_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                //string empID = data_AdminProfile.Rows[e.RowIndex].Cells[0].Value.ToString();
                //MessageBox.Show(empID);
                string empID = Admin_Login.loginIDCodeP;
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Manager where MngID = '" + empID + "' ";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                txt_adminName.Text = dt.Rows[0]["MngName"].ToString();
                txt_adminID.Text = dt.Rows[0]["MngID"].ToString();
                txt_adminPhoneNumber.Text = dt.Rows[0]["MngPhoneNumber"].ToString();
                txt_adminEmail.Text= dt.Rows[0]["MngEmail"].ToString();
                string gender = dt.Rows[0]["MngGender"].ToString();
                if (gender == "Male")
                {
                    rdo_Male.Checked = true;
                }
                else
                {
                    rdo_Female.Checked = true;
                }
                dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                dateTimePicker1.Value =(DateTime) dt.Rows[0]["MngDateOfBirth"];
                DCon.Close();
            }
        }
        */

        private void button4_Click(object sender, EventArgs e)
        {
            string adminName = txt_adminName.Text;
            //string emp
            string adminPhoneNumber = txt_adminPhoneNumber.Text;
            string adminEmail = txt_adminEmail.Text;
            string gender = "";
            DateTime DOB = dateTimePicker1.Value;
            string adminID = txt_adminID.Text;
            if(rdo_Male.Checked)
            {
                gender = "Male";
            }
            if(rdo_Female.Checked)
            {
                gender = "Female";
            }
            if(adminID != "")
            {
                if (adminName != "" && adminEmail != "" && adminPhoneNumber != "")
                {
                    SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                    DCon.Open();
                    string query2 = "update DB_Manager set MngName = '" + adminName + "' , mngPhoneNumber = '" + adminPhoneNumber + "', MngEmail = '" + adminEmail + "', MngGender = '" + gender + "', MngDateOfBirth = '" + DOB + "' where MngID = '" + adminID + "'";
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
            else
            {
                MessageBox.Show("Warning: \n" + "Something went wrong.");
            }
        }

        private void btn_EditOrViewShopData_Click(object sender, EventArgs e)
        {
            
            shop_Management shopManagement = new shop_Management();
            shopManagement.Show();
            this.Hide();
        }

        private void btn_editOrViewEmployeesData_Click(object sender, EventArgs e)
        {
            employee_Management mngEmployee = new employee_Management();
            mngEmployee.Show();
            this.Hide();
        }
    }
}
