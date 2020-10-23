using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1901_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            label1.Text = "";
            listBox1.Items.Clear();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select orderId from orders where shippeddate is null";
            cmd.Connection = cn;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr["OrderId"]);
            }
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = MessageBox.Show("Teslim işlemini onaylıyor musunuz?", "Teslimat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
                cn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "update orders set shippeddate=getdate() where orderId=@id";
                cmd.Parameters.AddWithValue("id", listBox1.SelectedItem);
                cmd.Connection = cn;

                cmd.ExecuteNonQuery();
                Form1_Load(null, null);
            }
                        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = "";
            button1.Enabled = true;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "select * from orders where orderId=@name";
            cmdd.Parameters.AddWithValue("name", listBox1.SelectedItem);
            cmdd.Connection = cn;

            SqlDataReader dr = cmdd.ExecuteReader();
            while (dr.Read())
            {
                label1.Text = "Müşteri Adı     : " + dr["ShipName"].ToString() + "\n\n" + "Teslim Adresi     : " + dr["ShipAddress"] + "\n\n" + "Teslim edilen Şehir : " + dr["ShipCity"] + "\n\n" + "Sipariş Tarihi    : " + dr["OrderDate"];
            }
        }
    }
}
