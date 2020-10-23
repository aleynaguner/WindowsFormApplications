using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1901_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            //burası bir kalıp bağlanırken bilgisayar adı iki slash olmalı özel karakter olarak almaması
            //için çalıştığım database ve şifreli olup olmadığı
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from products where productname = @isim";
            cmd.Parameters.AddWithValue("isim", textBox1.Text);
            cmd.Connection = cn; 
            //bu sql sorgusunu cn bağlantısı üzerinden gönder

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["unitprice"].ToString();
            }
        }
    }
}
