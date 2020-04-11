using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarryAndForwardAgent
{
    public partial class GenericAndProductwiseSearch : Form
    {
        public GenericAndProductwiseSearch()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        { this.Close(); }
    }
}
