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
    public partial class AlmostFinish : Form
    {
        MyConnection conn = new MyConnection();
        public AlmostFinish()
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

        private void btnfinish_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Insert_StandardSettings";
            cmd.Connection = conn.mycon;
            cmd.Parameters.Add("@Name", Transfer.Name);
            cmd.Parameters.Add("@Address", Transfer.Address);
            cmd.Parameters.Add("@Company", Transfer.Company);
           
            cmd.Parameters.Add("@State", Transfer.State);
            cmd.Parameters.Add("@Country", Transfer.Country);
            cmd.Parameters.Add("@Contact", Transfer.Contact);
            cmd.Parameters.Add("@Alternate_Number", Transfer.Alternate_Number);
            
            cmd.Parameters.Add("@FAX_No", Transfer.FAX_No);
            cmd.Parameters.Add("@Email_ID", Transfer.Email_ID);
            cmd.Parameters.Add("@Store_Name", Transfer.Store_Name);
            cmd.Parameters.Add("@Owner", Transfer.Owner);
            cmd.Parameters.Add("@License_Holder", Transfer.License_Holder);
            cmd.Parameters.Add("@Registration_No", Transfer.Registration_No);
            cmd.Parameters.Add("@DL_No", Transfer.DL_No);
            cmd.Parameters.Add("@TIN_No", Transfer.TIN_No);

            cmd.Parameters.Add("@CST_No", Transfer.CST_No);
            cmd.Parameters.Add("@PAN_No", Transfer.PAN_No);



            cmd.Parameters.Add("@Office_Address", Transfer.Office_Address);
            cmd.Parameters.Add("@Office_City", Transfer.Office_City);
            cmd.Parameters.Add("@Office_State", Transfer.Office_State);
            cmd.Parameters.Add("@Office_Country", Transfer.Office_Country);
            cmd.Parameters.Add("@Office_Pincode", Transfer.Office_Pincode);
            cmd.Parameters.Add("@Office_Phone_No1", Transfer.Office_Phone_No1);
            cmd.Parameters.Add("@Office_Phone_No2", Transfer.Office_Phone_No2);
            cmd.Parameters.Add("@Office_Alternate_No", Transfer.Office_Alternate_No);

            cmd.Parameters.Add("@Office_Email_ID", Transfer.Office_Email_ID);
            cmd.Parameters.Add("@Office_Password", Transfer.Office_Password);
            cmd.Parameters.Add("@Username", Transfer.Username);
            cmd.Parameters.Add("@User_Password", Transfer.User_Password);
            cmd.Parameters.Add("@User_Confirm_Password", Transfer.User_Confirm_Password);
            cmd.Parameters.Add("@Expiry_Stock_Status", Transfer.Expiry_Stock_Status);

            cmd.Parameters.Add("@Alert_Before", Transfer.Alert_Before);

            conn.mycon.Open();
            cmd.ExecuteNonQuery();
            conn.mycon.Close();
          

        }
    }
}
