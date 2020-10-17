using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=0; i<10; i++)
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.Top = 60;
                btn.Left = i * 50+40;
                btn.Text = (i + 1).ToString();
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
           }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("SELAM"); ilk örnekte bütün butonlara selam yazar
            Button b = (Button)sender;
            //MessageBox.Show(b.Text);   tıkladığın butonun sayısını gösterdi
            /*if (b.BackColor == Color.Green)
                b.BackColor = Color.Red;
            else
                b.BackColor = Color.Green;
            */
            // b.Top += 25; Bastığımızı aşağı indirdi
            //b.Visible= false;
            b.Enabled= false;
        }
      }
    }

