using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kullanıcıdan girilen iki sayı arasındaki kaç adet sayı 3e bölünüp beşe bölünmez

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            int adet=0;

            for(int i=a;i<=b;i++)
            {
                if (i%3==0 && i%5!=0)
                {
                    adet++;
                }
                label1.Text = adet.ToString();
            }
        }
    }
}
