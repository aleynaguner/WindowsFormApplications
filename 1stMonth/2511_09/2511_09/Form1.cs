using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }      

        private void B_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(Convert.ToInt32(b.Text)==dogru)
            {
                b.BackColor = Color.Green;
                MessageBox.Show("KAZANDINIZ");
            }
            else 
            {
                b.BackColor = Color.Red;
            }

        }
        Random rnd = new Random();
        int dogru;
        private void Form1_Load(object sender, EventArgs e)
        {
            dogru = rnd.Next(1, 11);

            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Width = 40;
                b.Height = 40;
                b.Top = 0;
                b.Left = i * 50 + 20;
                b.Text = (i + 1).ToString();
                b.Click += B_Click;
                panel1.Controls.Add(b);
            }

            
        }
    }
}
