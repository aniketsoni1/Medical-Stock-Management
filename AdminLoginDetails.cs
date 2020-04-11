using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarryAndForwardAgent
{
    public partial class AdminLoginDetails : Form
    {
        public AdminLoginDetails()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Transfer.User_Password=txtusername.Text;
            Transfer.Username=txtpassword.Text;
            Transfer.User_Confirm_Password = txtconfirmpassword.Text;
            AlmostFinish am = new AlmostFinish();
            am.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            ExpiryStockAlert esa = new ExpiryStockAlert();
            esa.Show();
            this.Hide();
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "";

                txtusername.BackColor = Color.Red;
            }
        }
    }
}
