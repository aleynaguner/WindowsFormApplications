﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int carpım=1;
            for(int i=1;i<=a;i++)
            {
                carpım *= i;
            }
            label1.Text = carpım.ToString();

            //Kullanıcıdan girilen sayının faktoriyelini hesaplama
        }
    }
}
