﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string mesaj;

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj = "Aleyna";
            MessageBox.Show("Merhaba" + mesaj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güle Güle" + mesaj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("yükleniyor...");
        }
    }
}
