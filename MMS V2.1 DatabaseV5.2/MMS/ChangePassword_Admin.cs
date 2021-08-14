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
    public partial class ChangePassword_Admin : Form
    {
        public ChangePassword_Admin()
        {
            InitializeComponent();
        }

        private void btn_Shop_Create_Click(object sender, EventArgs e)
        {
            if(txt_currentPass.Text != "" && txt_newPass.Text != "" && txt_conNewPass.Text != "")
            {
                string mngID = login_Admin.loginIDCodeP;
                string newPassword = txt_newPass.Text;
                string oldPaddword = txt_currentPass.Text;
                if (txt_newPass.Text == txt_conNewPass.Text)
                {
                    SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                    DCon.Open();
                    string query = "SELECT * FROM DB_Manager WHERE MngID='" + mngID + "' AND MngPassword='" + oldPaddword + "'";

                    SqlDataAdapter cmd = new SqlDataAdapter(query, DCon);
                    DataTable dtb1 = new DataTable();
                    cmd.Fill(dtb1);

                    if (dtb1.Rows.Count == 1)
                    {
                        string query2 = "update DB_Manager set MngPassword = '" + newPassword + "' where MngID = '" + mngID + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, DCon);
                        int row = cmd2.ExecuteNonQuery();
                        if (row == 1)
                        {
                            DCon.Close();
                            MessageBox.Show("Password Successfully updated!");
                            this.Close();
                            Admin_ProfilePage admin_profile = new Admin_ProfilePage();
                            admin_profile.Show();

                        }
                        else
                        {
                            MessageBox.Show("Warning: \n" + "Faild! Try again later!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Enter correct old password");
                    }

                }
                else
                {
                    MessageBox.Show("Warning: \n"+"New password and Confirm new password does not match.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Empty Field. Enter requred information.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
            this.Close();
        }
    }
}
