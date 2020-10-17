using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<10; i++ )
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.Left = i * 50;
                btn.Top = 0;
                btn.Text = (i + 1).ToString();
                btn.BackColor = Color.Green;
                btn.Click += Btn_Click;
                panel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b.BackColor==Color.Green)
            {
                b.BackColor = Color.Yellow;
                listBox1.Items.Add(b.Text);
            }
            else if(b.BackColor==Color.Yellow)
            {
                b.BackColor = Color.Green;
                listBox1.Items.Remove(b.Text);
            }
        }
    }
}
