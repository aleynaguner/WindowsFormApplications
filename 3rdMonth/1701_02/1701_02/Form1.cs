using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1701_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dosya = textBox1.Text;
                string metin = File.ReadAllText(@"C:\Users\asus\Desktop\C# Kurs\1701_02\" + dosya + ".txt", Encoding.GetEncoding(1254));
                //hangi dosya olduğuna kendi karar veriyor a yazılması ve b yazılması durumunda 
                label1.Text = metin;
                //türkçe karakter hatası veriyor
            }
            catch
            {
                MessageBox.Show("Böyle bir dosya yok");
            }
        }
    }
}
