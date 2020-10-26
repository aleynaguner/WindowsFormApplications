using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2001_BitirmeProjesi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public ArrayList seçilmiş = new ArrayList();
        public int seansID;

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;

            this.BackColor = Color.Red;
            label1.BackColor = Color.White;
            label2.BackColor = Color.White;

            foreach (object x in seçilmiş)
            {
                textBox1.Text += x.ToString() + "  ";
                textBox1.Text = textBox1.Text.Substring(0, textBox1.TextLength - 1);
                //son  virgülü yazmaması için sadece stringlerle kullanılan bir özellik belirli verileri almayı sağlıyo
            }

            textBox2.Text = (seçilmiş.Count * 20).ToString() + "  TL";

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satın alma işleminiz başarıyla tamamlandı.");

            for (int i = 0; i < seçilmiş.Count; i++)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Server=.\\sqlexpress;Database=Sinema;Trusted_Connection=true";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Insert into SatınAlma(SeansID,Fiyat,KoltukNo,Tarih) values (@id,20,@no,@tarih) ";
                cmd.Parameters.AddWithValue("id", seansID);
                cmd.Parameters.AddWithValue("no", seçilmiş[i]);
                cmd.Parameters.AddWithValue("tarih", DateTime.Now);
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();              
            }

            this.Close();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
