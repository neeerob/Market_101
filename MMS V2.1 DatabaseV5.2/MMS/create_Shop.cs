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
    public partial class create_Shop : Form
    {
        public create_Shop()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
        }

        private void btn_Shop_Create_Click(object sender, EventArgs e)
        {
            string shopName = "";
            string shopID = "";
            bool Bshop = false;
            bool BsID = false;
            string correctness = "";
            if (txt_ShopName.Text != "")
            {
                shopName = txt_ShopName.Text;
                Bshop = true;
            }
            if (txt_ShopID.Text != "")
            {
                shopID = txt_ShopID.Text;
                BsID = true;
            }

            if (Bshop == false)
                correctness += "Shop Name ";
            if (BsID == false)
                correctness += "Shop ID";


            if (BsID == true && Bshop == true)
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string check = "select * from DB_Shop where shopID = '" + shopID + "'";
                //SqlCommand cmd = new SqlCommand(check,DCon);
                //int checkRow = cmd.ExecuteNonQuery();
                SqlDataAdapter cmd = new SqlDataAdapter(check, DCon);
                DataTable dtb1 = new DataTable();
                cmd.Fill(dtb1);
                DCon.Close();
                if (dtb1.Rows.Count == 0 )
                {
                    DCon.Open();
                    string query =
                    "insert into DB_Shop (shopID, shopName) values('" + shopID + "','" + shopName + "')";
                    SqlCommand cmd2 = new SqlCommand(query, DCon);
                    int row = cmd2.ExecuteNonQuery();
                    if (row == 1)
                    {
                        MessageBox.Show("Successfully created ! ");
                        DCon.Close();
                        this.Close();
                        Admin_ProfilePage adminProfile = new Admin_ProfilePage();
                        adminProfile.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Shop alrady existed! Change Shop ID. ");
                }

            }

            else
            {
                MessageBox.Show("Warning: \n" + "Check " + correctness + " field");
            }
        }
    }
}
