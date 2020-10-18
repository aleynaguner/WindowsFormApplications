using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3012_05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public ArrayList dizi;

        private void Form2_Load(object sender, EventArgs e)
        {
           for(int i=0;i<dizi.Count;i++)
            {
                if(Convert.ToInt32(dizi[i])%2==0)
                {
                    listBox1.Items.Add(dizi[i]);
                }
            }
        }
    }
}
