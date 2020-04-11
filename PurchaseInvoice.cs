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
    public partial class PurchaseInvoice : Form
    {
        MyConnection con = new MyConnection();

        public PurchaseInvoice()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Insert_PurchaseInvoice";
                cmd.Connection = con.mycon;

                cmd.Parameters.Add("@GRN_No", lblGRNNo.Text);
                cmd.Parameters.Add("@Last_Invoice", lblLastInvoice.Text);
                cmd.Parameters.Add("@Invoice_No", txtinvoiceno.Text);
                cmd.Parameters.Add("@Parcel_No", txtparcelno.Text);
                cmd.Parameters.Add("@Date", date.Text);
                cmd.Parameters.Add("@Distributor_Name", txtdistributorname.Text);
                cmd.Parameters.Add("@Distributor_Code", txtdistributorcode.Text);
                cmd.Parameters.Add("@DL_No", txtdlno.Text);
                cmd.Parameters.Add("@Address", txtaddress.Text);
                cmd.Parameters.Add("@Previous_Purchase_Order", txtprevpurchordr.Text);
                cmd.Parameters.Add("@Company", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.Add("@Product_Name", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.Add("@Package", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.Add("@Total_Products", txtproducts.Text);
                cmd.Parameters.Add("@Total_Quantity", txtquantity.Text);
                cmd.Parameters.Add("@Total_Free_Quantity", txtfreequantity.Text);
                cmd.Parameters.Add("@Subtotal", txtsubtotal.Text);
                cmd.Parameters.Add("@Roundoff", txtroundoff.Text);
                cmd.Parameters.Add("@Discount_Amount", txtdiscntamt.Text);
                cmd.Parameters.Add("@Cash_Discount_Amount", txtcashdiscntamt.Text);
                cmd.Parameters.Add("@PR_Number", txtprnumber.Text);
                cmd.Parameters.Add("@Invoice_Amount", txtinvoiceamt.Text);
                cmd.Parameters.Add("@Adjust_Invoice_Amount", txtadjstinvcamt.Text);
                cmd.Parameters.Add("@Total_VAT_4", lblttlvat4.Text);
                cmd.Parameters.Add("@Total_VAT_0", lblttlvat0.Text);
                cmd.Parameters.Add("@Total_ADT", lblttladt.Text);
                cmd.Parameters.Add("@Total_CST", lblttlcst.Text);
                cmd.Parameters.Add("@Grand_TOTAL", lblTotal.Text);

                con.mycon.Open();
                cmd.ExecuteNonQuery();
                con.mycon.Close();
            }
            MessageBox.Show("Insert Successful");
            Reset();
        }

        //public void srno()
        //{
        //    int i = 1;
        //    foreach (DataGridViewRow row in purchaseinvoicegridview.Rows)
        //    {
        //        row.Cells[0].Value = i;
        //        i++;
        //    }
        //}

        //public void totalproducts()
        //{

        //    int i = 0;
        //    foreach (DataGridViewRow row in purchaseinvoicegridview.Rows)
        //    {
        //        row.Cells[0].Value = i;
        //        i++;

        //        int a = i - 1;
        //        txtproducts.Text = a.ToString();
        //    }
        //}

        //public void totalquantity()
        //{
        //    decimal quantity = 0;
        //    for (int i = 0; i < purchaseinvoicegridview.Rows.Count - 1; i++)
        //    {
        //        quantity = quantity + Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[7].Value);
        //        txtquantity.Text = quantity.ToString();
        //    }
        //}
        //public void totalfreequantity()
        //{
        //    decimal freequantity = 0;
        //    for (int i = 0; i < purchaseinvoicegridview.Rows.Count - 1; i++)
        //    {
        //        freequantity = freequantity + Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[8].Value);
        //        txtfreequantity.Text = freequantity.ToString();
        //    }
        //}

        public void Reset()
        {
            txtinvoiceno.Text="";
            txtparcelno.Text="";
            txtdistributorname.Text="";
            txtdistributorcode.Text="";
            txtdlno.Text="";
            txtaddress.Text="";
            txtprevpurchordr.Text="";
            dataGridView1.Rows.Clear();
            txtproducts.Text="";
            txtquantity.Text="";
            txtfreequantity.Text="";
            txtsubtotal.Text="";
            txtroundoff.Text="";
            txtdiscntamt.Text="";
            txtcashdiscntamt.Text="";
            txtprnumber.Text="";
            txtinvoiceamt.Text="";
            txtadjstinvcamt.Text="";
            lblttlvat4.Text="0.0";
            lblttlvat0.Text="0.0";
            lblttladt.Text="0.0";
            lblttlcst.Text="0.0";
            lblTotal.Text = "0.00";
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        //public void total()
        //{
        //    decimal a;
        //    for (int i = 0; i < purchaseinvoicegridview.Rows.Count - 1; i++)
        //    {
        //        a = Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[9].Value) * (Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[7].Value) - Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[8].Value));
        //        a = a - Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[12].Value);
        //        (purchaseinvoicegridview.Rows[i].Cells[16].Value) = a.ToString();
        //    }
        //}

        //public void Grand_Total()
        //{
        //    decimal a = 0;
        //    for (int i = 0; i < purchaseinvoicegridview.Rows.Count - 1; i++)
        //    {
        //        a = a + Convert.ToDecimal(purchaseinvoicegridview.Rows[i].Cells[16].Value);
        //        lblTotal.Text = a.ToString();
        //    }
        //}
        //private void purchaseinvoicegridview_SelectionChanged(object sender, EventArgs e)
        //{
        //    totalproducts();
        //    totalquantity();
        //    totalfreequantity();
        //    srno();
        //    Grand_Total();
        //}

        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {

        }
    }
}
