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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmdd = new SqlCommand();
            cmdd.CommandText = "INSERT INTO products(productname,unitprice,unitsInstock) VALUES(@name,@price,@stock)";
            cmdd.Parameters.AddWithValue("name",textBox1.Text);
            cmdd.Parameters.AddWithValue("price",textBox2.Text);
            cmdd.Parameters.AddWithValue("stock",textBox3.Text);
            cmdd.Connection = cn;

            cmdd.ExecuteNonQuery();
            MessageBox.Show("Başarıyla eklendi");
            this.Close();
        }
    }
}
