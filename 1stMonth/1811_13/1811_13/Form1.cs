using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Random rnd = new Random();
            int zar1 = rnd.Next(1, 7);
            int zar2 = rnd.Next(1, 7);

            label1.Text = zar1.ToString();
            label2.Text = zar2.ToString();

            if (zar1 == 6 && zar2 == 6)
            {
                MessageBox.Show("Düşeş");
            }
            */
            label1.Text = "";
            label2.Text = "";
            Random rnd = new Random();

            for(;;)
            {
                int zar1 = rnd.Next(1, 7);
                int zar2 = rnd.Next(1, 7);

                label1.Text += zar1+"\n";
                label2.Text += zar2+"\n";

                if(zar1==6 && zar2==6)
                {
                    break;
                }
            }
        }
    }
}
