using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2511_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList dizi = new ArrayList(new int[] { 35, 58, 76, 87, 144, 17 });
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox1.Text);
            if (dizi.Contains(sayi))
                MessageBox.Show("Dizide bu sayı zaten var");
            else
                dizi.Add(sayi);


        }
    }
}
