﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 100; i++)
            {
                if (i % 5 != 0)
                {
                    label1.Text += i + "\n";
                }
            }

                /*label1.Text = "";
                for(int i=0;i<100;i++)
                {
                    if(i%5==0)
                    {
                        i++;
                    }
                    label1.Text += i.ToString()+"\n";
                }*/

            /*if(i%5!=0)
             {
             }
             else
             {label1.text+=i+"\n";
             */

            }
    }
}
