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
    public partial class PurchaseOrder : Form
    {
        MyConnection con = new MyConnection();
        public PurchaseOrder()
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
            for (int i = 0; i < purchaseordergridview.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Insert_PurchaseOrder";
                cmd.Connection = con.mycon;

                cmd.Parameters.Add("@Order_No", lblorderno.Text);
                cmd.Parameters.Add("@Date", Convert.ToDateTime(date.Text));
                cmd.Parameters.Add("@Delivery_Type", txtdeliverytype.Text);
                cmd.Parameters.Add("@Distributor_Name", txtdistributorname.Text);
                cmd.Parameters.Add("@Distributor_Code", txtdistributorcode.Text);
                cmd.Parameters.Add("@DL_No", txtdlno.Text);
                cmd.Parameters.Add("@Address", txtaddress.Text);
                cmd.Parameters.Add("@Company", purchaseordergridview.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.Add("@Product_Name", purchaseordergridview.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.Add("@Package_ID", purchaseordergridview.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.Add("@Package", purchaseordergridview.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.Add("@Quantity", purchaseordergridview.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.Add("@Packing_No", purchaseordergridview.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.Add("@Total_Products", lbltotalproducts.Text);
                cmd.Parameters.Add("@Total_Quantity", lbltotalquantity.Text);

                con.mycon.Open();
                cmd.ExecuteNonQuery();
                con.mycon.Close();
            }
            MessageBox.Show("Insert Successful");
            Reset();
        }
        public void totalproducts()
        {

            int i = 0;
            foreach (DataGridViewRow row in purchaseordergridview.Rows)
            {
                row.Cells[0].Value = i;
                i++;

                int a =  i-1;
                lbltotalproducts.Text = a.ToString();
            }

        }

        public void totalquantity()
        {
            decimal quantity = 0;
            for (int i = 0; i < purchaseordergridview.Rows.Count - 1; i++)
            {
                quantity = quantity + Convert.ToDecimal(purchaseordergridview.Rows[i].Cells[5].Value);
                lbltotalquantity.Text = quantity.ToString();
            }
        }


        public void srno()
        {
            int i = 1;
            foreach (DataGridViewRow row in purchaseordergridview.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void purchaseordergridview_SelectionChanged(object sender, EventArgs e)
        {
            totalproducts();
            totalquantity();
            srno();
        }
        public void Reset()
        {
            txtdeliverytype.Text = "";
            txtdistributorname.Text = "";
            txtdistributorcode.Text = "";
            txtdlno.Text = "";
            txtaddress.Text="";
            purchaseordergridview.Rows.Clear();
            lbltotalproducts.Text = "0";
            lbltotalquantity.Text = "0";
        }
        private void purchaseordergridview_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnordernow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < purchaseordergridview.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Insert_PurchaseOrder";
                cmd.Connection = con.mycon;

                cmd.Parameters.Add("@Order_No", lblorderno.Text);
                cmd.Parameters.Add("@Date", Convert.ToDateTime(date.Text));
                cmd.Parameters.Add("@Delivery_Type", txtdeliverytype.Text);
                cmd.Parameters.Add("@Distributor_Name", txtdistributorname.Text);
                cmd.Parameters.Add("@Distributor_Code", txtdistributorcode.Text);
                cmd.Parameters.Add("@DL_No", txtdlno.Text);
                cmd.Parameters.Add("@Address", txtaddress.Text);
                cmd.Parameters.Add("@Company", purchaseordergridview.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.Add("@Product_Name", purchaseordergridview.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.Add("@Package_ID", purchaseordergridview.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.Add("@Package", purchaseordergridview.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.Add("@Quantity", purchaseordergridview.Rows[i].Cells[5].Value.ToString());
                cmd.Parameters.Add("@Packing_No", purchaseordergridview.Rows[i].Cells[6].Value.ToString());
                cmd.Parameters.Add("@Total_Products", lbltotalproducts.Text);
                cmd.Parameters.Add("@Total_Quantity", lbltotalquantity.Text);

                con.mycon.Open();
                cmd.ExecuteNonQuery();
                con.mycon.Close();
            }
            MessageBox.Show("Order Successfully Place");
            Reset();
        }
    }
}
