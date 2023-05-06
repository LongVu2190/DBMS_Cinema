using Cinema.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Login : Form
    {
        Customer cus = new Customer();
        BL_Login bs = new BL_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool result = false;
            bs.Login(UserID_tb.Text, Password_tb.Text, ref cus, ref result);
            if (result) 
            {
                MessageBox.Show("Successfully");
                this.Hide();
                new Cinema { cus = this.cus }.ShowDialog();
                base.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
