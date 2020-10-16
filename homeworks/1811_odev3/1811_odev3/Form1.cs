using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            ArrayList alfabe = new ArrayList();

            alfabe.Add("A");
            alfabe.Add("B");
            alfabe.Add("C");
            alfabe.Add("Ç");
            alfabe.Add("D");
            alfabe.Add("E");
            alfabe.Add("F");
            alfabe.Add("G");
            alfabe.Add("Ğ");
            alfabe.Add("H");
            alfabe.Add("I");
            alfabe.Add("İ");
            alfabe.Add("J");
            alfabe.Add("K");
            alfabe.Add("L");
            alfabe.Add("M");
            alfabe.Add("N");
            alfabe.Add("O");
            alfabe.Add("Ö");
            alfabe.Add("P");
            alfabe.Add("R");
            alfabe.Add("S");
            alfabe.Add("Ş");
            alfabe.Add("T");
            alfabe.Add("U");
            alfabe.Add("Ü");
            alfabe.Add("V");
            alfabe.Add("Y");
            alfabe.Add("Z");
           
            int a = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            
            for(int i=0; i<=a;i++)
            {
                int r = rnd.Next(0, alfabe.Count);
                richTextBox1.Text += alfabe[r];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0-30 sayıları arasında bir değer girin.";
        }
    }
}
