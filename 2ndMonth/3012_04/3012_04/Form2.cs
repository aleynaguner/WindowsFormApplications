using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string isim;
        public int dogumyili;

        private void Form2_Load(object sender, EventArgs e)
        {            
            dogumyili = 2018 - dogumyili;
            label1.Text = "Merhaba  " + isim + "\nYaşın : " + dogumyili.ToString();
        }
    }
}
