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
    public partial class product_Management : Form
    {
        public product_Management()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string shopID = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Product where productID = '" + shopID + "'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count == 1)
                {
                    txt_PiD.Text = dt.Rows[0]["productID"].ToString();
                    txt_Pname.Text = dt.Rows[0]["productName"].ToString();
                    txt_pAvailable.Text = dt.Rows[0]["productQuantity"].ToString();
                    txt_Pprice.Text = dt.Rows[0]["productPrice"].ToString();
                    txt_ShopID.Text = dt.Rows[0]["shopID"].ToString();
                }
                else
                {
                    txt_PiD.Text = "";
                    txt_Pname.Text = "";
                    txt_pAvailable.Text = "";
                    txt_Pprice.Text = "";
                    txt_ShopID.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Warning: \n" + "Click valid row!");
            }
        }

        private void product_Management_Load(object sender, EventArgs e)
        {
            
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Product ";
            SqlCommand cmd = new SqlCommand(query, DCon);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false;
            DCon.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
            this.Hide();
        }

        private void btn_deleteEmpAccount_Click(object sender, EventArgs e)
        {
            
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "delete from DB_Product where productID = '" + txt_PiD.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query, DCon);
            int row = cmd2.ExecuteNonQuery();
            if (row == 1)
            {
                MessageBox.Show("Successfully Deleted!");
                string query2 = "select * from DB_Product ";
                SqlCommand cmd = new SqlCommand(query2, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                //dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Refresh();
                txt_pAvailable.Text = "";
                txt_PiD.Text = "";
                txt_Pname.Text = "";
                txt_Pprice.Text = "";
                txt_ShopID.Text = "";

                //txt_shopID.Text = "";
                //txt_shopName.Text = "";
                //DCon.Close();
                //data_AdminProfile.Refresh();
                DCon.Close();
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Please select a row!");
            }
        }

        private void btn_updateInfo_Click(object sender, EventArgs e)
        {
            if (txt_PiD.Text != "")
            {
                int quantity;
                bool flagQuantity = false;
                float price;
                bool flagPrice = false;


                if (int.TryParse(txt_pAvailable.Text, out quantity))
                {
                    flagQuantity = true;
                }


                if (float.TryParse(txt_Pprice.Text, out price))
                {
                    flagPrice = true;
                }
                //int quantity = Int32.Parse(txt_pAvailable.Text);
                //float price = float.Parse(txt_Pprice.Text);
                if (flagPrice == true && flagQuantity == true)
                {
                    SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                    DCon.Open();
                    string query = "update DB_Product set productName = '" + txt_Pname.Text + "', productQuantity = '" + quantity + "', productPrice = '" + price + "'  where productID = '" + txt_PiD.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query, DCon);
                    int row = cmd2.ExecuteNonQuery();
                    if (row == 1)
                    {
                        string shopID = login_Shop.LoginIDCodeShop;
                        MessageBox.Show("Successfully Updated!");
                        string query2 = "select * from DB_Product";
                        SqlCommand cmd3 = new SqlCommand(query2, DCon);
                        cmd3.ExecuteNonQuery();
                        SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                        DataSet ds3 = new DataSet();
                        adp3.Fill(ds3);
                        DataTable dt3 = ds3.Tables[0];
                        dataGridView1.DataSource = dt3;
                        dataGridView1.Refresh();
                        DCon.Close();
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Something went wrong.");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Quantity should be in Intiger and Price should be in float.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Click valid row!");
            }
        }

        private void button1_Click(object sender, EventArgs e) //addProduct
        {
            int quantity;
            bool flagQuantity = false;
            float price;
            bool flagPrice = false;


            if (int.TryParse(txt_pAvailable.Text, out quantity))
            {
                flagQuantity = true;
            }


            if (float.TryParse(txt_Pprice.Text, out price))
            {
                flagPrice = true;
            }

            if (flagPrice == true && flagQuantity == true && txt_PiD.Text != "" && txt_Pname.Text != "" && txt_ShopID.Text != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query7 = "select * from DB_Shop where shopID = '" + txt_ShopID.Text + "'";
                SqlCommand cmd7 = new SqlCommand(query7, DCon);
                cmd7.ExecuteNonQuery();
                SqlDataAdapter adp7 = new SqlDataAdapter(cmd7);
                DataSet ds7 = new DataSet();
                adp7.Fill(ds7);
                DataTable dt7 = ds7.Tables[0];
                if(dt7.Rows.Count == 1)
                {
                    string query2 = "select * from DB_Product where productID = '" + txt_PiD.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(query2, DCon);
                    cmd3.ExecuteNonQuery();
                    SqlDataAdapter adp3 = new SqlDataAdapter(cmd3);
                    DataSet ds3 = new DataSet();
                    adp3.Fill(ds3);
                    DataTable dt3 = ds3.Tables[0];
                    if (dt3.Rows.Count == 0)
                    {
                        //DCon.Open();
                        string query =
                        "insert into DB_Product (productID, productName, shopID, productPrice,productQuantity ) values('" + txt_PiD.Text + "','" + txt_Pname.Text + "','" + txt_ShopID.Text + "' ," + price + ", " + quantity + ")";
                        SqlCommand cmd2 = new SqlCommand(query, DCon);
                        int row = cmd2.ExecuteNonQuery();
                        if (row == 1)
                        {

                            MessageBox.Show("Successfully Added!");
                            string query4 = "select * from DB_Product";
                            SqlCommand cmd = new SqlCommand(query4, DCon);
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            DataSet ds = new DataSet();
                            adp.Fill(ds);
                            DataTable dt = ds.Tables[0];
                            dataGridView1.DataSource = dt;
                            //dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.Refresh();
                            txt_pAvailable.Text = "";
                            txt_PiD.Text = "";
                            txt_Pname.Text = "";
                            txt_Pprice.Text = "";
                            txt_ShopID.Text = "";

                            //txt_shopID.Text = "";
                            //txt_shopName.Text = "";
                            //DCon.Close();
                            //data_AdminProfile.Refresh();
                            DCon.Close();
                        }
                        else
                        {
                            MessageBox.Show("Warning: \n" + "Something went wrong.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Warning: \n" + "Product ID must be unique.");
                    }
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "No Existing shop. You need to enter a existing shop.");
                }

            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter all information.");
            }
        }

        private void btn_searchShop_Click(object sender, EventArgs e)//search
        {
            if (txt_search.Text != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Product where productName like '%" + txt_search.Text + "%'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Product Found.");


                    txt_PiD.Text = dt.Rows[0]["productID"].ToString();
                    txt_Pname.Text = dt.Rows[0]["productName"].ToString();
                    txt_pAvailable.Text = dt.Rows[0]["productQuantity"].ToString();
                    txt_Pprice.Text = dt.Rows[0]["productPrice"].ToString();
                    txt_ShopID.Text = dt.Rows[0]["shopID"].ToString();

                    DCon.Close();
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Shop not found.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter something to search.");
            }
        }
    }
}
