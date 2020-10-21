using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1701_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int satır = Convert.ToInt32(textBox1.Text);
            string[] mars = File.ReadAllLines(@"C:\Users\asus\Desktop\C# Kurs\1701_04\istiklal.txt", Encoding.GetEncoding(1254));

            label1.Text = mars[satır-1];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\Users\asus\Desktop\C# Kurs\1701_04\çıktı.txt", label1.Text);
            MessageBox.Show("Kaydedildi");
        }
    }
}
