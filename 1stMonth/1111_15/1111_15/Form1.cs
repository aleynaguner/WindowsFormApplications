using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textBox1.Text);
            double final = Convert.ToDouble(textBox2.Text);

            double ort = (vize * 0.4 + final * 0.60);
            label1.Text = ort.ToString();

            if(ort>84)
            {
                label2.Text = "AA";
            }
            else if(ort>69)
            {
                label2.Text = "BB";
            }
            else if (ort > 59)
            {
                label2.Text = "CC";
            }
            else if (ort > 49)
                label2.Text = "DD";            
            else
                label2.Text = "FF";            
        }
    }
}
