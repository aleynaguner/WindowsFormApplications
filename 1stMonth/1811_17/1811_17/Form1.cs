using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1811_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList gun = new ArrayList();
            gun.Add("Pazartesi");
            gun.Add("Salı");
            gun.Add("Çarşamba");
            gun.Add("Perşembe");
            gun.Add("Cuma");
            gun.Add("Cumartesi");
            gun.Add("Pazar");

            Random rnd = new Random();
            int a = rnd.Next(0, 7);
            label1.Text = gun[a].ToString();

            //rastgele gün yazdır 
        }
    }
}
