using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public ArrayList c,d;

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Pizzanı Seç";

            for(int i=0;i<c.Count;i++)
            {
                comboBox1.Items.Add(c[i]);
            }

            for(int j = 0; j < d.Count; j++)
            {
                Button bt = new Button();
                bt.Height = 21;
                bt.Width = 240;
                bt.Top = j * 21;
                bt.Text = d[j].ToString();
                bt.BackColor = Color.Green;
                bt.Click += Bt_Click;
                panel1.Controls.Add(bt);
            }

        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            if (bt.BackColor==Color.Green)
            {
                bt.BackColor = Color.Red;
            }
            
            else if(bt.BackColor==Color.Red)
            {
                bt.BackColor = Color.Green;
            }
        
        }
    }
}
