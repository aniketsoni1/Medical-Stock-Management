namespace CarryAndForwardAgent
{
    partial class PurchaseOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltotalquantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbltotalproducts = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.purchaseordergridview = new System.Windows.Forms.DataGridView();
            this.Sr_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Packing_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.txtdlno = new System.Windows.Forms.TextBox();
            this.txtdistributorcode = new System.Windows.Forms.TextBox();
            this.txtdistributorname = new System.Windows.Forms.ComboBox();
            this.txtdeliverytype = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblorderno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnordernow = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseordergridview)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lbltotalquantity);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbltotalproducts);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.btnordernow);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(7, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 798);
            this.panel1.TabIndex = 41;
            // 
            // lbltotalquantity
            // 
            this.lbltotalquantity.AutoSize = true;
            this.lbltotalquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalquantity.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbltotalquantity.Location = new System.Drawing.Point(996, 679);
            this.lbltotalquantity.Name = "lbltotalquantity";
            this.lbltotalquantity.Size = new System.Drawing.Size(33, 36);
            this.lbltotalquantity.TabIndex = 88;
            this.lbltotalquantity.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label12.Location = new System.Drawing.Point(848, 679);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 36);
            this.label12.TabIndex = 87;
            this.label12.Text = "Quantity:";
            // 
            // lbltotalproducts
            // 
            this.lbltotalproducts.AutoSize = true;
            this.lbltotalproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproducts.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lbltotalproducts.Location = new System.Drawing.Point(328, 679);
            this.lbltotalproducts.Name = "lbltotalproducts";
            this.lbltotalproducts.Size = new System.Drawing.Size(33, 36);
            this.lbltotalproducts.TabIndex = 86;
            this.lbltotalproducts.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label10.Location = new System.Drawing.Point(171, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 36);
            this.label10.TabIndex = 85;
            this.label10.Text = "Products:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label9.Location = new System.Drawing.Point(40, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 31);
            this.label9.TabIndex = 40;
            this.label9.Text = "Purchase Order";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.purchaseordergridview);
            this.panel3.Location = new System.Drawing.Point(4, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1187, 354);
            this.panel3.TabIndex = 84;
            // 
            // purchaseordergridview
            // 
            this.purchaseordergridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sr_No,
            this.Company,
            this.Product_Name,
            this.Product_ID,
            this.Package,
            this.Quantity,
            this.Packing_No});
            this.purchaseordergridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseordergridview.Location = new System.Drawing.Point(0, 0);
            this.purchaseordergridview.Name = "purchaseordergridview";
            this.purchaseordergridview.RowTemplate.Height = 24;
            this.purchaseordergridview.Size = new System.Drawing.Size(1187, 354);
            this.purchaseordergridview.TabIndex = 7;
            this.purchaseordergridview.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.purchaseordergridview_RowLeave);
            this.purchaseordergridview.SelectionChanged += new System.EventHandler(this.purchaseordergridview_SelectionChanged);
            // 
            // Sr_No
            // 
            this.Sr_No.HeaderText = "Sr. No.";
            this.Sr_No.Name = "Sr_No";
            // 
            // Company
            // 
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            // 
            // Package
            // 
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Packing_No
            // 
            this.Packing_No.HeaderText = "Packing No.";
            this.Packing_No.Name = "Packing_No";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.txtaddress);
            this.panel2.Controls.Add(this.txtdlno);
            this.panel2.Controls.Add(this.txtdistributorcode);
            this.panel2.Controls.Add(this.txtdistributorname);
            this.panel2.Controls.Add(this.txtdeliverytype);
            this.panel2.Controls.Add(this.date);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lblorderno);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(4, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 263);
            this.panel2.TabIndex = 83;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(876, 151);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(263, 101);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.Text = "";
            // 
            // txtdlno
            // 
            this.txtdlno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdlno.Location = new System.Drawing.Point(876, 106);
            this.txtdlno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdlno.Name = "txtdlno";
            this.txtdlno.Size = new System.Drawing.Size(263, 34);
            this.txtdlno.TabIndex = 5;
            // 
            // txtdistributorcode
            // 
            this.txtdistributorcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistributorcode.Location = new System.Drawing.Point(876, 62);
            this.txtdistributorcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdistributorcode.Name = "txtdistributorcode";
            this.txtdistributorcode.Size = new System.Drawing.Size(263, 34);
            this.txtdistributorcode.TabIndex = 4;
            // 
            // txtdistributorname
            // 
            this.txtdistributorname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtdistributorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdistributorname.FormattingEnabled = true;
            this.txtdistributorname.Location = new System.Drawing.Point(876, 10);
            this.txtdistributorname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdistributorname.Name = "txtdistributorname";
            this.txtdistributorname.Size = new System.Drawing.Size(263, 37);
            this.txtdistributorname.TabIndex = 3;
            // 
            // txtdeliverytype
            // 
            this.txtdeliverytype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtdeliverytype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeliverytype.FormattingEnabled = true;
            this.txtdeliverytype.Location = new System.Drawing.Point(285, 106);
            this.txtdeliverytype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdeliverytype.Name = "txtdeliverytype";
            this.txtdeliverytype.Size = new System.Drawing.Size(263, 37);
            this.txtdeliverytype.TabIndex = 2;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(285, 64);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(167, 30);
            this.date.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(621, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 29);
            this.label8.TabIndex = 92;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(621, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 29);
            this.label7.TabIndex = 91;
            this.label7.Text = "D.L. No.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(621, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 90;
            this.label6.Text = "Distributor Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(621, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 29);
            this.label2.TabIndex = 89;
            this.label2.Text = "Distributor Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 88;
            this.label1.Text = "Delivery Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(49, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 87;
            this.label5.Text = "Date:";
            // 
            // lblorderno
            // 
            this.lblorderno.AutoSize = true;
            this.lblorderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorderno.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblorderno.Location = new System.Drawing.Point(280, 14);
            this.lblorderno.Name = "lblorderno";
            this.lblorderno.Size = new System.Drawing.Size(26, 29);
            this.lblorderno.TabIndex = 86;
            this.lblorderno.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(49, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 85;
            this.label3.Text = "Order No.:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1151, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1107, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 81;
            this.pictureBox3.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btncancel.Location = new System.Drawing.Point(796, 735);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(171, 58);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnreset.Location = new System.Drawing.Point(605, 734);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(171, 58);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnordernow
            // 
            this.btnordernow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnordernow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnordernow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnordernow.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnordernow.Location = new System.Drawing.Point(416, 734);
            this.btnordernow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnordernow.Name = "btnordernow";
            this.btnordernow.Size = new System.Drawing.Size(171, 58);
            this.btnordernow.TabIndex = 9;
            this.btnordernow.Text = "Order Now";
            this.btnordernow.UseVisualStyleBackColor = false;
            this.btnordernow.Click += new System.EventHandler(this.btnordernow_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnsave.Location = new System.Drawing.Point(221, 734);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(171, 58);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // PurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1208, 809);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PurchaseOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrder";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseordergridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnordernow;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblorderno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtdistributorname;
        private System.Windows.Forms.ComboBox txtdeliverytype;
        private System.Windows.Forms.TextBox txtdlno;
        private System.Windows.Forms.TextBox txtdistributorcode;
        private System.Windows.Forms.RichTextBox txtaddress;
        private System.Windows.Forms.Label lbltotalquantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbltotalproducts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView purchaseordergridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sr_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Packing_No;


    }
}