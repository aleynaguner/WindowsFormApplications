using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1701_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TXT Files | *.txt;";
            //sadece text dosyalarını filtreledi, birden fazla filtre için noktalı virgül kullan
            DialogResult dr = openFileDialog1.ShowDialog();
            label2.Text = dr.ToString();

            if(dr==DialogResult.OK)
            {
                label1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.GetEncoding(1254));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
