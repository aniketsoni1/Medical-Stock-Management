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
    public partial class Temp_Form : Form
    {
        MyConnection con = new MyConnection();
        public Temp_Form()
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_Insert_Temp_Table";
                cmd.Connection = con.mycon;

                cmd.Parameters.Add("@Name", textBox1.Text);
                cmd.Parameters.Add("@Address", richTextBox1.Text);
                cmd.Parameters.Add("@Phone_No", textBox2.Text);
                cmd.Parameters.Add("@Email_ID", textBox3.Text);
                cmd.Parameters.Add("@Item_No", dataGridView1.Rows[i].Cells[0].Value.ToString());
                cmd.Parameters.Add("@Item_Name", dataGridView1.Rows[i].Cells[1].Value.ToString());
                cmd.Parameters.Add("@Quantity", dataGridView1.Rows[i].Cells[2].Value.ToString());
                cmd.Parameters.Add("@Item_Cost", dataGridView1.Rows[i].Cells[3].Value.ToString());
                cmd.Parameters.Add("@Discount", dataGridView1.Rows[i].Cells[4].Value.ToString());
                cmd.Parameters.Add("@Total_Amount", dataGridView1.Rows[i].Cells[5].Value.ToString());

                cmd.Parameters.Add("@Grand_Amount", label2.Text);
                con.mycon.Open();
                cmd.ExecuteNonQuery();
                con.mycon.Close();
            }
            MessageBox.Show("Insert Successful");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            total();
            grandtotal();
        }


        public void total()
        {
            decimal a;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                a = Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                a = a - Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                (dataGridView1.Rows[i].Cells[5].Value) = a.ToString();
            }
        }
        public void grandtotal()
        {
            decimal a=0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
               a = a + Convert.ToDecimal(dataGridView1.Rows[i].Cells[5].Value);
               label2.Text = a.ToString();
            }
        }
    }
}
