using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_05
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
            listBox1.Items.Add(textBox1.Text);
            dizi.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.dizi = dizi;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 b = new Form3();
            b.dizi = dizi;
            b.Show();
        }
    }
}
