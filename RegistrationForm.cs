using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarryAndForwardAgent
{
    public partial class RegistrationForm : Form
    {
        MyConnection conn = new MyConnection();
        public RegistrationForm()
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
            Transfer.Name = txtfirstname.Text + " " + txtlastname.Text;
            Transfer.Company = txtusercompany.Text;
            Transfer.Address = txtuseraddress.Text;
            Transfer.State = txtuserstate.Text;
            Transfer.Country = txtusercountry.Text;
            Transfer.Contact = txtusercontact.Text;
            Transfer.Alternate_Number = txtuseralterno.Text;
            Transfer.Email_ID = txtuseremailid.Text;
            GeneralDetail gd = new GeneralDetail();
            gd.Show();
            this.Hide();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string str = "select * from StandardSettings";
            conn.mycon.Open();
            SqlCommand cmd = new SqlCommand(str, conn.mycon);
            SqlDataAdapter myadr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            myadr.Fill(dt);
            conn.mycon.Close();
            //if (dt.Rows.Count > 0)
            //{
            //    UserLogin gd = new UserLogin();
            //    gd.Show();
            //    this.Close();
            //}
            if (Transfer.Name != null)
            {
                txtfirstname.Text = Transfer.Name;
                txtusercompany.Text = Transfer.Company;
                txtuseraddress.Text = Transfer.Address;
                txtuserstate.Text = Transfer.State;
                txtusercountry.Text = Transfer.Country;
                txtusercontact.Text = Transfer.Contact;
                txtuseralterno.Text = Transfer.Alternate_Number;
                txtuseremailid.Text = Transfer.Email_ID;
            }
        }

        private void txtfirstname_Leave(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "")
            {
                txtfirstname.Text = "";

                txtfirstname.BackColor = Color.Red;
            }
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {
            txtfirstname.BackColor = Color.White;
        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {
            if (txtlastname.Text == "")
            {
                txtlastname.Text = "";

                txtlastname.BackColor = Color.Red;
            }
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {
            txtlastname.BackColor = Color.White;
        }

        private void txtuserstate_Leave(object sender, EventArgs e)
        {
            if (txtuserstate.Text == "")
            {
                txtuserstate.Text = "";

                txtuserstate.BackColor = Color.Red;
            }
        }

        private void txtuserstate_TextChanged(object sender, EventArgs e)
        {
            txtuserstate.BackColor = Color.White;
        }

        private void txtuseraddress_Leave(object sender, EventArgs e)
        {
            if (txtuseraddress.Text == "")
            {
                txtuseraddress.Text = "";

                txtuseraddress.BackColor = Color.Red;
            }
        }

        private void txtuseraddress_TextChanged(object sender, EventArgs e)
        {
            txtuseraddress.BackColor = Color.White;
        }

        private void txtuseremailid_Leave(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");


            if (txtuseremailid.Text.Length > 0 || txtuseremailid.Text=="")
            {
                if (!rEMail.IsMatch(txtuseremailid.Text))
                {
                    txtuseremailid.BackColor = Color.Red;
                    txtuseremailid.SelectAll();
                    txtuseremailid.Focus();
                }
            }
        }

        private void txtuseremailid_TextChanged(object sender, EventArgs e)
        {
            txtuseremailid.BackColor = Color.White;
        }

        private void txtusercountry_Leave(object sender, EventArgs e)
        {
            if (txtusercountry.Text == "")
            {
                txtusercountry.Text = "";

                txtusercountry.BackColor = Color.Red;
            }
        }

        private void txtusercountry_TextChanged(object sender, EventArgs e)
        {
            txtusercountry.BackColor = Color.White;
        }

        private void txtusercontact_Leave(object sender, EventArgs e)
        {
            if (txtusercontact.Text == "")
            {
                txtusercontact.Text = "";

                txtusercontact.BackColor = Color.Red;
            }
        }

        private void txtusercontact_TextChanged(object sender, EventArgs e)
        {
            txtusercontact.BackColor = Color.White;
        }
    }
}
