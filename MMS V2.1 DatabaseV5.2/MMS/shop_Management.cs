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
    public partial class shop_Management : Form
    {
        public shop_Management()
        {
            InitializeComponent();
        }

        private void shop_Management_Load(object sender, EventArgs e)
        {
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "select * from DB_Shop";
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
            if(e.RowIndex >= 0)
            {
                string shopID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Shop where shopID = '"+shopID+"'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if(dt.Rows.Count == 1)
                {
                    txt_shopID.Text = dt.Rows[0]["shopID"].ToString();
                    txt_shopName.Text = dt.Rows[0]["shopName"].ToString();
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

        private void button2_Click(object sender, EventArgs e)//goback
        {
            Admin_ProfilePage adminProfile = new Admin_ProfilePage();
            adminProfile.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) // update
        {
            if(txt_shopName.Text != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "update DB_Shop set shopName = '"+txt_shopName.Text+"' where shopID = '"+txt_shopID.Text+"'";
                SqlCommand cmd2 = new SqlCommand(query, DCon);
                int row = cmd2.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Successfully Updated!");
                    string query2 = "select * from DB_Shop";
                    SqlCommand cmd = new SqlCommand(query2, DCon);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();
                    DCon.Close();
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
                MessageBox.Show("Warning: \n" + "Please click a cell.");
            }
        }

        private void button1_Click(object sender, EventArgs e)//delete
        {
            SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
            DCon.Open();
            string query = "delete from DB_Shop where shopID = '" + txt_shopID.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query, DCon);
            int row = cmd2.ExecuteNonQuery();
            if (row == 1)
            {
                MessageBox.Show("Successfully Deleted!");
                string query2 = "select * from DB_Shop";
                SqlCommand cmd = new SqlCommand(query2, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                txt_shopID.Text = "";
                txt_shopName.Text = "";
                //DCon.Close();
                //data_AdminProfile.Refresh();
                DCon.Close();
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Please select a row.!");
            }

        }

        private void btn_changePassword_Click(object sender, EventArgs e)//search
        {
            if(txt_changePassword.Text != "")
            {
                SqlConnection DCon = new SqlConnection(@"Data Source=DESKTOP-JB55370;Initial Catalog=MMS;Integrated Security=True");
                DCon.Open();
                string query = "select * from DB_Shop where shopID = '" + txt_changePassword.Text + "'";
                SqlCommand cmd = new SqlCommand(query, DCon);
                cmd.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];

                if(dt.Rows.Count == 1)
                {
                    MessageBox.Show("Shop Found.");
                    txt_shopID.Text = dt.Rows[0]["shopID"].ToString();
                    txt_shopName.Text = dt.Rows[0]["shopName"].ToString();
                    DCon.Close();
                }
                else
                {
                    MessageBox.Show("Warning: \n" + "Shop not found.");
                }
            }
            else
            {
                MessageBox.Show("Warning: \n" + "Enter shopID.");
            }
        }
    }
}
