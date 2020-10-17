using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_05
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
            listBox1.Items.Clear();

            for(int i=0; listBox1.Items.Count<10; i++)
            {
                int sayi = rnd.Next(1, 11);
                if (!listBox1.Items.Contains(sayi))
                {
                    listBox1.Items.Add(sayi);
                }

            }
        }
    }
}
