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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;

            label1.BackColor = Color.White;
            label2.BackColor = Color.White;

            label1.Text = "Lütfen size uygun seansı seçin...";
            label2.Text = "";

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Sinema;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from salon";
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable salon = new DataTable();
            da.Fill(salon);
            //Önce bağlantısız da salonları çekmeliyiz içine yazacaklarımı bağlantılıda çekicez

            for (int i = 0; i < salon.Rows.Count; i++)
            {
                treeView1.Nodes.Add(salon.Rows[i]["SaID"].ToString(), salon.Rows[i]["SaNo"].ToString());
                //buradan sonra salon adlarını görmeliyiz

                SqlConnection cn2 = new SqlConnection();
                cn2.ConnectionString = "Server=.\\sqlexpress;Database=Sinema;Trusted_Connection=true";
                cn2.Open();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "Select * from seans INNER JOIN film ON seans.filmID=film.FiID where SalonID = @id";
                //seanslardan film ismine gitmemiziçin gerekliydi
                //salona göre film isimlerini getirdiğimiz için salonID'si @id olanı where koşuluyla istedik
                cmd2.Parameters.AddWithValue("id", salon.Rows[i]["SaID"]);
                cmd2.Connection = cn2;

                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    treeView1.Nodes[i].Nodes.Add(dr["FiID"].ToString(), "(" + dr["saat"] + ")" + dr["FiAd"].ToString());
                }
            }

        }

        ArrayList satılmışlar = new ArrayList();

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Level != 0)
            {
                panel1.Controls.Clear();
                satılmışlar.Clear();
                seçilmişler.Clear();

                label2.Text = "Lütfen koltuk seçin...";
                label1.Text = "";

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Server=.\\sqlexpress;Database=Sinema;Trusted_Connection=true";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from SatınAlma where seansID= @id ";
                cmd.Parameters.AddWithValue("id", treeView1.SelectedNode.Name);
                // treeView1.SelectedNode.Name seansID demek
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    satılmışlar.Add(dr["koltukNo"].ToString());
                }
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Button btn = new Button();
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Left = 40 * i;
                        btn.Top = 40 * j;
                        btn.Text = (15 * j + i + 1).ToString();
                        btn.Click += Btn_Click;
                        panel1.Controls.Add(btn);

                        if (satılmışlar.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Red;
                        }
                        else
                        {
                            btn.BackColor = Color.Green;
                        }

                    }
                }
            }
            
           
        }

        ArrayList seçilmişler = new ArrayList();

        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            //unboxing yapılmalı
            if(b.BackColor==Color.Green)
            {
                b.BackColor = Color.Yellow;
                seçilmişler.Add(b.Text);
            }
            else if (b.BackColor == Color.Yellow)
            {
                b.BackColor = Color.Green;
                seçilmişler.Remove(b.Text);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.seçilmiş = seçilmişler;
            f2.seansID = Convert.ToInt32(treeView1.SelectedNode.Name);
            f2.Show();

           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Level != 0)
            {
                panel1.Controls.Clear();
                satılmışlar.Clear();

                label2.Text = "Lütfen koltuk seçin...";
                label1.Text = "";

                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Server=.\\sqlexpress;Database=Sinema;Trusted_Connection=true";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select * from SatınAlma where seansID= @id ";
                cmd.Parameters.AddWithValue("id", treeView1.SelectedNode.Name);
                // treeView1.SelectedNode.Name seansID demek
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    satılmışlar.Add(dr["koltukNo"].ToString());
                }
                for (int i = 0; i < 15; i++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Button btn = new Button();
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Left = 40 * i;
                        btn.Top = 40 * j;
                        btn.Text = (15 * j + i + 1).ToString();
                        btn.Click += Btn_Click;
                        panel1.Controls.Add(btn);

                        if (satılmışlar.Contains(btn.Text))
                        {
                            btn.BackColor = Color.Red;
                        }
                        else
                        {
                            btn.BackColor = Color.Green;
                        }

                    }
                }
            }
        }
    }
}
