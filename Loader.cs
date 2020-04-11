using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;

namespace CarryAndForwardAgent
{
    public partial class Loader : Form
    {
        MyConnection conn = new MyConnection();

        const int AW_SLIDE = 0X40000;
        const int AW_HOR_POSITIVE = 0X2;
        const int AW_HOR_NEGATIVE = 0X1;

        const int AW_BLEND = 0X80000;

        [DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        public Loader()
        {
            InitializeComponent();
        }

        private void Loader_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UserLogin ul = new UserLogin();
            ul.Show();
            this.Hide();
            timer1.Stop();

        }
    }
}
