using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList(new int[] { 17, 48, 99, 85, 14, 78, 23, 25 });

        private void button1_Click(object sender, EventArgs e)
        {
            //koddan girilen dizinin ortalamasını hesaplama

            int toplam = 0;
            for (int i = 0; i < dizi.Count; i++)
            {
                toplam += Convert.ToInt32(dizi[i]);

            }

            label1.Text = (toplam / dizi.Count).ToString();

            //dizinin en küçük elemanını bulma

            dizi.Sort();
            label2.Text = dizi[0].ToString();

            //dizinin en büyük elemanını bulma 

            label3.Text = dizi[dizi.Count-1].ToString();




        }

    } }
