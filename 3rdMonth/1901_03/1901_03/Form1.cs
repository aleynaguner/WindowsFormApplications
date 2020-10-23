using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1901_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /*listBox1.Items.Clear();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customers where contactname like @isim";
            cmd.Parameters.AddWithValue("isim", textBox1.Text + "%");
            cmd.Connection = cn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["contactname"]);
            }
            */

            //BUTTONA BASILDIĞINDA OLMASI İÇİN
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customers where contactname like @isim";
            cmd.Parameters.AddWithValue("isim", textBox1.Text + "%");
            cmd.Connection = cn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["contactname"]);
            }

            //TEXTBOXTAKİ HER DEĞİŞİKLİKTE GÖSTERİYOR
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from customers where contactname = @isim";
            cmd.Parameters.AddWithValue("isim", listBox1.SelectedItem);
            cmd.Connection = cn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = dr["phone"].ToString();
            }
        }
    }
}
