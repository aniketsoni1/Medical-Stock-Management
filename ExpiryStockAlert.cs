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
    public partial class ExpiryStockAlert : Form
    {
        public ExpiryStockAlert()
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
        }
        private void rdbtnenable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnenable.Checked == true)
            {
                panel2.Visible = true;
                Transfer.Expiry_Stock_Status = "Enable";
            }
        }
        private void rdbtndisable_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbtndisable.Checked == true)
            {
                panel2.Visible = false;
                Transfer.Expiry_Stock_Status = "Disable";
            }
        }
        private void rdbtndays_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbtnenable.Checked == true)
            {
                if (rdbtnmonths.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxmonths.Text + "Months";
                }
                else if (rdbtnweeks.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxweeks.Text + "Weeks";
                }

                else if (rdbtndays.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxdays.Text + "Days";
                }

            }
        }

        private void rdbtnweeks_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdbtnenable.Checked == true)
            {
                if (rdbtnmonths.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxmonths.Text + "Months";
                }
                else if (rdbtnweeks.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxweeks.Text + "Weeks";
                }

                else if (rdbtndays.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxdays.Text + "Days";
                }

            }
        }

        private void rdbtnmonths_CheckedChanged_1(object sender, EventArgs e)
        {

            if (rdbtnenable.Checked == true)
            {
                if (rdbtnmonths.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxmonths.Text + "Months";
                }
                else if (rdbtnweeks.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxweeks.Text + "Weeks";
                }

                else if (rdbtndays.Checked == true)
                {
                    Transfer.Alert_Before = cmbbxdays.Text + "Days";
                }

            }
        }

        private void btnnext_Click_1(object sender, EventArgs e)
        {
            //   panel2.Visible = true;
            AdminLoginDetails ald = new AdminLoginDetails();
            ald.Show();
            this.Hide();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContactDetails cd = new ContactDetails();
            cd.Show();
                this.Hide();
        }

        private void ExpiryStockAlert_Load(object sender, EventArgs e)
        {

        }
    }
}
