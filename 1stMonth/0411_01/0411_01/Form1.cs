using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _0411_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = "merhaba";
            MessageBox.Show(metin);
            //Ekrana merhaba yazdırdı

            string ad;
            ad = "Aleyna";
            string soyad;
            soyad = "Güner";
            MessageBox.Show(ad + "" + soyad);
            //metinleri birleştirme işlemi yaptık

            int sayi1, sayi2;
            //sayi1 sayi2 kullanılmadığında altları yeşil çizgi olur, boşa yer kapladığını belirtiyo
            sayi1 = 3;
            sayi2 = 5;
            int toplam = sayi1 + sayi2;
            MessageBox.Show(toplam.ToString());
            //integer değeri stringe çevirmeliyiz yoksa hata verir

            string s1 = "5";
            string s2 = "3";
            string sonuc = s1 + s2;
            MessageBox.Show(sonuc);
            //sayıları metinsel olarak birleştirdik yani sonuca 53 yazar

            int x, y, bolum;
            x = 5;
            y = 2;
            bolum = x / y;
            MessageBox.Show(bolum.ToString());
            //bu şekilde doğru sonuç vermez sonuç direk 2 olur çünkü integer değişlenleri double yapmalıyız


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
