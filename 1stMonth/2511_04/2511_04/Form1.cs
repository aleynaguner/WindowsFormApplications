using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            ArrayList dizi = new ArrayList();
            Random rnd = new Random();

            for (int i=0; i<6; )
            {
                int sayi= rnd.Next(1,50);
                if (!dizi.Contains(sayi))
                {
                    dizi.Add(sayi);
                    i++;
                }
            }
            dizi.Sort();

            for(int i=0; i<dizi.Count; i++)
            {
                label1.Text += dizi[i] + "  ";
            }


           
        }
    }
}
