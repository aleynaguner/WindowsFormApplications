using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(textBox1.Text);

            if (derece > 100)
            {
                label1.Text = "gaz";
            }
            else if (derece > 0 && derece <= 100)
            {
                label1.Text = "sıvı";
            }
            else
                label1.Text = "katı";
        }
    }
}
