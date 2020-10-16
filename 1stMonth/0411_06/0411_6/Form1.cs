using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            //int toplam = sayi + 1;
            sayi = sayi + 1;
            // yerine sayi+ = 10; yazabiliriz kısaltılmış operatör
            // yerine sayi++; 1 arttırmak için sadece veya eksiltmek içinde sayi--;

            label1.Text = sayi.ToString();
        }
    }
}
