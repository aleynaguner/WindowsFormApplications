using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
         private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int z1 = 0, z2 = 0, z3 = 0, z4 = 0, z5 = 0, z6 = 0;
         
            for (int i=0;i<1000;i++)
            {
                int a = r.Next(1, 7);

                if (a == 1)
                {
                    z1 += 1;
                    label1.Text = "1\n"+z1.ToString();

                }

                else if (a == 2)
                {
                    z2 += 1;
                    label2.Text = "2\n"+z2.ToString();
                }

                else if (a == 3)
                {
                    z3 += 1;
                    label3.Text = "3\n"+z3.ToString();
                }

                else if (a == 4)
                {
                    z4 += 1;
                    label4.Text = "4\n"+z4.ToString();
                }

                else if (a == 5)
                {
                    z5 += 1;
                    label5.Text = "5\n"+z5.ToString();
                }

                else if(a == 6)
                {
                    z6 += 1;
                    label6.Text = "6\n"+z6.ToString();
                }

                label7.Text = (z1 + z2 + z3 + z4 + z5 + z6).ToString();
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "Kontrol :";
        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ArrayList dizi = new ArrayList(new int[] { 0, 0, 0, 0, 0, 0 });
            for (int i = 0; i < 1000; i++)
            {
                int zar = rnd.Next(1, 7);
                dizi[zar - 1] = Convert.ToInt32(dizi[zar - 1]) + 1;
            }

            label1.Text = dizi[0].ToString();
            Label2.Text = dizi[1].ToString();
            Label3.Text = dizi[2].ToString();
            Label4.Text = dizi[3].ToString();
            Label5.Text = dizi[4].ToString();
            Label6.Text = dizi[5].ToString();

            ALTERNATİF YOL BİR DAHA DENE!!!!!!

            */
        }
    }
}
