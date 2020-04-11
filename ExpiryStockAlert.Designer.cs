namespace CarryAndForwardAgent
{
    partial class ExpiryStockAlert
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtndisable = new System.Windows.Forms.RadioButton();
            this.rdbtnenable = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbxdays = new System.Windows.Forms.ComboBox();
            this.rdbtndays = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbbxweeks = new System.Windows.Forms.ComboBox();
            this.rdbtnweeks = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbxmonths = new System.Windows.Forms.ComboBox();
            this.rdbtnmonths = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.rdbtndisable);
            this.panel1.Controls.Add(this.rdbtnenable);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(41, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 354);
            this.panel1.TabIndex = 3;
            // 
            // rdbtndisable
            // 
            this.rdbtndisable.AutoSize = true;
            this.rdbtndisable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtndisable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbtndisable.Location = new System.Drawing.Point(579, 51);
            this.rdbtndisable.Name = "rdbtndisable";
            this.rdbtndisable.Size = new System.Drawing.Size(116, 33);
            this.rdbtndisable.TabIndex = 13;
            this.rdbtndisable.TabStop = true;
            this.rdbtndisable.Text = "Disable";
            this.rdbtndisable.UseVisualStyleBackColor = true;
            this.rdbtndisable.CheckedChanged += new System.EventHandler(this.rdbtndisable_CheckedChanged);
            // 
            // rdbtnenable
            // 
            this.rdbtnenable.AutoSize = true;
            this.rdbtnenable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnenable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbtnenable.Location = new System.Drawing.Point(290, 51);
            this.rdbtnenable.Name = "rdbtnenable";
            this.rdbtnenable.Size = new System.Drawing.Size(110, 33);
            this.rdbtnenable.TabIndex = 12;
            this.rdbtnenable.TabStop = true;
            this.rdbtnenable.Text = "Enable";
            this.rdbtnenable.UseVisualStyleBackColor = true;
            this.rdbtnenable.CheckedChanged += new System.EventHandler(this.rdbtnenable_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cmbbxdays);
            this.panel2.Controls.Add(this.rdbtndays);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbbxweeks);
            this.panel2.Controls.Add(this.rdbtnweeks);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbbxmonths);
            this.panel2.Controls.Add(this.rdbtnmonths);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(61, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 197);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label5.Location = new System.Drawing.Point(737, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Days";
            // 
            // cmbbxdays
            // 
            this.cmbbxdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxdays.FormattingEnabled = true;
            this.cmbbxdays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmbbxdays.Location = new System.Drawing.Point(675, 121);
            this.cmbbxdays.Name = "cmbbxdays";
            this.cmbbxdays.Size = new System.Drawing.Size(56, 33);
            this.cmbbxdays.TabIndex = 9;
            // 
            // rdbtndays
            // 
            this.rdbtndays.AutoSize = true;
            this.rdbtndays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtndays.Location = new System.Drawing.Point(652, 128);
            this.rdbtndays.Name = "rdbtndays";
            this.rdbtndays.Size = new System.Drawing.Size(17, 16);
            this.rdbtndays.TabIndex = 8;
            this.rdbtndays.TabStop = true;
            this.rdbtndays.UseVisualStyleBackColor = true;
            this.rdbtndays.CheckedChanged += new System.EventHandler(this.rdbtndays_CheckedChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label4.Location = new System.Drawing.Point(447, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Weeks";
            // 
            // cmbbxweeks
            // 
            this.cmbbxweeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxweeks.FormattingEnabled = true;
            this.cmbbxweeks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbbxweeks.Location = new System.Drawing.Point(385, 121);
            this.cmbbxweeks.Name = "cmbbxweeks";
            this.cmbbxweeks.Size = new System.Drawing.Size(56, 33);
            this.cmbbxweeks.TabIndex = 6;
            // 
            // rdbtnweeks
            // 
            this.rdbtnweeks.AutoSize = true;
            this.rdbtnweeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnweeks.Location = new System.Drawing.Point(362, 128);
            this.rdbtnweeks.Name = "rdbtnweeks";
            this.rdbtnweeks.Size = new System.Drawing.Size(17, 16);
            this.rdbtnweeks.TabIndex = 5;
            this.rdbtnweeks.TabStop = true;
            this.rdbtnweeks.UseVisualStyleBackColor = true;
            this.rdbtnweeks.CheckedChanged += new System.EventHandler(this.rdbtnweeks_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label3.Location = new System.Drawing.Point(153, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Months";
            // 
            // cmbbxmonths
            // 
            this.cmbbxmonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxmonths.FormattingEnabled = true;
            this.cmbbxmonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbbxmonths.Location = new System.Drawing.Point(91, 121);
            this.cmbbxmonths.Name = "cmbbxmonths";
            this.cmbbxmonths.Size = new System.Drawing.Size(56, 33);
            this.cmbbxmonths.TabIndex = 3;
            // 
            // rdbtnmonths
            // 
            this.rdbtnmonths.AutoSize = true;
            this.rdbtnmonths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnmonths.Location = new System.Drawing.Point(68, 128);
            this.rdbtnmonths.Name = "rdbtnmonths";
            this.rdbtnmonths.Size = new System.Drawing.Size(17, 16);
            this.rdbtnmonths.TabIndex = 2;
            this.rdbtnmonths.TabStop = true;
            this.rdbtnmonths.UseVisualStyleBackColor = true;
            this.rdbtnmonths.CheckedChanged += new System.EventHandler(this.rdbtnmonths_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(329, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alert Me Before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Expiry Stock Alert";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::CarryAndForwardAgent.Properties.Resources.logo_stethoscope;
            this.pictureBox1.Location = new System.Drawing.Point(948, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnback.Location = new System.Drawing.Point(275, 436);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(239, 51);
            this.btnback.TabIndex = 27;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnnext.Location = new System.Drawing.Point(552, 436);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(239, 51);
            this.btnnext.TabIndex = 26;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarryAndForwardAgent.Properties.Resources.logo_minimize;
            this.pictureBox3.Location = new System.Drawing.Point(983, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarryAndForwardAgent.Properties.Resources.logo_close;
            this.pictureBox2.Location = new System.Drawing.Point(1027, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // ExpiryStockAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1066, 517);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpiryStockAlert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpiryStockAlert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExpiryStockAlert_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnenable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbtndisable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbxdays;
        private System.Windows.Forms.RadioButton rdbtndays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbbxweeks;
        private System.Windows.Forms.RadioButton rdbtnweeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbxmonths;
        private System.Windows.Forms.RadioButton rdbtnmonths;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}