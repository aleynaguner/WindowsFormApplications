using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int saat = DateTime.Now.Hour;
            label2.Text = saat.ToString();

            if(saat>21)
            {
                label1.Text = "İyi Geceler";
            }
            else if(saat>16)
            {
                label1.Text = "İyi Akşamlar";
            }
            else if (saat > 10)
            {
                label1.Text = "İyi Günler";
            }
            else if (saat > 5)
            {
                label1.Text = "Günaydın";
            }
            else
            {
                label1.Text = "Merhaba";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
