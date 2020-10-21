using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1701_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hamveri = File.ReadAllText(@"D:\YEDEKLE\CODE\C#\C# Kurs\3.Ay\1701_03\veri.txt");
            string[] dizi = hamveri.Split(',');
            ArrayList sayı = new ArrayList();
            sayı.AddRange(dizi);

            int toplam = 0;
            for (int i = 0; i < sayı.Count; i++)
            {
                listBox1.Items.Add(sayı[i]);
                toplam += Convert.ToInt32(sayı[i]);
            }
            label1.Text = (toplam / sayı.Count).ToString();
        }
    }
}
