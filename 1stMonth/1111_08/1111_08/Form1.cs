﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_08
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
            int a = Convert.ToInt32(textBox1.Text);

            if(a%2==0)
            {
                label1.Text = "Bu sayı çifttir.";
            }
            else
            {
                label1.Text = "Bu sayı tektir.";
            }
        }
    }
}
