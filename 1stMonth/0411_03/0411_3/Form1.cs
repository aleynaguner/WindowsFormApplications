using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int sonuc = a + 5;
            MessageBox.Show(sonuc.ToString());
            //textboxa yazılanı 5 ekleyerek çıkardık textbox string yapıda olduğu için convert yapmalıyız
        }
    }
}
