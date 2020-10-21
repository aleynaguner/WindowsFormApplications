using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1701_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = File.ReadAllText(@"D:\YEDEKLE\CODE\C#\C# Kurs\3.Ay\1701_01\source.txt");
            label1.Text = metin;
        }
    }
}
