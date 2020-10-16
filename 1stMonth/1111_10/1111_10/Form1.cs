using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //para tutarını form ekranında seç
            label1.Text = "";
            label2.Text = "";
            
            Random rnd = new Random();

            label1.Text = rnd.Next(1, 7).ToString();
            label2.Text = rnd.Next(1, 7).ToString();

            if (Convert.ToInt32(label3.Text) > 0)
            {
                if (label1.Text == label2.Text)
                {
                    MessageBox.Show("Kazandınız");
                    int para = Convert.ToInt32(label3.Text);
                    para += 500;
                    label3.Text = para.ToString();
                }
                else
                {
                    MessageBox.Show("Kaybettiniz");
                    int para = Convert.ToInt32(label3.Text);
                    para -= 500;
                    label3.Text = para.ToString();
                }
            }
            else
            {
                MessageBox.Show("Paranız bitti.");
                button1.Enabled = false;
            }

        }
    }
}
