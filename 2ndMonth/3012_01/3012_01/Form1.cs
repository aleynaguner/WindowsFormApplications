using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int adet = listBox1.Items.Count;
            Random rnd = new Random();
            for(int i=0;i<adet;i++)
            {
                int rastgele = rnd.Next(0, listBox1.Items.Count);
                listBox2.Items.Add(listBox1.Items[rastgele]);
                listBox1.Items.RemoveAt(rastgele);
            }
        }
    }
}
