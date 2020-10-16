using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            int not1 = Convert.ToInt32(textBox1.Text);
            int not2 = Convert.ToInt32(textBox2.Text);

            int ort = (not1 + not2) / 2;

            if(ort>=50)
            {
                label1.Text = "Geçtiniz";
            }
            else
            {
                label1.Text = "Kaldınız";
            }    


        }
    }
}
