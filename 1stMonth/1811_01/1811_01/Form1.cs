using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogru;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            dogru = rnd.Next(1, 100);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt32(textBox1.Text);
            if (dogru == tahmin)
            {
                MessageBox.Show("Bildiniz");
            }

            else if (dogru < tahmin)
            {
                MessageBox.Show("Daha küçük bir sayı girin");
            }

            else if (dogru > tahmin)
            {
                MessageBox.Show("Daha büyük bir sayı girin");
            }
            //bilgisayarın tahmin ettiği sayıyı bulmaya çalışıyor
        }

       
    }
}
