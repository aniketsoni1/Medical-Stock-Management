using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace CarryAndForwardAgent
{
    public partial class UserLogin : Form
    {
        MyConnection conn = new MyConnection();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RegistrationForm regfrm = new RegistrationForm();
            regfrm.Show();
            this.Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
           

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           
        }

        private void lblforgotloginpassword_Click(object sender, EventArgs e)
        {
            string str = "select Email_ID, Username, User_Password from StandardSettings";
            conn.mycon.Open();
            SqlCommand cmd = new SqlCommand(str, conn.mycon);
            SqlDataAdapter myadr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            myadr.Fill(dt);
            conn.mycon.Close();

            string a = dt.Rows[0].ItemArray[0].ToString();
            string b = dt.Rows[0].ItemArray[1].ToString();
            string c = dt.Rows[0].ItemArray[2].ToString();


            MailMessage objMail = new MailMessage();

            MailAddress msFrom = new MailAddress("esteemeddemo@gmail.com");
            MailAddress msTo = new MailAddress(a);
            objMail.From = msFrom;

            objMail.To.Add(msTo);

            objMail.Subject = "From CarryandForwardAgent";
            objMail.Body = "Your Username is: '"+ b +"' Your Forget Password is :'" + c +"'";
            objMail.IsBodyHtml = true;
            System.Net.Mail.SmtpClient serverSystem = new SmtpClient("smtp.gmail.com");


            serverSystem.UseDefaultCredentials = false;

            serverSystem.EnableSsl = true;

            serverSystem.Credentials = new System.Net.NetworkCredential("esteemeddemo@gmail.com", "esteemed123456");

            serverSystem.Port = 587;
            try
            {
                serverSystem.Send(objMail);
                MessageBox.Show("Mail Send Sucessfully...!!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error occured during sending mail " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            String str1 = "select Username, User_Password from StandardSettings";
            SqlCommand cmd = new SqlCommand(str1, conn.mycon);
            SqlDataAdapter adr1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adr1.Fill(dt1);
            conn.mycon.Close();
            if (txtloginusername.Text == dt1.Rows[0].ItemArray[1].ToString() && txtloginpassword.Text == dt1.Rows[0].ItemArray[1].ToString())
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User or Password");
            }
        }
    }
}
