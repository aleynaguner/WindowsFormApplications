using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";

            Random rnd = new Random();
            for (int i=0;i<10;i++)
            {
                Button b = new Button();
                
                b.Width = 35;
                b.Height = 35;
                b.Top = 0;
                b.Left = i * 40 + 30;                                
                b.Text = rnd.Next(1, 11).ToString();
                b.Click += B_Click;
                panel1.Controls.Add(b);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int a=Convert.ToInt32(label1.Text);
            b.Visible = false;
            a += Convert.ToInt32(b.Text);
            label1.Text = a.ToString();
        }
    }
}
