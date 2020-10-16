using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet = 0;
            for(int i=20;i<=100;i++)
            {
                if (i % 3 == 0)
                {
                    adet++;
                }
            }
            label1.Visible = true;
            label1.Text = adet.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //20den 100e 3e kaçtane sayı bölünebiliyor
    }
}
