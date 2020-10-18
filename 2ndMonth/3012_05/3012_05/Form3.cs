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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ArrayList dizi;

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i=0;i<dizi.Count;i++)
            {
                if(Convert.ToInt32(dizi[i])>9 && Convert.ToInt32(dizi[i]) < 100)
                {
                    label1.Text = dizi[i].ToString();
                }
            }
        }
    }
}
