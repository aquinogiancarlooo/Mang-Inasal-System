using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MangInasal
{
    public partial class gmm1 : Form
    {
       
        public int i1;
        public gmm1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i1++;
            quantity.Text = i1.ToString();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            i1--;
            quantity.Text = i1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = i1 * 538;
            this.Hide();
        }

        private void gmm1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
