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
    public partial class GeneralDetail : Form
    {
        public GeneralDetail()
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
            Transfer.Store_Name = txtstorename.Text;
            Transfer.Owner=txtownername.Text;
            Transfer.License_Holder=txtlicenseholder.Text;
            Transfer.Registration_No=txtuserregisterno.Text;
            Transfer.DL_No=txtuserdlno.Text;
            Transfer.TIN_No=txtusertinno.Text;
            Transfer.CST_No=txtusercstno.Text;
            Transfer.PAN_No=txtuserpanno.Text;
            ContactDetails cd = new ContactDetails();
            cd.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }
    }
}
