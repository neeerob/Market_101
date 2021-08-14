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
    public partial class employee_Management : Form
    {
        public employee_Management()
        {
            InitializeComponent();
        }

        private void employee_Management_Load(object sender, EventArgs e)
        {
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Employee";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DCon.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string EmpID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Employee where EmpID = '" + EmpID + "'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if(dt.Rows.Count == 1)
                {
                    txt_EmpID.Text = dt.Rows[0]["EmpID"].ToString();
                    txt_EmpName.Text = dt.Rows[0]["EmpName"].ToString();
                    txt_AssignedShop.Text = dt.Rows[0]["EmpAssignedShop"].ToString();
                    txt_Email.Text = dt.Rows[0]["EmpEmail"].ToString();
                    txt_PhoneNumber.Text = dt.Rows[0]["EmpPhoneNumber"].ToString();
                    txt_empSal.Text = dt.Rows[0]["EmpSalary"].ToString();
                    if (dt.Rows[0]["EmpGender"].ToString() == "Male")
                    {
                        rdo_Male.Checked = true;
                    }
                    else if (dt.Rows[0]["EmpGender"].ToString() == "Female")
                    {
                        rdo_Female.Checked = true;
                    }
                    else
                    {
                        rdo_Male.Checked = false;
                        rdo_Female.Checked = false;
                    }

                    if (dt.Rows[0]["isActivated"].ToString() == "1")
                    {
                        r_Active.Checked = true;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker1.Value = (DateTime)dt.Rows[0]["EmpDateOfBirth"];
                    }
                    else if (dt.Rows[0]["isActivated"].ToString() == "")
                    {
                        r_notActive.Checked = true;
                    }
                    else
                    {
                        r_Active.Checked = false;
                        r_notActive.Checked = false;
                    }

                    if (dt.Rows[0]["IsManagerOfAShop"].ToString() == "NO")
                    {
                        radioNo.Checked = true;
                    }
                    else
                    {
                        radio_Yes.Checked = true;
                    }

                    DCon.Close();
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Click valid row!");
                }


            }
            else
            {
                MessageBox.Show("Warning: \n" + "Click valid row!");
            }
        }

        private void button2_Click(object sender, EventArgs e) //goBack
        {
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
            this.Close();
        }

        private void btn_deleteEmpAccount_Click(object sender, EventArgs e)
        {
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "delete from DB_Employee where EmpID = '" + txt_EmpID.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query, DCon);
            int row = cmd2.ExecuteNonQuery();
            if (row == 1)
            {
                MessageBox.Show("Successfully Deleted!");
                string query2 = "select * from DB_Employee";
                SqlCommand cmd = new SqlCommand(query2, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                txt_AssignedShop.Text = "";
                txt_Email.Text = "";
                txt_EmpID.Text = "";
                txt_EmpName.Text = "";
                txt_empSal.Text = "";
                txt_PhoneNumber.Text = "";
                radioNo.Checked = false;
                radio_Yes.Checked = false;
                rdo_Female.Checked = false;
                rdo_Male.Checked = false;
                r_Active.Checked = false;
                r_notActive.Checked = false;
                //txt_shopID.Text = "";
                //txt_shopName.Text = "";
                //DCon.Close();
                //data_AdminProfile.Refresh();
                DCon.Close();
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Something went wrong!");
            }
        }

        private void btn_updateInfo_Click(object sender, EventArgs e)
        {
            if (txt_EmpID.Text != "")
            {
                string isManager = "";
                if(radio_Yes.Checked == true)
                {
                    isManager = "YES";
                }
                if(radioNo.Checked == true)
                {
                    isManager = "NO";
                }
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query3 = "select * from DB_Shop where shopID = '"+txt_AssignedShop.Text+"'";
                SqlCommand cmd = new SqlCommand(query3, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                if (dt.Rows.Count == 1)
                {
                    string query = "update DB_Employee set EmpName = '" + txt_EmpName.Text + "', EmpAssignedShop = '" + txt_AssignedShop.Text + "', EmpSalary = '" + txt_empSal.Text + "', IsManagerOfAShop = '" + isManager + "'  where EmpID = '" + txt_EmpID.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, DCon);
                    int row = cmd2.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Successfully Updated!");
                        string query2 = "select * from DB_Employee";
                        SqlCommand cmd3 = new SqlCommand(query2, DCon);
                        cmd3.ExecuteNonQuery();
                        SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                        DataSet ds3 = new DataSet();
                        adp3.Fill(ds3);
                        DataTable dt3 = ds3.Tables[0];
                        dataGridView1.DataSource = dt3;
                        dataGridView1.Refresh();
                        DCon.Close();
                        //data_AdminProfile.Refresh();
                        //DCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Something went wrong.");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Please Provide a valid Shop ID.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Please click a cell.");
            }
        }

        private void btn_searchShop_Click(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Employee where EmpName like '%" + txt_search.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Employee Found.");
                    //txt_shopID.Text = dt.Rows[0]["shopID"].ToString();
                    //txt_shopName.Text = dt.Rows[0]["shopName"].ToString();
                    txt_AssignedShop.Text = dt.Rows[0]["EmpAssignedShop"].ToString();
                    txt_Email.Text = dt.Rows[0]["EmpEmail"].ToString();
                    txt_EmpID.Text = dt.Rows[0]["EmpID"].ToString();
                    txt_EmpName.Text = dt.Rows[0]["EmpName"].ToString();
                    txt_empSal.Text = dt.Rows[0]["EmpSalary"].ToString();
                    txt_PhoneNumber.Text = dt.Rows[0]["EmpPhoneNumber"].ToString();
                    if (dt.Rows[0]["EmpGender"].ToString() == "Male")
                    {
                        rdo_Male.Checked = true;
                    }
                    else if (dt.Rows[0]["EmpGender"].ToString() == "Female")
                    {
                        rdo_Female.Checked = true;
                    }
                    else
                    {
                        rdo_Male.Checked = false;
                        rdo_Female.Checked = false;
                    }

                    if (dt.Rows[0]["isActivated"].ToString() == "1")
                    {
                        r_Active.Checked = true;
                        dateTimePicker1.CustomFormat = "yyyy-MM-dd";
                        dateTimePicker1.Value = (DateTime)dt.Rows[0]["EmpDateOfBirth"];
                    }
                    else if (dt.Rows[0]["isActivated"].ToString() == "")
                    {
                        r_notActive.Checked = true;
                    }
                    else
                    {
                        r_Active.Checked = false;
                        r_notActive.Checked = false;
                    }

                    if (dt.Rows[0]["IsManagerOfAShop"].ToString() == "YES")
                    {
                        radio_Yes.Checked = true;
                    }
                    else
                    {
                        radioNo.Checked = true;
                    }

                    
                    DCon.Close();
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Employee not found.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter shopID.");
            }
        }
    }
}
