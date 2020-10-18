using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_06
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int a, b;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            for (int i=0;i<a;i++)
            {
                for(int j=0;j<b;j++)
                {
                    Button bt = new Button();
                    bt.Height = 40;
                    bt.Width = 40;
                    bt.Top = i * 40;
                    bt.Left = j * 40;
                    bt.Text = ((i*b)+j+1).ToString();
                    panel1.Controls.Add(bt);
                }
            }
        }
    }
}
