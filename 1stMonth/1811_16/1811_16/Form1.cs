using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_16
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
            Random rnd = new Random();
            label1.Text = "";

            for (int i = 1; i <= 6; i++)
            {
                int a = rnd.Next(1, 50);
                dizi.Add(a);

            }
            dizi.Sort();
            for(int j=0;j<dizi.Count;j++)
            {
                label1.Text += dizi[j] + "\n";

            }
        }
    }
}
