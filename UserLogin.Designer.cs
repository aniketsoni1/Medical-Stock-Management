namespace CarryAndForwardAgent
{
    partial class UserLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtloginpassword = new System.Windows.Forms.TextBox();
            this.txtloginusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblforgotloginpassword = new System.Windows.Forms.Label();
            this.lblsignup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarryAndForwardAgent.Properties.Resources.user_logoavatar;
            this.pictureBox1.Location = new System.Drawing.Point(149, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarryAndForwardAgent.Properties.Resources.logo_minimize;
            this.pictureBox3.Location = new System.Drawing.Point(416, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CarryAndForwardAgent.Properties.Resources.logo_close;
            this.pictureBox2.Location = new System.Drawing.Point(460, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.txtloginpassword);
            this.panel1.Controls.Add(this.txtloginusername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 186);
            this.panel1.TabIndex = 31;
            // 
            // txtloginpassword
            // 
            this.txtloginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginpassword.Location = new System.Drawing.Point(4, 131);
            this.txtloginpassword.Name = "txtloginpassword";
            this.txtloginpassword.PasswordChar = '*';
            this.txtloginpassword.Size = new System.Drawing.Size(497, 34);
            this.txtloginpassword.TabIndex = 24;
            // 
            // txtloginusername
            // 
            this.txtloginusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloginusername.Location = new System.Drawing.Point(4, 50);
            this.txtloginusername.Name = "txtloginusername";
            this.txtloginusername.Size = new System.Drawing.Size(497, 34);
            this.txtloginusername.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Username";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnlogin.Location = new System.Drawing.Point(183, 465);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(141, 41);
            this.btnlogin.TabIndex = 32;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // lblforgotloginpassword
            // 
            this.lblforgotloginpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotloginpassword.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblforgotloginpassword.Location = new System.Drawing.Point(15, 540);
            this.lblforgotloginpassword.Name = "lblforgotloginpassword";
            this.lblforgotloginpassword.Size = new System.Drawing.Size(480, 20);
            this.lblforgotloginpassword.TabIndex = 33;
            this.lblforgotloginpassword.Text = "Forgotten Your Password?";
            this.lblforgotloginpassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblforgotloginpassword.Click += new System.EventHandler(this.lblforgotloginpassword_Click);
            // 
            // lblsignup
            // 
            this.lblsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsignup.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblsignup.Location = new System.Drawing.Point(15, 520);
            this.lblsignup.Name = "lblsignup";
            this.lblsignup.Size = new System.Drawing.Size(480, 20);
            this.lblsignup.TabIndex = 34;
            this.lblsignup.Text = "Sign Up?";
            this.lblsignup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblsignup.Click += new System.EventHandler(this.label4_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(506, 572);
            this.Controls.Add(this.lblsignup);
            this.Controls.Add(this.lblforgotloginpassword);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserLogin";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtloginpassword;
        private System.Windows.Forms.TextBox txtloginusername;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblforgotloginpassword;
        private System.Windows.Forms.Label lblsignup;
    }
}