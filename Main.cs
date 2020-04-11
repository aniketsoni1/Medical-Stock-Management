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
    public partial class Main : Form
    {

        int id1;
        private bool purchase_open = false;
        //PurchaseInvoice pi;
        int check = 1;
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ThemesUpdater(string color)
        {

        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
           


            //conn.myconn.Close();
            //string check;
            //check = "Select * from ThemesUpdater";
            //conn.myconn.Open();
            //SqlCommand cmd = new SqlCommand(check, conn.myconn);
            //SqlDataAdapter myadr = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //myadr.Fill(dt);
            //conn.myconn.Close();

            //if (dt.Rows.Count > 0)
            //{
            //    if (bLACKToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.Black;
            //        menuStrip1.BackColor = Color.FromArgb(29, 29, 29);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = true;

            //        colortheme(0, 0, 0);
            //    }
            //    if (rEDToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.FromArgb(102, 16, 40);
            //        menuStrip1.BackColor = Color.FromArgb(189, 29, 73);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = true;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = false;


            //        colortheme(102, 16, 40);

            //    }
            //    if (oRANGEToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.FromArgb(133, 49, 26);
            //        menuStrip1.BackColor = Color.FromArgb(224, 82, 4);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = true;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = false;

            //        colortheme(133, 49, 26);

            //    }
            //    if (bLUEToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {

            //        this.BackColor = Color.FromArgb(20, 26, 114);
            //        menuStrip1.BackColor = Color.FromArgb(8, 89, 196);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = true;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = false;


            //        colortheme(20, 26, 114);
            //    }
            //    if (gREENToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.FromArgb(0, 54, 0);
            //        menuStrip1.BackColor = Color.FromArgb(1, 161, 1);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = true;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = false;

            //        colortheme(0, 54, 0);

            //    }
            //    if (yELLOWToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {

            //        ThemesUpdater(yELLOWToolStripMenuItem.Text);

            //        this.BackColor = Color.FromArgb(68, 57, 2);
            //        menuStrip1.BackColor = Color.FromArgb(218, 184, 8);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = true;
            //        bLACKToolStripMenuItem.Checked = false;

            //        colortheme(68, 57, 2);
            //    }
            //    if (bLACKToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.Black;
            //        menuStrip1.BackColor = Color.FromArgb(29, 29, 29);

            //        lUVANDERToolStripMenuItem.Checked = false;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = true;

            //        colortheme(0, 0, 0);
            //    }
            //    if (lUVANDERToolStripMenuItem.Text == dt.Rows[0].ItemArray[1].ToString())
            //    {
            //        this.BackColor = Color.FromArgb(36, 0, 64);
            //        menuStrip1.BackColor = Color.FromArgb(93, 58, 184);

            //        lUVANDERToolStripMenuItem.Checked = true;
            //        rEDToolStripMenuItem.Checked = false;
            //        oRANGEToolStripMenuItem.Checked = false;
            //        bLUEToolStripMenuItem.Checked = false;
            //        gREENToolStripMenuItem.Checked = false;
            //        yELLOWToolStripMenuItem.Checked = false;
            //        bLACKToolStripMenuItem.Checked = false;

            //        colortheme(36, 0, 64);
            //    }

            //    panel1.Left = this.Width / 2 - panel1.Size.Width / 2;
            //    panel1.Top = this.Height / 2 - panel1.Size.Height / 2;
            //}

            //string str;
            //str = "select AlertBefore,AlertOption from ExpiryAlertMaster";
            //conn.myconn.Open();
            //SqlCommand cmd1 = new SqlCommand(str, conn.myconn);
            //SqlDataAdapter myadr1 = new SqlDataAdapter(cmd1);
            //DataTable dt1 = new DataTable();
            //myadr1.Fill(dt1);
            //conn.myconn.Close();
            //if (dt1.Rows.Count > 0)
            //{
            //    int a = Convert.ToInt32(dt1.Rows[0].ItemArray[0].ToString());
            //    string b = dt1.Rows[0].ItemArray[1].ToString();
            //}


        }

        private void gENERICSEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cASHBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cOUNTERBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dUMMYBILLToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void rETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mAINTAINANCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pURCHASEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void pURCHASEINVOICEToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void pURCHASERETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dAMAGEDSTOCKToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void eXPIRYRETURNToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void sENDPURCHASEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dRUGDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void dISTRIBUTORDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eMPLOYEEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pAYMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rECEIPTToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cREDITNOTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dEBITNOTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void dAYBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void bANKACCOUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void bANKBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cHEQUEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cHEQUETRANToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void vATREGISTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cUTOMERALERTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void cOMPLToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void lUVANDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(lUVANDERToolStripMenuItem.Text);
            this.BackColor = Color.FromArgb(36, 0, 64);
            menuStrip1.BackColor = Color.FromArgb(93, 58, 184);

            lUVANDERToolStripMenuItem.Checked = true;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = false;

            colortheme(36, 0, 64);

            //gENERICSEARCHToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //bACKUPToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //eXITToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cASHBILLToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cOUNTERBILLToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dUMMYBILLToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //mAINTAINANCEToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //rETURNToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //pURCHASEINVOICEToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //pURCHASEORDERToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //pURCHASERETURNToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dAMAGEDSTOCKToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //eXPIRYRETURNToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //sTOCKToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //sENDPURCHASEORDERToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dRUGDETAILSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dISTRIBUTORDETAILSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //eMPLOYEEDETAILSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //pAYMENTToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //rECEIPTToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cREDITNOTSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dEBITNOTESToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //dAYBOOKToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //bANKACCOUNTSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //bANKBOOKToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cHEQUEBOOKToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cHEQUETRANToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //vATREGISTORToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cUTOMERALERTSToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //cOMPLToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);
            //eXITToolStripMenuItem1.BackColor = Color.FromArgb(36, 0, 64);
            //tHEMESToolStripMenuItem.BackColor = Color.FromArgb(36, 0, 64);


        }

        private void colortheme(int r, int g, int b)
        {
            gENERICSEARCHToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            bACKUPToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            eXITToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cASHBILLToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cOUNTERBILLToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dUMMYBILLToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            mAINTAINANCEToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            rETURNToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            pURCHASEINVOICEToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            pURCHASEORDERToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            pURCHASERETURNToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dAMAGEDSTOCKToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            eXPIRYRETURNToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            //   sTOCKToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            sENDPURCHASEORDERToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dRUGDETAILSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dISTRIBUTORDETAILSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            eMPLOYEEDETAILSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            sTOCKMAINTAINToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            pAYMENTToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            rECEIPTToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cREDITNOTSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dEBITNOTESToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            dAYBOOKToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            bANKACCOUNTSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            bANKBOOKToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cHEQUEBOOKToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cHEQUETRANToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            vATREGISTORToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cUTOMERALERTSToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cOMPLToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            eXITToolStripMenuItem1.BackColor = Color.FromArgb(r, g, b);
            tHEMESToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            contactGeneralDetailToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            emailPhoneConfigcsToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            expiryStockAlertToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            vATMASTERToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            aDTTAXMASTERToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
            cSTTAXMASTERToolStripMenuItem.BackColor = Color.FromArgb(r, g, b);
        }

        private void rEDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(rEDToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(102, 16, 40);
            menuStrip1.BackColor = Color.FromArgb(189, 29, 73);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = true;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = false;


            colortheme(102, 16, 40);
        }

        private void oRANGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(oRANGEToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(133, 49, 26);
            menuStrip1.BackColor = Color.FromArgb(224, 82, 4);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = true;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = false;

            colortheme(133, 49, 26);
        }

        private void bLUEToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ThemesUpdater(bLUEToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(20, 26, 114);
            menuStrip1.BackColor = Color.FromArgb(8, 89, 196);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = true;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = false;


            colortheme(20, 26, 114);
        }

        private void gREENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(gREENToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(0, 54, 0);
            menuStrip1.BackColor = Color.FromArgb(1, 161, 1);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = true;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = false;

            colortheme(0, 54, 0);
        }

        private void yELLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(yELLOWToolStripMenuItem.Text);

            this.BackColor = Color.FromArgb(68, 57, 2);
            menuStrip1.BackColor = Color.FromArgb(218, 184, 8);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = true;
            bLACKToolStripMenuItem.Checked = false;

            colortheme(68, 57, 2);
        }

        private void bLACKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemesUpdater(bLACKToolStripMenuItem.Text);

            this.BackColor = Color.Black;
            menuStrip1.BackColor = Color.FromArgb(29, 29, 29);

            lUVANDERToolStripMenuItem.Checked = false;
            rEDToolStripMenuItem.Checked = false;
            oRANGEToolStripMenuItem.Checked = false;
            bLUEToolStripMenuItem.Checked = false;
            gREENToolStripMenuItem.Checked = false;
            yELLOWToolStripMenuItem.Checked = false;
            bLACKToolStripMenuItem.Checked = true;

            colortheme(0, 0, 0);
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          
        }

        private void tHEMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactGeneralDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void expiryStockAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void emailPhoneConfigcsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void vATMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void aDTTAXMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cSTTAXMASTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        //public void daybook()
        //{
        //    string d1;
        //    DateTime dat = Convert.ToDateTime(System.DateTime.Now);
        //    d1 = dat.ToString("MM/dd/yyyy 00:00:00");

        //    string d2;
        //    DateTime dat1 = Convert.ToDateTime(System.DateTime.Now);
        //    d2 = dat1.ToString("MM/dd/yyyy 23:59:59");

        //    string str = "Select * from DayBook where Date between '" + d1 + "' and '" + d2 + "'";
        //    conn.myconn.Open();
        //    SqlCommand cmd = new SqlCommand(str, conn.myconn);
        //    SqlDataAdapter myadr = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    myadr.Fill(dt);
        //    conn.myconn.Close();


        //    if (dt.Rows.Count == 0)
        //    {
        //        string date;
        //        date = " select ClosingBalance From DayBook where ID=(select MAX(ID) from DayBook)";
        //        conn.myconn.Open();
        //        SqlCommand cmd1 = new SqlCommand(date, conn.myconn);
        //        SqlDataAdapter myadr1 = new SqlDataAdapter(cmd1);
        //        DataTable dt1 = new DataTable();
        //        myadr1.Fill(dt1);
        //        conn.myconn.Close();
        //        if (dt1.Rows.Count > 0)
        //        {
        //            SqlCommand cmd2 = new SqlCommand();
        //            cmd2.CommandType = CommandType.StoredProcedure;
        //            cmd2.CommandText = "SP_Insert_DayBook";
        //            cmd2.Connection = conn.myconn;
        //            cmd2.Parameters.Add("@Date", System.DateTime.Now);
        //            cmd2.Parameters.Add("@OpeningBalance", dt1.Rows[0].ItemArray[0].ToString());
        //            cmd2.Parameters.Add("@ClosingBalance", dt1.Rows[0].ItemArray[0].ToString());
        //            cmd2.Parameters.Add("@Receipt", "0.00");
        //            cmd2.Parameters.Add("@Payment", "0.00");
        //            cmd2.Parameters.Add("@BankWithdrawal", "0.00");
        //            cmd2.Parameters.Add("@BankDeposite", "0.00");
        //            cmd2.Parameters.Add("@CashIntroduced", "0.00");
        //            cmd2.Parameters.Add("@CashWithdrawal", "0.00");
        //            cmd2.Parameters.Add("@OtherExpanses", "0.00");
        //            cmd2.Parameters.Add("@DebitNote", "0.00");
        //            cmd2.Parameters.Add("@CreditNote", "0.00");

        //            conn.myconn.Open();
        //            cmd2.ExecuteNonQuery();
        //            conn.myconn.Close();
        //        }
        //        else
        //        {
        //            SqlCommand cmd2 = new SqlCommand();
        //            cmd2.CommandType = CommandType.StoredProcedure;
        //            cmd2.CommandText = "SP_Insert_DayBook";
        //            cmd2.Connection = conn.myconn;
        //            cmd2.Parameters.Add("@Date", System.DateTime.Now);
        //            cmd2.Parameters.Add("@OpeningBalance", "0.00");
        //            cmd2.Parameters.Add("@ClosingBalance", "0.00");
        //            cmd2.Parameters.Add("@Receipt", "0.00");
        //            cmd2.Parameters.Add("@Payment", "0.00");
        //            cmd2.Parameters.Add("@BankWithdrawal", "0.00");
        //            cmd2.Parameters.Add("@BankDeposite", "0.00");
        //            cmd2.Parameters.Add("@CashIntroduced", "0.00");
        //            cmd2.Parameters.Add("@CashWithdrawal", "0.00");
        //            cmd2.Parameters.Add("@OtherExpanses", "0.00");
        //            cmd2.Parameters.Add("@DebitNote", "0.00");
        //            cmd2.Parameters.Add("@CreditNote", "0.00");

        //            conn.myconn.Open();
        //            cmd2.ExecuteNonQuery();
        //            conn.myconn.Close();
        //        }
        //    }
        //    else
        //    {
        //        decimal ope = Convert.ToDecimal(dt.Rows[0].ItemArray[2].ToString());
        //        decimal clo = Convert.ToDecimal(dt.Rows[0].ItemArray[3].ToString());

        //        string s = "Select Max(ID) from DayBook Where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cm = new SqlCommand(s, conn.myconn);
        //        SqlDataAdapter myad = new SqlDataAdapter(cm);
        //        DataTable d = new DataTable();
        //        myad.Fill(d);
        //        conn.myconn.Close();
        //        if (d.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            id1 = Convert.ToInt32(d.Rows[0].ItemArray[0].ToString());
        //        }


        //        string s1;
        //        s1 = "Select sum(AmountPaid) from Receive where PaymentType='BY CASH' and Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd3 = new SqlCommand(s1, conn.myconn);
        //        SqlDataAdapter myadr3 = new SqlDataAdapter(cmd3);
        //        DataTable dt3 = new DataTable();
        //        myadr3.Fill(dt3);
        //        conn.myconn.Close();
        //        decimal a;
        //        if (dt3.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            a = Convert.ToDecimal(dt3.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            a = Convert.ToDecimal("0.00");
        //        }


        //        string s2;
        //        s2 = "Select sum(PaidAmount) from Payment where PaymentType='BY CASH' and Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd4 = new SqlCommand(s2, conn.myconn);
        //        SqlDataAdapter myadr4 = new SqlDataAdapter(cmd4);
        //        DataTable dt4 = new DataTable();
        //        myadr4.Fill(dt4);
        //        conn.myconn.Close();
        //        decimal b;
        //        if (dt4.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            b = Convert.ToDecimal(dt4.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            b = Convert.ToDecimal("0.00");
        //        }

        //        string s3;
        //        s3 = "select Sum(Credit) from BankBook where TransactionType='CREDIT' and Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd5 = new SqlCommand(s3, conn.myconn);
        //        SqlDataAdapter myadr5 = new SqlDataAdapter(cmd5);
        //        DataTable dt5 = new DataTable();
        //        myadr5.Fill(dt5);
        //        conn.myconn.Close();
        //        decimal c;
        //        if (dt5.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            c = Convert.ToDecimal(dt5.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            c = Convert.ToDecimal("0.00");
        //        }

        //        string s4;
        //        s4 = "select sum(Debit) from BankBook where TransactionType='DEBIT' and Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd6 = new SqlCommand(s4, conn.myconn);
        //        SqlDataAdapter myadr6 = new SqlDataAdapter(cmd6);
        //        DataTable dt6 = new DataTable();
        //        myadr6.Fill(dt6);
        //        conn.myconn.Close();
        //        decimal e;
        //        if (dt6.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            e = Convert.ToDecimal(dt6.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            e = Convert.ToDecimal("0.00");
        //        }

        //        string s5;
        //        s5 = "select Sum(Amount) from DebitNote where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd8 = new SqlCommand(s5, conn.myconn);
        //        SqlDataAdapter myadr8 = new SqlDataAdapter(cmd8);
        //        DataTable dt8 = new DataTable();
        //        myadr8.Fill(dt8);
        //        conn.myconn.Close();
        //        decimal f;
        //        if (dt8.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            f = Convert.ToDecimal(dt8.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            f = Convert.ToDecimal("0.00");
        //        }

        //        string s6;
        //        s6 = "select Sum(Amount) from CreditNote where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd9 = new SqlCommand(s6, conn.myconn);
        //        SqlDataAdapter myadr9 = new SqlDataAdapter(cmd9);
        //        DataTable dt9 = new DataTable();
        //        myadr9.Fill(dt9);
        //        conn.myconn.Close();
        //        decimal g;
        //        if (dt9.Rows[0].ItemArray[0].ToString() != "")
        //        {
        //            g = Convert.ToDecimal(dt9.Rows[0].ItemArray[0].ToString());
        //        }
        //        else
        //        {
        //            g = Convert.ToDecimal("0.00");
        //        }



        //        string str5 = "select sum(CashIntroduced) from DayBook where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd10 = new SqlCommand(str5, conn.myconn);
        //        SqlDataAdapter myadr10 = new SqlDataAdapter(cmd10);
        //        DataTable dt10 = new DataTable();
        //        myadr10.Fill(dt10);
        //        conn.myconn.Close();
        //        decimal x = Convert.ToDecimal(dt10.Rows[0].ItemArray[0].ToString());

        //        string str6 = "select sum(CashWithdrawal) from DayBook where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd11 = new SqlCommand(str6, conn.myconn);
        //        SqlDataAdapter myadr11 = new SqlDataAdapter(cmd11);
        //        DataTable dt11 = new DataTable();
        //        myadr11.Fill(dt11);
        //        conn.myconn.Close();
        //        decimal y = Convert.ToDecimal(dt11.Rows[0].ItemArray[0].ToString());


        //        string str7 = "select sum(OtherExpanses) from DayBook where Date between '" + d1 + "' and '" + d2 + "'";
        //        conn.myconn.Open();
        //        SqlCommand cmd12 = new SqlCommand(str7, conn.myconn);
        //        SqlDataAdapter myadr12 = new SqlDataAdapter(cmd12);
        //        DataTable dt12 = new DataTable();
        //        myadr12.Fill(dt12);
        //        conn.myconn.Close();
        //        decimal z = Convert.ToDecimal(dt12.Rows[0].ItemArray[0].ToString());

        //        decimal gt = Convert.ToDecimal(a) + Convert.ToDecimal(e) + Convert.ToDecimal(f) + x;
        //        decimal kt = Convert.ToDecimal(b) + Convert.ToDecimal(c) + Convert.ToDecimal(g) + y + z;

        //        decimal pt = gt - kt;
        //        pt = pt + ope;
        //        clo = pt;

        //        SqlCommand cmd7 = new SqlCommand();
        //        cmd7.CommandType = CommandType.StoredProcedure;
        //        cmd7.CommandText = "SP_Update_DayBook";
        //        cmd7.Connection = conn.myconn;
        //        cmd7.Parameters.Add("@ID", id1);
        //        cmd7.Parameters.Add("@Date", System.DateTime.Now);
        //        cmd7.Parameters.Add("@OpeningBalance", ope);
        //        cmd7.Parameters.Add("@ClosingBalance", clo);
        //        cmd7.Parameters.Add("@Receipt", a);
        //        cmd7.Parameters.Add("@Payment", b);
        //        cmd7.Parameters.Add("@BankWithdrawal", c);
        //        cmd7.Parameters.Add("@BankDeposite", e);
        //        cmd7.Parameters.Add("@CashIntroduced", x);
        //        cmd7.Parameters.Add("@CashWithdrawal", y);
        //        cmd7.Parameters.Add("@OtherExpanses", z);
        //        cmd7.Parameters.Add("@DebitNote", f);
        //        cmd7.Parameters.Add("@CreditNote", g);

        //        conn.myconn.Open();
        //        cmd7.ExecuteNonQuery();
        //        conn.myconn.Close();

        //    }
        //}

        private void sTOCKMAINTAINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
