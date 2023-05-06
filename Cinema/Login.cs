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
        User user = new User();
        BL_Login bs = new BL_Login();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool result = false;
            if (Admin.Checked)
                bs.AdminLogin(UserID_tb.Text, Password_tb.Text, ref user, ref result);
            else
                bs.CustomerLogin(UserID_tb.Text, Password_tb.Text, ref user, ref result);

            if (result) 
            {
                MessageBox.Show("Successfully");
                this.Hide();
                if (Admin.Checked)
                    new Admin { admin = this.user }.ShowDialog();
                else
                    new Cinema { cus = this.user }.ShowDialog();
                base.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }
    }
}
