using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soldanuzaklık = button1.Left;
            soldanuzaklık += 8;
            button1.Left = soldanuzaklık;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Left++;
        }
    }
}
