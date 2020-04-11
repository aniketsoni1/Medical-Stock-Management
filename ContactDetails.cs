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
    public partial class ContactDetails : Form
    {
        public ContactDetails()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ContactDetails_Load(object sender, EventArgs e)
        {
            if (Transfer.Office_Address != null)
            {
                txtaddress.Text = Transfer.Office_Address;
                txtcity.Text = Transfer.Office_City;
                txtstate.Text = Transfer.Office_State;
                txtcountry.Text = Transfer.Office_Country;
                txtpincode.Text = Transfer.Office_Pincode;
                txtmobileno.Text = Transfer.Office_Phone_No1;
                txtphno2.Text = Transfer.Office_Phone_No2;
                txtaltno.Text = Transfer.Office_Alternate_No;
                txtemailid.Text = Transfer.Office_Email_ID;
                txtfaxno.Text = Transfer.FAX_No;
                txtpassword.Text = Transfer.Office_Password;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            Transfer.Office_Address = txtaddress.Text;
            Transfer.Office_City = txtcity.Text;
            Transfer.Office_State = txtstate.Text;
            Transfer.Office_Country = txtcountry.Text;
            Transfer.Office_Pincode = txtpincode.Text;
            Transfer.Office_Phone_No1 = txtmobileno.Text;
            Transfer.Office_Phone_No2 = txtphno2.Text;
            Transfer.Office_Alternate_No = txtaltno.Text;
            Transfer.Office_Email_ID = txtemailid.Text;
            Transfer.FAX_No = txtfaxno.Text;
            Transfer.Office_Password = txtpassword.Text;
            ExpiryStockAlert gd = new ExpiryStockAlert();
            gd.Show();
            this.Hide();
        }

        private void txtmobileno_Leave(object sender, EventArgs e)
        {
            if (txtmobileno.Text == "")
            {
                txtmobileno.Text = "";

                txtmobileno.BackColor = Color.Red;
            }
        }

        private void txtmobileno_TextChanged(object sender, EventArgs e)
        {
            txtmobileno.BackColor = Color.White;
        }

        private void txtemailid_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");


            if (txtemailid.Text.Length > 0 || txtemailid.Text == "")
            {
                if (!rEMail.IsMatch(txtemailid.Text))
                {
                    txtemailid.BackColor = Color.Red;
                    txtemailid.SelectAll();
                    txtemailid.Focus();
                }
            }
        }

        private void txtemailid_TextChanged(object sender, EventArgs e)
        {
            txtemailid.BackColor = Color.White;
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "";

                txtpassword.BackColor = Color.Red;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            txtpassword.BackColor = Color.White;
        }
    }
}
