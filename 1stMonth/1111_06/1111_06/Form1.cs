using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i;
        Random rnd = new Random();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            i = rnd.Next(1, 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
        }
    }
}
