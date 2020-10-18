using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList tür = new ArrayList();
        ArrayList malzeme = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Pizzza";

            label1.Text = "Pizza Türleri";
            label2.Text = "Pizza Malzemeleri";

            button1.Text = "Ekle";
            button2.Text = "Ekle";
            button3.Text = "Göster";
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

            if (!listBox1.Items.Contains(a) && a != "")
            {
                listBox1.Items.Add(a);
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (string s1 in listBox1.Items)
            {
                tür.Add(s1);
            }

            foreach (string s2 in listBox2.Items)
            {
                malzeme.Add(s2);
            }

            Form2 f2 = new Form2();

            f2.c = tür;
            f2.d = malzeme;

            f2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string b = textBox2.Text;

            if (!listBox2.Items.Contains(b) && b != "")
            {
                listBox2.Items.Add(b);
                
            }

            textBox2.Clear();
            textBox2.Focus();
        }
    }
}
