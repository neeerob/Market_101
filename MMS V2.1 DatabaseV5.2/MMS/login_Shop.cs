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
    public partial class login_Shop : Form
    {

        public static string LoginIDCodeShop = "";
        public login_Shop()
        {
            InitializeComponent();
        }

        private void btn_GoMainPage_Click(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            mainPage.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacts: 0183221313,23242323" + "\n Or visit www.something.com");
        }

        private void btn_Emp_Login_Click(object sender, EventArgs e)
        {
            if (txt_employee_userID.Text != "" && txt_employee_password.Text != "" && txt_shopID.Text != "")
            {
                SqlConnection dCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                dCon.Open();
                string query = "SELECT * FROM DB_Employee WHERE EmpID = '"+txt_employee_userID.Text+"' and EmpPassword = '"+txt_employee_password.Text+"' and EmpAssignedShop = '"+txt_shopID.Text+ "' and isActivated = '1'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, dCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    if (dtb1.Rows[0]["IsManagerOfAShop"].ToString() == "YES" || dtb1.Rows[0]["IsManagerOfAShop"].ToString() == "Yes")
                    {
                        LoginIDCodeShop = txt_shopID.Text;
                        profilePage_Shop shopProfile = new profilePage_Shop();
                        shopProfile.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "You don't have manager previlage.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Wrong UserName or ID.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter UserID and Password.");
            }
        }
    }
}
