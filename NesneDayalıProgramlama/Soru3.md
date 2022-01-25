## C#

> Tahtaya Rastgele Kale Yerleştirme




```
    class Program
    {
        private static bool BittiMi(string[,] tahta)
        {
            // eğer olması gerekenden fazla veya az kale varsa yerleştirme bitmemiştir.
            int sayac = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (tahta[i, j] == "K") sayac++;
                }
            }
            //yerleştirme işlemi bitmiştir true döndürür.
            if (sayac == 8) return true;
            //yerleştirme bitmediği için false döndürür.
            else return false;

        }



        private static void Ciz(string[,] tahta)
        {
            // 8x8 lik tahta çizer.
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    // tahta dizisinde ki karakterleri  tahtaya yazar
                    Console.Write(tahta[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {

            int index1=0, index2=0;
            bool yemeDurumu = false;

            //8x8 lik string dizisi 
            String[,] tahta = new String[8,8];
            
          //  başlarken tahta dizisinin tüm elemanlarını sıfır yapar
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tahta[i, j] = "0";

                }
              
            }

            //Rastgele sayı almak için nesne oluşturulur.
            Random random = new Random();
         


            do
            {
                yemeDurumu = false;
                int sayac = 0;
                // random iki index değeri alınır.
               index1 = random.Next(8);
               index2 = random.Next(8);
                
                //random alınan index değerlerini kale koyulur.
               tahta[index1,index2] = "K";
                Ciz(tahta);

                //yeni koyulan kalenin diğer kaleler ile yenilme durumu kontrol edilir.
                for (int i = 0; i < 8; i++)
                {
                    if (tahta[i, index2] == "K") sayac++;

                    if (tahta[index1, i] == "K") sayac++;

                    // eğer sayac 2 den büyükse aynı satır veya sütunda yeme durumu olan kaleler vardır.
                    if(sayac>2) yemeDurumu = true;
                }

                sayac = 0;

                //eğer yeme durumu varsa yeni index belirlenir. yeni koyulan kale silinir.
                Console.WriteLine("\nKontrol ediliyor...");
                System.Threading.Thread.Sleep(1000);

                if (yemeDurumu==true)
                {
                    // index1 ve index2 değişkenlerinde tutulan kalenin konumu yeme durumu olduğu için 0 yapılır 
                    
                    tahta[index1, index2] = "0";

                    Console.WriteLine("\nYeme durumu var. Tekrar konumlandırılıyor..");

                    System.Threading.Thread.Sleep(2000);

                }

                Console.Clear();

                // bittimi fonksiyonundan true değer döndüğü zaman döngüden çıkar
            } while (BittiMi(tahta)==false);

            Console.Clear();
            Ciz(tahta);
            Console.WriteLine("\nTüm Kaleler Yerleştirildi....\n\n");
     


        }


    }
