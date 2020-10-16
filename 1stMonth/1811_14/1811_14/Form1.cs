using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //10a 10luk matris 
            label1.Text = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    label1.Text += i.ToString();
                }
                label1.Text += "\n";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    label2.Text += i.ToString();
                }
                label2.Text += "\n";
            }
        }
    }
}
