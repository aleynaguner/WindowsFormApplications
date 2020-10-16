using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=1000; ;i++)
            {
                if(i%17==0)
                {
                    label1.Text = i.ToString();
                    break;
                }
            }
            //break kullanımını görmek için. sonsuza kadar  
            //bir döngü var koşul olduğunda durdu
        }
    }
}
