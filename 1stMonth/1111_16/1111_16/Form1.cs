using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(textBox1.Text);

            if (adet > 49)
                label1.Text = (adet * 8).ToString();
            else if (adet > 8)
                label1.Text = (adet * 9).ToString();
            else
                label1.Text = (adet * 10).ToString();
        }
    }
}
