using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList dizi = new ArrayList(new int[] { 35, 69, 58, 44, 22, 125 });
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            listBox1.Items.Clear();

            ArrayList dizi1 = new ArrayList();
            for(int i=0; i<dizi.Count ;i++)
            {
                int a = Convert.ToInt32(dizi[i]) + 1;
                dizi1.Add(a);
                label1.Text += dizi1[i] +"\n";
                //.tostring koymama gerek kalmadı çünkü yanındaki yüzünden onuda tostring kabul etti

                listBox1.Items.Add(dizi1[i]);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            ArrayList dizi2 = new ArrayList();

            for (int i=0; i<dizi.Count; i++)
            {
                int b = Convert.ToInt32(dizi[i]);
                if(b%11==0)
                {
                    dizi2.Add(dizi[i]);
                }

            }
            for(int i=0;i<dizi2.Count;i++)
            {
                listBox1.Items.Add(dizi2[i]);
            }
        }
    }
}
