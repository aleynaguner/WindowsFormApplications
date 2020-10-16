using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_odev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);

            if(a<0 || b<0)
            {
                label5.Text="Pozitif bir değer girin.";
                textBox1.Text = "";
                textBox2.Text = "";

                label1.Text = "";
                label2.Text = "";
            }
           
            if(a>=b)
            {
                for (int j = b; ; j--)
                {
                    if (a % j == 0 && b % j == 0)
                    {
                        label1.Text = j.ToString();
                        break;
                    }
                }
            }
            else
                for (int j = a; ; j--)
                {
                    if (a % j == 0 && b % j == 0)
                    {
                        label1.Text = j.ToString();
                        break;
                    }
                }

            for (int i = 1; ; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    label2.Text = i.ToString();
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();

            label1.Text = "";
            label2.Text = "";
            label5.Text = "";
        }

        /*
         * int sayi1=Convert.ToInt32(Textbox1.Text);
         * int sayi2=Convert.ToInt32(Textbox2.Text);
         * for(int i= sayi1; i>0 ;i--)
         * {
         *    if(sayi1%i==0 && sayi2%i==0)
         *    {
         *       label1.Text=i.ToString();
         *       break;
         *    }
         * }
         * 
         * for(int i=sayi1; ;i++)
         * {
         *    if(i%sayi1==0 && i%sayi2==0)
         *    {
         *       label2.Text=i.ToString();
         *       break;
         *    }
         * }
         * 
         * Sayının büyüğünğ bulmaya gerek çnkü aradaki sayılar ne ebob ne ekok olabilir!!!!
         * 
         */
    }
}
