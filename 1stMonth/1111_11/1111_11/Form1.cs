using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1111_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int on = button1.Left + button1.Width;
            if (on < button2.Left)
            {
                button1.Left++;
            }
            else { button1.BackColor = Color.Red; }
        }
    }
}
