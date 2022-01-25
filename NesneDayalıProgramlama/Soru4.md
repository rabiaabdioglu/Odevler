## C#

> String fonksiyonları yazma




```
    class Program
    { 
        
        // 1. secim için metot
        private static void secim1(string aranilacak_kelime, string karakter_dizini)
        {
            // index_tutucu değişkeni bulunan kelimenin kaçıncı indexten başladığını tutar
            int sayac;
            int index_tutucu;

            //string olan değişkenleri char dizi yaptıktan sonra her harf tektek kontrol edilir.
            char[] char_aranilacak_kelime = aranilacak_kelime.ToCharArray();
            char[] char_karakter_dizini = karakter_dizini.ToCharArray();


            //cumle kadar tekrar edecek döngü
            for (int i = 0; i < karakter_dizini.Length; i++)
            {
             //sayac aranilan kelimenin uzunluğuna gelmesi için arttırılıyor 
             //başa dönünce sıfırlanıyor ki kaldığı yerden arttırmaya devam etmesin..
                sayac = 0;
           

                //aranilan kelimenin ilk harfine cümlede rastlanınca if içine giriyor.
                if (char_karakter_dizini[i] == char_aranilacak_kelime[0])
                {
                   //aranilacak kelimenin uzunluğu cümleyi geçmesi halinde hata vermemesi için kontroller yapılıyor.
                   //aranan kelime kadar dönecek döngü
                    for (int j = 0; j < aranilacak_kelime.Length && j<(karakter_dizini.Length-i); j++)
                    {
                        //eğer aranılan kelimeye uymayan harf gelirse döngü başa dönüyor.
                        if (char_karakter_dizini[i + j] != char_aranilacak_kelime[j])  { break;}

                        //değilse devam eder 
                        index_tutucu = i;
                        sayac++;
                      
                        //sayac aranan kelime uzunluğuna eşit olduğunda cümle içinde var demektir.
                        if (sayac == aranilacak_kelime.Length) Console.WriteLine( "\nKelime  " + aranilacak_kelime + "  / indis :   " + index_tutucu);


                    }   }    }        }
        // 2. secim için metot

        private static void secim2(string aranilacak_kelime, string karakter_dizini)
        {
            //subtring metodu kullanarak kelime aranır.
            
            for (int i = 0; i < karakter_dizini.Length-aranilacak_kelime.Length+1; i++)
            {
                //cümlenin i indexli elemanindan itibaren , aranan kelime uzunluğuna kadar olan kelime alınır.
                // aranan kelimeye eşit ise ekrana yazdırılır.

                if (karakter_dizini.Substring(i,aranilacak_kelime.Length).Equals(aranilacak_kelime))

                    { Console.WriteLine("\nKelime  " + aranilacak_kelime + "  / indis :   " + i); }  }   }
     
        // 3. secim için metot

        private static void secim3(string karakter_dizini)
        {

            Console.Clear();
            Console.WriteLine(karakter_dizini+"\n\n" +
                " karakter sayısı       |        grafik gösterimi\n" +
                "___________________________________________________");
            int sayac ;
            //türkçe karakterler olduğundan harfler dizisi oluşturulur.
            char[] harfler = new char[] {'A','B','C','Ç','D','E','F','G','Ğ','H','I','İ','J','K','L','M','N','O','Ö','P','R','S','Ş','T','U','Ü','V','Y','Z' };

            //dizi kadar dönen döngü
            for (int i = 0; i <harfler.Length; i++)
            {
                // sayac harfin kaç adet olduğunu sayar ve yeni harfe geçince sıfırlanır.
                sayac = 0;
                //cümle uzunluğu kadar dönen döngü
                 for (int j = 0; j < karakter_dizini.Length ; j++)
                {

                    // cümlenin içinde istenilen harf büyük veya küçük olarak varsa sayac artar.
                    if (karakter_dizini[j]==harfler[i]|| karakter_dizini[j].ToString()==harfler[i].ToString().ToLower())    sayac++;      
                }


                 //ekrana yazdırılır.
                Console.Write("\n" + harfler[i] + ",   sayısı :   " + sayac +"\t");

                // sayac kadar * işareti koyulur. grafik gösterimi için.
                for (int k = 0; k < sayac; k++)
                { Console.Write("* ");    } 
            } }

    
        static void Main(string[] args)
        {
          
            Console.Write("\t\tMenu\n" +
                "1-String bir değişkende, string değer substring kullanmadan ara.\n" +
                "2-String bir değişkende, string değer substring kullanarak ara.\n" +
                "3-Alfabenin karakterlerini bir string de ara. Kaç adet geçiyor bul ve çiz.\n" +
                " \n  Seçiminiz :   ");

            char secim = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nkelime girin");
            
            //string nesnesi olan karakter dizini 
            String karakter_dizini = new String(Console.ReadLine());

            string aranilacak_kelime = "";

            // seçime göre metot çağrılır.
            switch (secim)
            {
                case '1':
                    Console.WriteLine("\naranacak karakteri giriniz :");
                    aranilacak_kelime = Console.ReadLine();
                    Console.WriteLine("______________________________________________" ); 
                    secim1(aranilacak_kelime,karakter_dizini); ; break;
                case '2':
                    Console.WriteLine("\naranacak karakteri giriniz :");
                    aranilacak_kelime = Console.ReadLine();
                    Console.WriteLine("______________________________________________"); 
                    secim2(aranilacak_kelime, karakter_dizini); ; break;
                case '3': 
                    Console.WriteLine("______________________________________________"); 
                    secim3( karakter_dizini); ; break;


                default:
                    break;
            }

        }

      
    }
```
