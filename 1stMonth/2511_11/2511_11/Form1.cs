using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<3;i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button btn = new Button();
                    btn.Height = 40;
                    btn.Width = 40;
                    btn.Top = i * 50;
                    btn.Left = j * 50;
                    btn.Text = (3*i+j+1).ToString();
                    panel1.Controls.Add(btn);
                }
                
            }
        }
    }
}
