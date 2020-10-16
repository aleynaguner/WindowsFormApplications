using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string şifre = textBox1.Text;
            if (şifre == "123456")
            {
                MessageBox.Show("Şifre Doğru");
            }
            else
            {
                MessageBox.Show("Hatalı Şifre");
                textBox1.Text = "";
                textBox1.Focus();
            }

        }
    }
}
