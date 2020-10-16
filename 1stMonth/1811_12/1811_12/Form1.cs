using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //rastgele sayılar atıycak 50 olana kadar,kaçıncı sayıda bulduğunu bulacak

            Random rnd = new Random();
            
            label1.Text = "";

            for (int i=1;;i++)
            {
                int sayi = rnd.Next(1, 100);
                label1.Text += sayi.ToString() + "\n";

                if(sayi==50)
                {
                    MessageBox.Show(i + ". sayıda buldu");
                    break;                   
                }
                
            }

        }
    }
}
