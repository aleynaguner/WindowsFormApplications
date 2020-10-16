using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize = Convert.ToInt32(textBox2.Text);
            int final = Convert.ToInt32(textBox3.Text);
            int ort = (vize + final) / 2;

            label4.Text = "Sayın " + textBox1.Text + ";\nortalamanız: " + ort.ToString();
            // \ gözüksün istiyosak iki tane yapmalıyız 
        }
    }
}
