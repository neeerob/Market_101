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
    
    public partial class activate_Emp_AccountLogin : Form
    {
        public static string empIDCodeRemember = "";
        public activate_Emp_AccountLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacts: 0183221313,23242323" + "\n Or visit www.something.com");
        }

        private void btn_GoMainPage_Click(object sender, EventArgs e)
        {
            Main_Page welcome = new Main_Page();
            welcome.Show();
            this.Hide();
        }

        private void btn_Emp_Login_Click(object sender, EventArgs e)
        {
            string userid = txt_employee_userID.Text;
            string password = txt_employee_password.Text;
            if(txt_employee_userID.Text != "" && txt_employee_password.Text != "")
            {
                SqlConnection dCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                dCon.Open();
                string query = "SELECT * FROM DB_Employee WHERE EmpID='" + userid + "' AND EmpPassword='" + password + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, dCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    /*
                    dCon.Close();
                    //loginIDCodeP = txt_admin_userID.Text;
                    empIDCodeRemember = userid;
                    Employee_Regestration regestration = new Employee_Regestration();
                    regestration.Show();
                    this.Hide();
                    */
                    if(dtb1.Rows[0]["isActivated"].ToString() != "1")
                    {
                        dCon.Close();
                        //loginIDCodeP = txt_admin_userID.Text;
                        empIDCodeRemember = userid;
                        Employee_Regestration regestration = new Employee_Regestration();
                        regestration.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Your account is alrady activated.");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Incorrect UserID or Password!");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter UserID and Password.");
            }
        }



        /*
        private void btn_GoMainPage_Click(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            mainPage.Show();
            this.Hide();
        }
        */
    }
}
