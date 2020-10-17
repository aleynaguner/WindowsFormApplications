using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            int sayi = Convert.ToInt32(textBox1.Text);

            if (listBox1.Items.Contains(sayi))
            {
                MessageBox.Show("Bu sayı zaten listede var.\nYeni bir sayı girin.");
            }
            else
            {
                listBox1.Items.Add(sayi);
            }

        }
    }
}
