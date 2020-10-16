using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            dizi.Add(a);
            textBox1.Text = "";
            textBox1.Focus();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dizi.Sort();
            for(int i=0;i<dizi.Count;i++)
            {
                label1.Text += dizi[i] + "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
