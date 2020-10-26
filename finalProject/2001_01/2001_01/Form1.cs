using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2001_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from categories";
            cmd.Connection = cn;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable kategori = new DataTable();
            da.Fill(kategori);
            //önce bağlantısız yöntemle categorileri aldık

            for(int i = 0; i < kategori.Rows.Count; i++)
            {
                treeView1.Nodes.Add(kategori.Rows[i]["categoryID"].ToString(), kategori.Rows[i]["categoryName"].ToString());

                SqlConnection cn2 = new SqlConnection();
                cn2.ConnectionString = "Server=.\\sqlexpress;Database=Northwind;Trusted_Connection=true";
                cn2.Open();

                SqlCommand cmd2 = new SqlCommand();
                cmd2.CommandText = "Select * from products where categoryId  = @id";
                cmd2.Parameters.AddWithValue("id", kategori.Rows[i]["categoryID"]);
                cmd2.Connection = cn2;

                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    treeView1.Nodes[i].Nodes.Add(dr["productId"].ToString(), dr["productname"].ToString());
                }
            }
        }
    }
}
