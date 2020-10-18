using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int butonsayisi = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            butonsayisi++;

            Button btn = new Button();
            btn.Width = 200;
            btn.Height = 30;
            btn.Top = button1.Top;                                  
            btn.Text = butonsayisi.ToString();
            btn.BackColor = Color.Tomato;
            btn.Click += Btn_Click;
            panel1.Controls.Add(btn);
            button1.Top += button1.Height;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (btn.BackColor == Color.Tomato)
            {
                listBox1.Items.Add(btn.Text);
                btn.BackColor = Color.Green;
            }
           
            else if(btn.BackColor==Color.Green)
            {
                listBox1.Items.Remove(btn.Text);
                btn.BackColor = Color.Tomato;
            }
        }
    }
}
