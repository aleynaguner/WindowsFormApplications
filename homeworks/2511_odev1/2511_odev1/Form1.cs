using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            label1.Text = "0";
            label2.Text = "";

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Top = i * 42;
                    btn.Left = j * 42;
                    btn.Text = (i * 10 + j + 1).ToString();
                    btn.Click += Btn_Click;
                    panel1.Controls.Add(btn);
                }
            }

            for (int i = 0; i < 10;)
            {
                int a = rnd.Next(1, 101);
                if (!mayin.Contains(a))
                {
                    mayin.Add(a);
                    i++;
                }
            }
            for (int i = 0; i < mayin.Count; i++)
            {
                mayin.Sort();
                label2.Text += mayin[i] + "  ";
            }


        }

        ArrayList mayin = new ArrayList();
        Random rnd = new Random();

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;

            for(int i=0; i<10 ;i++)
             {
                 if(b.Text==mayin[i].ToString())
                 {
                     b.BackColor = Color.Red;
                     MessageBox.Show("KAYBETTİNİZ.\nSKORUNUZ=" + label1.Text);
                     break;
                  }
                 else
                 {
                     b.BackColor = Color.Green;
                     int l = Convert.ToInt32(label1.Text);
                     l++;
                     label1.Text = l.ToString();
                }

             }
            //Puanlamada döngüler yüzünden sıkıntı var. 10ar 10ar artıyor ve oyunu durduramadım.

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(Application.OpenForms[0]==this)
            {
                Application.Restart();
            }
           else
            {
                Form1 f = new Form1();
                f.Show();
                this.Close();
            }
            //Oyunu yeniden başlatamadım panel1.controls.clear ile bütün panel gitti.
        }
    }
}
