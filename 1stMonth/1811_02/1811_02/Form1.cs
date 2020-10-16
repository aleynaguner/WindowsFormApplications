using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1 = rnd.Next(1, 5);
            int sayi2 = rnd.Next(1, 5);
            int sayi3 = rnd.Next(1, 5);

            label2.Text = sayi1.ToString();
            label3.Text = sayi2.ToString();
            label4.Text = sayi3.ToString();

            int cep = Convert.ToInt32(label1.Text);
            if (cep > 0)
            {
                if (sayi1 == sayi2 || sayi2 == sayi3 || sayi1 == sayi3)
                {
                    cep += 100;
                    label1.Text = cep.ToString();
                }
                
                else if (sayi1 == sayi2 && sayi2 == sayi3)
                {
                    cep += 1000;
                    label1.Text = cep.ToString();
                }

                else
                {
                    cep -= 200;
                    label1.Text = cep.ToString();
                }

            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

