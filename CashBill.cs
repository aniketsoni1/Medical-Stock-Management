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
    public partial class CashBill : Form
    {
        public CashBill()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CashBill_Load(object sender, EventArgs e)
        {

        }
        public void Reset()
        {
            txtpreviousbill.Text = "";
            txtcustomername.Text = "";
            lbltinno.Text = "";
            date.Text = "";
            txtproducts.Text = "";
            txtquantity.Text = "";
            txtdiscounts.Text = "";
            txtadjustamount.Text = "";
            txttotalamount.Text = "";
            txtsubtotal.Text = "";
            txtbalance.Text = "";
            txtroundoff.Text = "";
            cashbillgridview.Rows.Clear();
            lblvat.Text = "0.0";
            lbladt.Text = "0.0";
            lblcst.Text = "0.0";
            lblduebalance.Text = "0.0";
            lblgrandtotal.Text = "0.00";
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
