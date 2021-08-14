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
    public partial class login_Admin : Form
    {
        public static string loginIDCodeP = "";
        public login_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Page mainPage = new Main_Page();
            mainPage.Show();
            this.Close();
        }

        private void btn_Admin_Login_Click(object sender, EventArgs e)
        {

            if(txt_admin_userID.Text != "" && txt_admin_password.Text != "")
            {
                SqlConnection dCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                dCon.Open();
                string query = "SELECT * FROM DB_Manager WHERE MngID='" + txt_admin_userID.Text + "' AND MngPassword='" + txt_admin_password.Text + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(query, dCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);

                if (dtb1.Rows.Count == 1)
                {
                    dCon.Close();
                    loginIDCodeP = txt_admin_userID.Text;
                    Admin_ProfilePage adminProfile = new Admin_ProfilePage();
                    adminProfile.Show();
                    this.Close();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacts: 0183221313,23242323" + "\n Or visit www.something.com");
        }

        /*
        private void Admin_Login_Load(object sender, EventArgs e)
        {

        }
        */
    }
}
