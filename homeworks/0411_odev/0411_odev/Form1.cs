﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);
            a++;
            label1.Text = a.ToString();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(label1.Text);
            b--;
            label1.Text = b.ToString();

        }
    }
}
