using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string yol = "";
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName, Encoding.GetEncoding(1254));
                yol = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = yol;
            }
        }

        private void farklıKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text, Encoding.GetEncoding(1254));
                MessageBox.Show("Kaydedildi");
                yol = saveFileDialog1.FileName;
                toolStripStatusLabel1.Text = yol;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yol == "")
            {
                DialogResult dr = saveFileDialog1.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text,Encoding.GetEncoding(1254));
                    MessageBox.Show("Kaydedildi");
                    yol = saveFileDialog1.FileName;
                    toolStripStatusLabel1.Text = yol;
                }
            }
            else
            {
                File.WriteAllText(yol, richTextBox1.Text,Encoding.GetEncoding(1254));
                toolStripStatusLabel1.Text = yol + "(" + DateTime.Now.ToString() + ")";
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            yol = "";
            toolStripStatusLabel1.Text = "";
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
        }
    }
}
