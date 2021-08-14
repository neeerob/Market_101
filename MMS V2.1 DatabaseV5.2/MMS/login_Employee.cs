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
    
    public partial class login_Employee : Form
    {
        public static string LoginIDCodeEmp = "";
        public login_Employee()
        {
            InitializeComponent();
        }

        private void btn_GoMainPage_Click(object sender, EventArgs e)
        {
            this.Close();
            Main_Page mainPage = new Main_Page();
            mainPage.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacts: 0183221313,23242323" + "\n Or visit www.something.com");
        }

        private void btn_Emp_Login_Click(object sender, EventArgs e)
        {
            if(txt_employee_userID.Text != "" && txt_employee_password.Text != "")
            {
                SqlConnection dCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                dCon.Open();
                string query = "SELECT * FROM DB_Employee WHERE EmpID='" + txt_employee_userID.Text + "' AND EmpPassword='" + txt_employee_password.Text + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, dCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    if(dtb1.Rows[0]["isActivated"].ToString() != "")
                    {
                        LoginIDCodeEmp = txt_employee_userID.Text;
                        profilePage_Employee empProfile = new profilePage_Employee();
                        this.Hide();
                        empProfile.Show();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "You need to activated your account first.");
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
    }
}
