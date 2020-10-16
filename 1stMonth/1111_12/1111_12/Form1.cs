using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int m1 = rnd.Next(1, 11);
            int m2 = rnd.Next(1, 11);

            if(button2.Left+button2.Width<label1.Left)
            {
                button2.Left += m1;
            }
            else
            {
                button2.BackColor = Color.Green;
                button1.Enabled = false;
            }
            if(button3.Left+button2.Width<label1.Left)
            {
                button3.Left += m2;
            }
            else
            {
                button3.BackColor = Color.Green;
                button1.Enabled = false;
            }
        }
    }
}
