using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1901_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from categories ";
            cmd.Connection = cn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["categoryname"]);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "select * from products inner join categories on products.CategoryID=categories.CategoryID where categoryname=@name";
            cmdd.Parameters.AddWithValue("name", listBox1.SelectedItem);
            cmdd.Connection = cn;

            SqlDataReader dr = cmdd.ExecuteReader();
            while (dr.Read())
            {
                listBox2.Items.Add(dr["ProductName"]);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Clear();
            textBox2.Clear();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "select * from products where productname=@name";
            cmdd.Parameters.AddWithValue("name", listBox2.SelectedItem);
            cmdd.Connection = cn;

            SqlDataReader dr = cmdd.ExecuteReader();
            if (dr.Read())
            {
                label1.Text = dr["productId"].ToString();
                textBox1.Text = dr["unitprice"].ToString();
                textBox2.Text = dr["unitsInStock"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update products set unitprice=@price,unitsInstock=@stock where productID=@id";
            cmd.Parameters.AddWithValue("price", textBox1.Text.Replace(",","."));
            //çünkü bilgisayarın dili türkçe olduğu için . , ondalık ayrımını yanlış anlıyor
            //replace de split gibi her string yapıları için geçerli yerlerini değiştirdi virgül yerine nokta koydu
            cmd.Parameters.AddWithValue("stock", textBox2.Text);
            cmd.Parameters.AddWithValue("id", label1.Text);
            cmd.Connection = cn;

            cmd.ExecuteNonQuery();
            //sorgu olmayan ifadeyi çalıştırırken kullanıyoruz.
            MessageBox.Show("Değişikler kaydedildi");
        }

        private void ürünToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
