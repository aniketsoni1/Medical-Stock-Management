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
    public partial class Home : Form
    {
        MyConnection conn = new MyConnection();
        public Home()
        {
            InitializeComponent();
        }

        private void ThemesUpdater(string color)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Update_Themes";
            cmd.Connection = conn.mycon;
            cmd.Parameters.Add("@ThemeID", "1");
            cmd.Parameters.Add("@Themes", color);
            conn.mycon.Open();
            cmd.ExecuteNonQuery();
            conn.mycon.Close();
        }

        private void SystemLook_Load(object sender, EventArgs e)
        {
            string check;
            check = "Select * from ThemeUpdater";
            conn.mycon.Open();
            SqlCommand cmd = new SqlCommand(check, conn.mycon);
            SqlDataAdapter myadr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            myadr.Fill(dt);
            conn.mycon.Close();            

            if (dt.Rows.Count > 0)
            {
                if (blaToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.Black;
                    SystemMenu.BackColor = Color.FromArgb(29, 29, 29);

                    lavanderToolStripMenuItem.Checked = false;
                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = true;

                    colortheme(0, 0, 0);
                }
                if (redToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.FromArgb(102, 16, 40);
                    SystemMenu.BackColor = Color.FromArgb(189, 29, 73);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = true;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = false;


                    colortheme(102, 16, 40);

                }
                if (orangeToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.FromArgb(133, 49, 26);
                    SystemMenu.BackColor = Color.FromArgb(224, 82, 4);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = true;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = false;

                    colortheme(133, 49, 26);

                }
                if (blueToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {

                    this.BackColor = Color.FromArgb(20, 26, 114);
                    SystemMenu.BackColor = Color.FromArgb(8, 89, 196);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = true;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = false;


                    colortheme(20, 26, 114);
                }
                if (greenToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.FromArgb(0, 54, 0);
                    SystemMenu.BackColor = Color.FromArgb(1, 161, 1);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = true;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = false;

                    colortheme(0, 54, 0);

                }
                if (yellowToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {

                    ThemesUpdater(yellowToolStripMenuItem.Text);

                    this.BackColor = Color.FromArgb(68, 57, 2);
                    SystemMenu.BackColor = Color.FromArgb(218, 184, 8);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = true;
                    blaToolStripMenuItem.Checked = false;

                    colortheme(68, 57, 2);
                }
                if (blaToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.Black;
                    SystemMenu.BackColor = Color.FromArgb(29, 29, 29);

                    lavanderToolStripMenuItem.Checked = false;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = true;

                    colortheme(0, 0, 0);
                }
                if (lavanderToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
                {
                    this.BackColor = Color.FromArgb(36, 0, 64);
                    SystemMenu.BackColor = Color.FromArgb(93, 58, 184);

                    lavanderToolStripMenuItem.Checked = true;
                    redToolStripMenuItem.Checked = false;
                    orangeToolStripMenuItem.Checked = false;
                    blueToolStripMenuItem.Checked = false;
                    greenToolStripMenuItem.Checked = false;
                    yellowToolStripMenuItem.Checked = false;
                    blaToolStripMenuItem.Checked = false;

                    colortheme(36, 0, 64);
                }
            }
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenericAndProductwiseSearch gesrc = new GenericAndProductwiseSearch();
            gesrc.Show();
        }

        private void stockMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMaintenance stkm = new StockMaintenance();
            stkm.Show();
        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseOrder pror = new PurchaseOrder();
            pror.Show();
        }

        private void purchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseInvoice prsi = new PurchaseInvoice();
            prsi.Show();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReturn prrtn = new PurchaseReturn();
            prrtn.Show();
        }

        private void drugEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugEntry dren = new DrugEntry();
            dren.Show();
        }

        private void distributionEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DistributorEntry disen = new DistributorEntry();
            disen.Show();
        }

        private void clientEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientEntry clen = new ClientEntry();
            clen.Show();
        }

        private void generalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralDetail gendtl = new GeneralDetail();
            gendtl.Show();
        }

        private void stockAlertConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpiryStockAlert stkexpalrt = new ExpiryStockAlert();
            stkexpalrt.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuration cnfig = new Configuration();
            cnfig.Show();
        }

        private void damageReturmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageReturn dmrtn = new DamageReturn();
            dmrtn.Show();
        }

        private void expiryReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpiryReturn exprtn = new ExpiryReturn();
            exprtn.Show();
        }

        private void sendPurchaseInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendPurchaseOrder sndprhor = new SendPurchaseOrder();
            sndprhor.Show();
        }

        private void cashBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CashBill cshbll = new CashBill();
            cshbll.Show();
        }

        private void counterBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CounterBill ctrbll = new CounterBill();
            ctrbll.Show();
        }
        private void colortheme(int r, int g, int b)
        {
            searchToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cashBillToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            counterBillToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dummyBillToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            maintToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            salesReturnToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            purchaseInvoiceToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            purchaseOrderToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            purchaseReturnToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            damageReturmToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            expiryReturnToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            sendPurchaseInvoiceToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            drugEntryToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            distributionEntryToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            clientEntryToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            stockMaintenanceToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            paymentToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            receiptToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            creditNoteToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            debitNotesToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dayBookToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            bankAccountsToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            bankBookToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            chequeBookToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            chequeTransferToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            vATToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cRMToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            complaintsToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            eXITToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            themeToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            generalDetailsToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            toolStripMenuItem1.BackColor = Color.FromArgb(r, g, b);
            stockAlertConfigurationToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void oRANGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void yELLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bLAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void lUVANDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void blueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(blueToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(20, 26, 114);
            SystemMenu.BackColor = Color.FromArgb(8, 89, 196);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = false;


            colortheme(20, 26, 114);
        }

        private void greenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(greenToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(0, 54, 0);
            SystemMenu.BackColor = Color.FromArgb(1, 161, 1);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = true;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = false;

            colortheme(0, 54, 0);
        }

        private void lavanderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(lavanderToolStripMenuItem.Text);
            this.BackColor = Color.FromArgb(36, 0, 64);
            SystemMenu.BackColor = Color.FromArgb(93, 58, 184);

            lavanderToolStripMenuItem.Checked = true;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = false;

            colortheme(36, 0, 64);
        }

        private void blaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(blaToolStripMenuItem.Text);

            this.BackColor = Color.Black;
            SystemMenu.BackColor = Color.FromArgb(29, 29, 29);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = true;

            colortheme(0, 0, 0);
        }

        private void yellowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(yellowToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(68, 57, 2);
            SystemMenu.BackColor = Color.FromArgb(218, 184, 8);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = true;
            blaToolStripMenuItem.Checked = false;

            colortheme(68, 57, 2);
        }

        private void orangeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(orangeToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(133, 49, 26);
            SystemMenu.BackColor = Color.FromArgb(224, 82, 4);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            orangeToolStripMenuItem.Checked = true;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = false;

            colortheme(133, 49, 26);
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemesUpdater(redToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(102, 16, 40);
            SystemMenu.BackColor = Color.FromArgb(189, 29, 73);

            lavanderToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = true;
            orangeToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
            yellowToolStripMenuItem.Checked = false;
            blaToolStripMenuItem.Checked = false;


            colortheme(102, 16, 40);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
    }
}
