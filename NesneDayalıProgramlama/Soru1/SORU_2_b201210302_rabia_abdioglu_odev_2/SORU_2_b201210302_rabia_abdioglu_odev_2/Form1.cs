


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SORU_2_b201210302_rabia_abdioglu_odev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult durum = MessageBox.Show("Text dosyasındaki işlemler silinsin mi?", " ", MessageBoxButtons.YesNo);
            if (durum == DialogResult.Yes)
            {
                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Rabia\Desktop\ödev2\soru2\islemler.txt", false))
                    dosya.Write(" ");
                MessageBox.Show("İşlemler silindi..");
            }

        }

        public static bool Karematrismi(double[,] X)

        {
            //matrisin satır ve sütun sayıları eşitse true değer döndürüyor.
            return X.GetLength(0) == X.GetLength(1) ?

                true : false;

        }

        //string diziyi double diziye çeviriyor.
        public double[,] diziye_cevir(string gelen, int x, int y)
        {
            //satır ve sutun sayıları i/j
            int i = 0, j = 0;
            //geri dönecek olan double dizi
            double[,] dizi = new double[x, y];
            //string değer içindeki tamsayıları alır.
            string[] sayilar = Regex.Split(gelen, @"\D+");
            //sayilar dizisi kadar dönen for
            for (int k = 0; k < sayilar.Length; k++)
            {
                int sayi;
                //sayilar dizisindeki değerlerinn sayı olduğuna bakar
                if (int.TryParse(sayilar[k], out sayi))
                {
                    //j sutun sayısını olan y değerinden küçükse
                    if (j < y)
                    {
                        //diziye sayilar double olarak alınır.
                        dizi[i, j] = Convert.ToDouble(sayilar[k]);
                        j++;
                    }
                    //eğerbir sonraki satıra geçilirse
                    //satır sayısı(i) artar 
                    //sutun sayısı (j) 0 a döner
                    //k değeri bir azaltılırki değer kaybı olmasın
                    else if (j >= y || i >= x) { i++; j = 0; k--; }
                }
            }

            /*   for (int k = 0; k < x; k++)
               {
                   for (int o = 0; o < y; o++)
                   {
                       richTextBox4.Text += dizi[k,o] + "-";
                   }

                   richTextBox4.Text += "\n";

               }*/

            //richtextbox tan alınan string değeri dizi olarak döndürüyor.
            return dizi;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //diziye cevir ile yollanacak dizilerin satir ve sütun sayisi 
            int a_boyut_1 = richTextBox1.Text.Split('\n').Length,
                a_boyut_2 = (richTextBox1.Text.Split(' ').Length) / a_boyut_1 + 1,
                b_boyut_1 = richTextBox2.Text.Split('\n').Length,
                b_boyut_2 = (richTextBox2.Text.Split(' ').Length) / b_boyut_1 + 1;


            /// içten dışa bakılırsa.
            /// önce string değişken diziye çevriliyor.
            /// matris sınıfındaki istenen fonksiyon çağrılıyor 
            /// geri dönen string değer sonuc richtextbox a yazılıyor.
            /// 
            if (radioButton2.Checked)
                richTextBox3.Text = Matris.carpma(diziye_cevir(richTextBox1.Text, a_boyut_1, a_boyut_2), diziye_cevir(richTextBox2.Text, b_boyut_1, b_boyut_2));

            else if (radioButton3.Checked)
                richTextBox3.Text = Matris.tersi(diziye_cevir(richTextBox1.Text, a_boyut_1, a_boyut_2));

            else if (radioButton4.Checked)
                richTextBox3.Text = Matris.izi(diziye_cevir(richTextBox1.Text, a_boyut_1, a_boyut_2));

            else if (radioButton5.Checked)
                richTextBox3.Text = Matris.transpoz(diziye_cevir(richTextBox1.Text, a_boyut_1, a_boyut_2));

            else
                richTextBox3.Text = Matris.toplama(diziye_cevir(richTextBox1.Text, a_boyut_1, a_boyut_2), diziye_cevir(richTextBox2.Text, b_boyut_1, b_boyut_2));



        }
        private void textbox_etkin(object sender, EventArgs e)
        {
            // seçilen işleme göre gerekli olan bölümleri aktif ediyor.
            // yanlış sonuçlar alınmasını engellemek için

            richTextBox1.Enabled = true;
            richTextBox2.Enabled = true;
        }

        //Dosya görüntüle butonu
        private void textbox_etkin_2(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            richTextBox2.Enabled = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {

            using (StreamReader dosya = File.OpenText(@"C:\Users\Rabia\Desktop\ödev2\soru2\islemler.txt"))
            {
                //text dosyasını satır satır okuyor. 

                string satir = "";
                while ((satir = dosya.ReadLine()) != null)
                {
                    richTextBox4.Text += satir + "\n";
                }
            }

        }
        //temizle butonu
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox4.Text = " ";
        }

        //işlemi kaydet butonu
        private void button4_Click(object sender, EventArgs e)
        {
            //eğer sonuç richtextbox boş ise işlem yapılmamış sayar
            if (richTextBox4.Text == null) richTextBox4.Text = "Önce işlem yapınız..";
            else
            {

                string islem_adi = "";
                //hangi işlem yapıldıysa butonun textini islem adina atıyor.
                if (radioButton1.Checked) islem_adi = radioButton1.Text;
                else if (radioButton2.Checked) islem_adi = radioButton2.Text;
                else if (radioButton3.Checked) islem_adi = radioButton3.Text;
                else if (radioButton4.Checked) islem_adi = radioButton4.Text;
                else if (radioButton5.Checked) islem_adi = radioButton5.Text;


                //text dosyasına yapılan işlemi kaydediyor

                using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Rabia\Desktop\ödev2\soru2\islemler.txt", true))

                    //yapılan işlem dosyaya yazdırılıyor.
                    dosya.Write("\nYapılan işlem      :    " + islem_adi + "" +
                                "\n\nMatris_A           :\n\n" + richTextBox1.Text + "" +
                                "\n\nMatris_B           :\n\n" + richTextBox2.Text +
                                "\n\nSonuç              :\n\n" + richTextBox3.Text+"" +
                                "___________________________________________________________________");


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter dosya = new System.IO.StreamWriter(@"C:\Users\Rabia\Desktop\ödev2\soru2\islemler.txt", false))
                dosya.Write(" ");
            richTextBox4.Text = " ";

        }
    }




    ///////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// ////////MATRİS SINIFI  VE FONKSİYONLARI
    /// </summary>
    /// 
    public static class Matris
    {
        public static string Yazdir(double[,] matris_C)
        {
            string yedek = "";
            //C matrisi sonuç matrisidir.
            //matris boyutları kadar dönen for döngüleri
            for (int i = 0; i < matris_C.GetLength(0); i++)
            {
                for (int j = 0; j < matris_C.GetLength(1); j++)
                {
                    //yedek stringe atıyor
                    yedek += Convert.ToString(matris_C[i, j]) + "      ";
                }
                yedek += "\n\n";
            }
            //string olarak sonucu döndürüyor
            return yedek;
        }

        ///Toplama işlemi 
        public static string toplama(double[,] matris_A, double[,] matris_B)
        {
            double[,] matris_C = new double[matris_A.GetLength(0), matris_A.GetLength(1)];

            // toplama işlemi için matrisler eşit boyutlarda olmalı 
            //boyut kontrolü
            if (matris_A.GetLength(0) == matris_B.GetLength(0) && matris_A.GetLength(1) == matris_B.GetLength(1))
            {
                for (int i = 0; i < matris_A.GetLength(0); i++)
                {
                    for (int j = 0; j < matris_A.GetLength(1); j++)
                    {
                        //her index diğer matristeki index ile toplanıyor
                        matris_C[i, j] = matris_A[i, j] + matris_B[i, j];

                    }
                }
                //yazdir metodu ile sonuç matrisi stringe çevriliyor.
                return Yazdir(matris_C);
            }
            else return "Matrislerin boyutları aynı değil..";

        }

        ///Çarpma işlemi
        public static string carpma(double[,] matris_A, double[,] matris_B)
        {
            double[,] matris_C = new double[matris_A.GetLength(0), matris_A.GetLength(1)];


            if (matris_A.GetLength(1) == matris_B.GetLength(0))
            {
                //a matrisi satırı kadar döner
                for (int i = 0; i < matris_A.GetLength(0); i++)
                {
                    //b matrisi sütunu kadar döner

                    for (int j = 0; j < matris_B.GetLength(1); j++)
                    {
                        for (int k = 0; k < matris_A.GetLength(1); k++)
                        {
                            //çarpım sonucunu atar
                            matris_C[i, j] += matris_A[i, k] * matris_B[k, j];
                        }

                    }

                }
                //sonuc matrisi döndürür
                return Yazdir(matris_C);

            }
            else return " Birinci matristeki sütun sayısı ikinci matristeki satır sayısına eşit olmalı...";



        }

        ///Tersi alma işlemi
        public static string tersi(double[,] matris_A)
        {
            //determinantı 0 olamaz ?? yetişmedi
            // kare matris olmalı

            if (Form1.Karematrismi(matris_A))
            {

                double sayi1, sayi2;
                double[,] matris_C = new double[matris_A.GetLength(0), matris_A.GetLength(0)];


                //köşegen hariç diğer indexleri 0 olan c matrisi yapılıyor.
                for (int i = 0; i < matris_A.GetLength(0); i++)
                {
                    for (int j = 0; j < matris_A.GetLength(0); j++)
                    {
                        if (i == j) matris_C[i, j] = 1;
                        else matris_C[i, j] = 0;

                    }

                }

                for (int i = 0; i < matris_A.GetLength(0); i++)
                {
                    //köşegen indexi sayi1 e atıyor
                    sayi1 = matris_A[i, i];

                    //a matrisi satırı kadar döner
                    for (int j = 0; j < matris_A.GetLength(0); j++)
                    {
                        //matrisleri köşegen indexine bölüp tekrar matrislere atıyor
                        matris_A[i, j] = matris_A[i, j] / sayi1;
                        matris_C[i, j] = matris_C[i, j] / sayi1;
                    }

                    //
                    for (int k = 0; k < matris_A.GetLength(0); k++)
                    {
                        //eğer eşit olmayan sayılarda k,i indexli değeri kendisiyle çarpıp kendisinde çıkarıyor.
                        if (k != i)
                        {
                            sayi2 = matris_A[k, i];

                            for (int j = 0; j < matris_A.GetLength(0); j++)
                            {
                                matris_A[k, j] = matris_A[k, j] - (matris_A[i, j] * sayi2);
                                matris_C[k, j] = matris_C[k, j] - (matris_C[i, j] * sayi2);
                            }
                        }
                    }

                }

                //sonuç matrisi döndürüyor
                return Yazdir(matris_C);
            }
            else

                return "Matris Kare değil..";
        }
        public static string izi(double[,] matris_A)
        {
            double sayi1 = 0;
            //nxn kare matris olmalıdır
            if (Form1.Karematrismi(matris_A))
            {
                //izi köşegendeki sayılar toplanır 

                for (int i = 0; i < matris_A.GetLength(0); i++) sayi1 += matris_A[i, i];
                //sonuç string olarak döndürülür.
                return sayi1.ToString();
            }
            else return "Matris Kare değil..";

        }
        //Transpoz işlemi
        public static string transpoz(double[,] matris_A)
        {
            double[,] matris_C = new double[matris_A.GetLength(1), matris_A.GetLength(0)];

            //a matrisinin satırı ve sutunu kadar dönen for

            for (int i = 0; i < matris_A.GetLength(0); i++)
            {
                for (int k = 0; k < matris_A.GetLength(1); k++)
                {
                    //sonuç matrisine ters şekilde atama yapar

                    //transpoz(evriği) matrisin satırlarının sutun olarak yer değiştirmesi ile olur
                    matris_C[k,i] = matris_A[i,k];
                }
            }

            //sonuc matrisi döndürülür..
            return Yazdir(matris_C);

        }

    }

}