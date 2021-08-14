using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMS
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_Admin adminLogin = new login_Admin();
            adminLogin.Show();
            this.Hide();
        }

        private void btn_loginAs_Emp_Click(object sender, EventArgs e)
        {
            login_Employee employeeLogin = new login_Employee();
            employeeLogin.Show();
            this.Hide();
        }

        private void btn_loginAs_shopMng_Click(object sender, EventArgs e)
        {
            login_Shop shopLogin = new login_Shop();
            shopLogin.Show();
            this.Hide();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Contacts: 0183221313,23242323" + "\n Or visit www.something.com");
        }

        private void btn_Acticate_EmpAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            activate_Emp_AccountLogin activate = new activate_Emp_AccountLogin();
            activate.Show();
        }
    }
}
