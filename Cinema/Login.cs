﻿using Cinema.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
            bs.CustomerLogin(UserID_tb.Text, Password_tb.Text, ref user, ref result);

            if (result) 
            {
                MessageBox.Show("Login Successfully");
                this.Hide();
                new Cinema { cus = this.user }.ShowDialog();
                base.Close();
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            new Register { }.ShowDialog();
        }
        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_btn_Click(sender, e);
            }
        }

        private void password_cb_Click(object sender, EventArgs e)
        {
            this.Password_tb.UseSystemPasswordChar = !password_cb.Checked;
        }
    }
}
