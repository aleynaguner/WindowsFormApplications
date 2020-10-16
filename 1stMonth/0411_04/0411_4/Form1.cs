using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int toplam = a + b;
            //string toplam = (a + b).ToString(); olarakta yapabiliriz nerede döüştürme yapacağımızı bize kalmış
            MessageBox.Show(toplam.ToString());
            //textboxa girilen iki sayının toplamı

            //label1.Text = toplam; labela yazdırırsın

        }
    }
}
