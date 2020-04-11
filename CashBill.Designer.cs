namespace CarryAndForwardAgent
{
    partial class CashBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cashbillgridview = new System.Windows.Forms.DataGridView();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NETRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discountpercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VATpercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADTpercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSTpercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.txtcustomername = new System.Windows.Forms.ComboBox();
            this.txtpreviousbill = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltinno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdbfree = new System.Windows.Forms.RadioButton();
            this.rdbcredit = new System.Windows.Forms.RadioButton();
            this.rdbcash = new System.Windows.Forms.RadioButton();
            this.txtdiscounts = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.txtproducts = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblvat = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbladt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcst = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.txtadjustamount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtroundoff = new System.Windows.Forms.TextBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblduebalance = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblgrandtotal = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnadjustamount = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashbillgridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 31);
            this.label9.TabIndex = 46;
            this.label9.Text = "Cash Bill";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(4, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 335);
            this.panel1.TabIndex = 144;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Controls.Add(this.cashbillgridview);
            this.panel4.Location = new System.Drawing.Point(3, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 206);
            this.panel4.TabIndex = 134;
            // 
            // cashbillgridview
            // 
            this.cashbillgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashbillgridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Company,
            this.Products,
            this.BatchNo,
            this.Expiry,
            this.MRP,
            this.Package,
            this.NETRate,
            this.Quantity,
            this.Discountpercentage,
            this.VATpercentage,
            this.ADTpercentage,
            this.CSTpercentage,
            this.Amount});
            this.cashbillgridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashbillgridview.Location = new System.Drawing.Point(0, 0);
            this.cashbillgridview.Name = "cashbillgridview";
            this.cashbillgridview.RowTemplate.Height = 24;
            this.cashbillgridview.Size = new System.Drawing.Size(1186, 206);
            this.cashbillgridview.TabIndex = 0;
            // 
            // SrNo
            // 
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.Name = "Products";
            // 
            // BatchNo
            // 
            this.BatchNo.HeaderText = "Batch No.";
            this.BatchNo.Name = "BatchNo";
            // 
            // Expiry
            // 
            this.Expiry.HeaderText = "Expiry";
            this.Expiry.Name = "Expiry";
            // 
            // MRP
            // 
            this.MRP.HeaderText = "MRP";
            this.MRP.Name = "MRP";
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            // 
            // NETRate
            // 
            this.NETRate.HeaderText = "NET Rate";
            this.NETRate.Name = "NETRate";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Discountpercentage
            // 
            this.Discountpercentage.HeaderText = "Discount%";
            this.Discountpercentage.Name = "Discountpercentage";
            // 
            // VATpercentage
            // 
            this.VATpercentage.HeaderText = "VAT%";
            this.VATpercentage.Name = "VATpercentage";
            // 
            // ADTpercentage
            // 
            this.ADTpercentage.HeaderText = "ADT%";
            this.ADTpercentage.Name = "ADTpercentage";
            // 
            // CSTpercentage
            // 
            this.CSTpercentage.HeaderText = "CST%";
            this.CSTpercentage.Name = "CSTpercentage";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.txtcustomername);
            this.panel2.Controls.Add(this.txtpreviousbill);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbltinno);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 118);
            this.panel2.TabIndex = 0;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(973, 11);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(167, 30);
            this.date.TabIndex = 3;
            // 
            // txtcustomername
            // 
            this.txtcustomername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomername.FormattingEnabled = true;
            this.txtcustomername.Location = new System.Drawing.Point(276, 72);
            this.txtcustomername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(263, 37);
            this.txtcustomername.TabIndex = 2;
            // 
            // txtpreviousbill
            // 
            this.txtpreviousbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtpreviousbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpreviousbill.FormattingEnabled = true;
            this.txtpreviousbill.Location = new System.Drawing.Point(276, 10);
            this.txtpreviousbill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpreviousbill.Name = "txtpreviousbill";
            this.txtpreviousbill.Size = new System.Drawing.Size(263, 37);
            this.txtpreviousbill.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(896, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 103;
            this.label4.Text = "Date:";
            // 
            // lbltinno
            // 
            this.lbltinno.AutoSize = true;
            this.lbltinno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinno.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbltinno.Location = new System.Drawing.Point(728, 13);
            this.lbltinno.Name = "lbltinno";
            this.lbltinno.Size = new System.Drawing.Size(26, 29);
            this.lbltinno.TabIndex = 102;
            this.lbltinno.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(619, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 101;
            this.label2.Text = "TIN No.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 100;
            this.label1.Text = "Customer Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(46, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 29);
            this.label13.TabIndex = 99;
            this.label13.Text = "Previous Bill:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.rdbfree);
            this.panel3.Controls.Add(this.rdbcredit);
            this.panel3.Controls.Add(this.rdbcash);
            this.panel3.Location = new System.Drawing.Point(30, 383);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(254, 57);
            this.panel3.TabIndex = 1;
            // 
            // rdbfree
            // 
            this.rdbfree.AutoSize = true;
            this.rdbfree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbfree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbfree.Location = new System.Drawing.Point(176, 16);
            this.rdbfree.Name = "rdbfree";
            this.rdbfree.Size = new System.Drawing.Size(64, 24);
            this.rdbfree.TabIndex = 6;
            this.rdbfree.TabStop = true;
            this.rdbfree.Text = "Free";
            this.rdbfree.UseVisualStyleBackColor = true;
            // 
            // rdbcredit
            // 
            this.rdbcredit.AutoSize = true;
            this.rdbcredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcredit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbcredit.Location = new System.Drawing.Point(89, 16);
            this.rdbcredit.Name = "rdbcredit";
            this.rdbcredit.Size = new System.Drawing.Size(75, 24);
            this.rdbcredit.TabIndex = 5;
            this.rdbcredit.TabStop = true;
            this.rdbcredit.Text = "Credit";
            this.rdbcredit.UseVisualStyleBackColor = true;
            // 
            // rdbcash
            // 
            this.rdbcash.AutoSize = true;
            this.rdbcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbcash.Location = new System.Drawing.Point(7, 16);
            this.rdbcash.Name = "rdbcash";
            this.rdbcash.Size = new System.Drawing.Size(69, 24);
            this.rdbcash.TabIndex = 4;
            this.rdbcash.TabStop = true;
            this.rdbcash.Text = "Cash";
            this.rdbcash.UseVisualStyleBackColor = true;
            // 
            // txtdiscounts
            // 
            this.txtdiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscounts.Location = new System.Drawing.Point(130, 519);
            this.txtdiscounts.Name = "txtdiscounts";
            this.txtdiscounts.Size = new System.Drawing.Size(157, 26);
            this.txtdiscounts.TabIndex = 9;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(130, 482);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(157, 26);
            this.txtquantity.TabIndex = 8;
            // 
            // txtproducts
            // 
            this.txtproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducts.Location = new System.Drawing.Point(130, 446);
            this.txtproducts.Name = "txtproducts";
            this.txtproducts.Size = new System.Drawing.Size(157, 26);
            this.txtproducts.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(26, 522);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 20);
            this.label18.TabIndex = 147;
            this.label18.Text = "Discount";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(26, 484);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 146;
            this.label17.Text = "Quantity";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(26, 449);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 20);
            this.label16.TabIndex = 145;
            this.label16.Text = "Products";
            // 
            // lblvat
            // 
            this.lblvat.AutoSize = true;
            this.lblvat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvat.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblvat.Location = new System.Drawing.Point(141, 575);
            this.lblvat.Name = "lblvat";
            this.lblvat.Size = new System.Drawing.Size(31, 20);
            this.lblvat.TabIndex = 152;
            this.lblvat.Text = "0.0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label26.Location = new System.Drawing.Point(26, 575);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(87, 20);
            this.label26.TabIndex = 151;
            this.label26.Text = "VAT (4%):";
            // 
            // lbladt
            // 
            this.lbladt.AutoSize = true;
            this.lbladt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladt.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbladt.Location = new System.Drawing.Point(141, 610);
            this.lbladt.Name = "lbladt";
            this.lbladt.Size = new System.Drawing.Size(31, 20);
            this.lbladt.TabIndex = 154;
            this.lbladt.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(26, 610);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 153;
            this.label6.Text = "ADT TAX:";
            // 
            // lblcst
            // 
            this.lblcst.AutoSize = true;
            this.lblcst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcst.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblcst.Location = new System.Drawing.Point(141, 643);
            this.lblcst.Name = "lblcst";
            this.lblcst.Size = new System.Drawing.Size(31, 20);
            this.lblcst.TabIndex = 156;
            this.lblcst.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(26, 643);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 155;
            this.label8.Text = "CST TAX:";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(483, 482);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(157, 26);
            this.txtsubtotal.TabIndex = 13;
            // 
            // txttotalamount
            // 
            this.txttotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamount.Location = new System.Drawing.Point(483, 446);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.Size = new System.Drawing.Size(157, 26);
            this.txttotalamount.TabIndex = 12;
            // 
            // txtadjustamount
            // 
            this.txtadjustamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadjustamount.Location = new System.Drawing.Point(483, 398);
            this.txtadjustamount.Name = "txtadjustamount";
            this.txtadjustamount.Size = new System.Drawing.Size(157, 26);
            this.txtadjustamount.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(332, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 159;
            this.label10.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(332, 484);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 158;
            this.label11.Text = "Subtotal";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(332, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 157;
            this.label12.Text = "Total Amount";
            // 
            // txtroundoff
            // 
            this.txtroundoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroundoff.Location = new System.Drawing.Point(483, 551);
            this.txtroundoff.Name = "txtroundoff";
            this.txtroundoff.Size = new System.Drawing.Size(157, 26);
            this.txtroundoff.TabIndex = 15;
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(483, 519);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(157, 26);
            this.txtbalance.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(332, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 20);
            this.label14.TabIndex = 164;
            this.label14.Text = "Adjust Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(332, 554);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 20);
            this.label15.TabIndex = 163;
            this.label15.Text = "Roundoff";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label35.Location = new System.Drawing.Point(679, 397);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(21, 29);
            this.label35.TabIndex = 168;
            this.label35.Text = "-";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label34.Location = new System.Drawing.Point(646, 400);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(27, 29);
            this.label34.TabIndex = 167;
            this.label34.Text = "+";
            // 
            // lblduebalance
            // 
            this.lblduebalance.AutoSize = true;
            this.lblduebalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduebalance.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblduebalance.Location = new System.Drawing.Point(917, 477);
            this.lblduebalance.Name = "lblduebalance";
            this.lblduebalance.Size = new System.Drawing.Size(45, 29);
            this.lblduebalance.TabIndex = 138;
            this.lblduebalance.Text = "0.0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(750, 477);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 29);
            this.label20.TabIndex = 137;
            this.label20.Text = "Balance Due:";
            // 
            // lblgrandtotal
            // 
            this.lblgrandtotal.AutoSize = true;
            this.lblgrandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrandtotal.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblgrandtotal.Location = new System.Drawing.Point(1037, 446);
            this.lblgrandtotal.Name = "lblgrandtotal";
            this.lblgrandtotal.Size = new System.Drawing.Size(118, 54);
            this.lblgrandtotal.TabIndex = 170;
            this.lblgrandtotal.Text = "0.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label22.Location = new System.Drawing.Point(1075, 415);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 31);
            this.label22.TabIndex = 169;
            this.label22.Text = "Total";
            // 
            // btnadjustamount
            // 
            this.btnadjustamount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadjustamount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadjustamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadjustamount.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnadjustamount.Location = new System.Drawing.Point(755, 398);
            this.btnadjustamount.Name = "btnadjustamount";
            this.btnadjustamount.Size = new System.Drawing.Size(188, 35);
            this.btnadjustamount.TabIndex = 11;
            this.btnadjustamount.Text = "Adjust Amount";
            this.btnadjustamount.UseVisualStyleBackColor = false;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnreset.Location = new System.Drawing.Point(812, 643);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(160, 55);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnreport.Location = new System.Drawing.Point(623, 643);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(160, 55);
            this.btnreport.TabIndex = 18;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnsave.Location = new System.Drawing.Point(429, 643);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(160, 55);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnprint.Location = new System.Drawing.Point(1002, 559);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(160, 55);
            this.btnprint.TabIndex = 16;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btncancel.Location = new System.Drawing.Point(1002, 643);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(160, 55);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarryAndForwardAgent.Properties.Resources.logo_close;
            this.pictureBox2.Location = new System.Drawing.Point(1161, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarryAndForwardAgent.Properties.Resources.logo_minimize;
            this.pictureBox3.Location = new System.Drawing.Point(1117, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 142;
            this.pictureBox3.TabStop = false;
            // 
            // CashBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnadjustamount);
            this.Controls.Add(this.lblgrandtotal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lblduebalance);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtroundoff);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.txttotalamount);
            this.Controls.Add(this.txtadjustamount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblcst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbladt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblvat);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtdiscounts);
            this.Controls.Add(this.txtquantity);
            this.Controls.Add(this.txtproducts);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashBill";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CashBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashbillgridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltinno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox txtcustomername;
        private System.Windows.Forms.ComboBox txtpreviousbill;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.RadioButton rdbfree;
        private System.Windows.Forms.RadioButton rdbcredit;
        private System.Windows.Forms.RadioButton rdbcash;
        private System.Windows.Forms.TextBox txtdiscounts;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox txtproducts;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblvat;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbladt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcst;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.TextBox txtadjustamount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtroundoff;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label lblduebalance;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblgrandtotal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnadjustamount;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView cashbillgridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn NETRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discountpercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn VATpercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADTpercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSTpercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}