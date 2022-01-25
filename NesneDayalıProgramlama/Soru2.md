## C#

> String fonksiyonları yazma




```
     class BenimString
        {


            public string kelime = "";

            //türkçe harflar olduğu için elden girilmiş char dizi
            //AZ Sırala fonksiyonu için
            public char[] harfler = new char[] { 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

  ```

> ELEMAN SAYİSİ



```
            public int ElemanSayisi(string kelime)
            {
                int sayac = 0;
                foreach (var item in kelime)
                {
                    //foreach kelime uzunluğu kadar döner
                    sayac++;
                }
                //sayac döndurulur.
                return sayac;
            }

 ```

> BİRLEŞTİRME 



```
            public string Birlestir(string kelime1, string kelime2)
            {
                //iki kelimenin uzunluğu kadar dönen for döngüsü
                for (int i = 0; i < (ElemanSayisi(kelime1) + ElemanSayisi(kelime2)); i++)
                {
                    //birinci kelime bitene kadar kelime değişkenine harf harf atılır.
                    if (i < ElemanSayisi(kelime1)) kelime += kelime1[i];

                    //birinci kelime bittikten sonra i- birinci kelime uzunluğuna yani 0 a döner 
                    //ikinci kelimenin 0. indexinden başlamak için
                    else kelime += kelime2[i - ElemanSayisi(kelime1)];

                }



                // kelime döndürülür.
                return kelime;
            }

  ```
  >ARAYA GİR 



   ```
   public string ArayaGir(int index, string kelime1, string araya_giren_kelime)
            {

                kelime = "";
                //iki kelime uzunluğu kadar dönen for döngüsü
                for (int i = 0; i < ElemanSayisi(kelime1) + ElemanSayisi(araya_giren_kelime); i++)
                {
                    //istenilen indexe kadar ilk kelime atılır.
                    if (i < index) kelime += kelime1[i];
                    //araya girilecek index gelince ikinci kelime atanır.
                    else if (i >= (index + ElemanSayisi(araya_giren_kelime))) kelime += kelime1[i - ElemanSayisi(araya_giren_kelime)];
                    //en son birinci kelimeden geriye kalanlar atanır
                    else kelime += araya_giren_kelime[i - index];


                }

                return kelime;
            }

```
>DEĞER AL



 ```
 public string DegerAl(int index1, int uzunluk, string kelime1)
            {
                kelime = "";
                //istenilen index ten başlar.
                //index  +  uzunluk toplamı kadar döner
                for (int i = index1; i < index1 + uzunluk; i++)
                {
                    //kelime uzunluk kadar kelimeye atanır.
                    kelime += kelime1[i];
                }


                return kelime;
            }

```

>DİZİYE AYIR



 ```
 public string[] DiziyeAyir(char harf, string kelime1)
            {
                int sayac = 0;
                //istenilen harften kaç adet var??
                for (int i = 0; i < ElemanSayisi(kelime1); i++)
                {
                    if (kelime1[i] == harf) sayac++;

                }

                //harf adeti +1 kadar parçaya bölünecek
                string[] kelime_parcalar = new string[sayac + 1];
                sayac = 0;
                kelime = "";


                //kelime uzunluğu kadar döner.
                for (int i = 0; i < ElemanSayisi(kelime1); i++)
                {
                    //kelimenin içinde istenilen harfe gelirse
                    if (kelime1[i] == harf)
                    {
                        //for dışında sayac tutarak kelime parçalar dizisine atama yapılır.
                        kelime_parcalar[sayac] = kelime;
                        sayac++;
                        //yeni parça kelime için kelime değişkeni sıfırlanır
                        kelime = "";
                    }

                    kelime += kelime1[i];
                }
                //en son parça diziye atılır ve return ile döndürülür.
                kelime_parcalar[sayac] = kelime;




                return kelime_parcalar;
            }


```

>CHAR DİZİYE DÖNÜŞTÜR



 ```
 public char[] CharDiziyeDonustur(string kelime1)
            {
                //kelime uzunluğu kadar char dizi oluşturulur
                char[] dizi = new char[ElemanSayisi(kelime1)];
                for (int i = 0; i < ElemanSayisi(kelime1); i++)
                {//kelimenin her harfi char dizide bir indexe atılır.
                    dizi[i] = kelime1[i];
                }



                return dizi;
            }


```
>DEGER İNDİS
 ```
 public int DegerIndis(string kelime, char aranan)
            {

                //kelime uzunluğu kadar döner
                for (int i = 0; i < ElemanSayisi(kelime); i++)
                {
                    //aranan harf kelime içinde varsa indexi döndürür
                    if (kelime[i] == aranan)
                    {
                        return i;
                    }

                }
                //yoksa -1 döndürür
                return -1;
            }

```

>DEGER İNDİS



 ```
 public int DegerIndis(string kelime1, string aranan_kelime)
            {
                // index_tutucu değişkeni bulunan kelimenin kaçıncı indexten başladığını tutar
                int sayac;
                int index_tutucu;


                //cumle kadar tekrar edecek döngü
                for (int i = 0; i < ElemanSayisi(kelime1); i++)
                {
                    //sayac aranilan kelimenin uzunluğuna gelmesi için arttırılıyor 
                    //başa dönünce sıfırlanıyor ki kaldığı yerden arttırmaya devam etmesin..
                    sayac = 0;

                    //aranilan kelimenin ilk harfine cümlede rastlanınca if içine giriyor.
                    if (kelime1[i] == aranan_kelime[0])
                    {
                        //aranilacak kelimenin uzunluğu cümleyi geçmesi halinde hata vermemesi için kontroller yapılıyor.
                        //aranan kelime kadar dönecek döngü
                        for (int j = 0; j < ElemanSayisi(aranan_kelime) && j < (ElemanSayisi(kelime1) - i); j++)
                        {
                            //eğer aranılan kelimeye uymayan harf gelirse döngü başa dönüyor.
                            if (kelime1[i + j] != aranan_kelime[j]) { break; }

                            //değilse devam eder 
                            index_tutucu = i;
                            sayac++;

                            //sayac aranan kelime uzunluğuna eşit olduğunda cümle içinde var demektir.
                            if (sayac == ElemanSayisi(aranan_kelime)) return index_tutucu;


                        }
                    }
                }
                return -1;
            }

```

>SIRALA A dan Zye



 ```
 public string SiralaAZ(string kelime1)
            {

                kelime = "";
                //alfabedeki harf sayısı kadar döner
                for (int i = 0; i < harfler.Length; i++)
                {
                    //kelime uzunluğu a kadar döner
                    for (int j = 0; j < ElemanSayisi(kelime1); j++)
                    {
                        //kelimenin içinde a dan başlayarak tek tek arama yapılır.
                        //büyük ve küçük olarak harf aranır.
                        if (kelime1[j] == harfler[i] || kelime1[j] == Convert.ToChar(harfler[i].ToString().ToLower(new CultureInfo("tr-TR", false))))
                        {
                            //kelime stringine tektek atama yapılır
                            kelime += kelime1[j];
                        }
                    }

                }
                return kelime;
            }


```

>SIRALA Z den Aya



```

            public string SiralaZA(string kelime1)
            {
                kelime = "";

                //sırala a-z gibi ama for döngüsü bu hafrler dizisinin uzunluğundan başlayarak 0 a doğru gidiyor.
                for (int i = harfler.Length - 1; i >= 0; i--)
                {
                    for (int j = 0; j < ElemanSayisi(kelime1); j++)
                    {
                        //kelimenin içinde a dan başlayarak tek tek arama yapılır.
                        //büyük ve küçük olarak harf aranır.
                        if (kelime1[j] == harfler[i] || kelime1[j] == Convert.ToChar(harfler[i].ToString().ToLower(new CultureInfo("tr-TR", false))))
                        {
                            kelime += kelime1[j];
                        }
                    }

                }



                return kelime;
            }

```

>TERS ÇEVİR



```
            public string TersCevir(string kelime1)
            {

                kelime = "";
                //kelime uzunluğundan 0 a kadar giden for döngüsü
                for (int i = ElemanSayisi(kelime1) - 1; i >= 0; i--) kelime += kelime1[i];


                return kelime;
            }



        }




```

> Program sınıfı



```
        class Program
        {
            static void Main(string[] args)
            {
                //kendi ad ve soyadımı fonksiyonlara yolladım
                string kelime1 = "Rabia";
                string kelime2 = "Abdioğlu";
                char harf = 'a';
                BenimString benimString = new BenimString();


                Console.Write("" +
                    "Eleman sayisi                :   " + benimString.ElemanSayisi(kelime1) + "\n\n" +
                    "Birleştir                    :   " + benimString.Birlestir(kelime1, kelime2) + "\n\n" +
                    "Index Bul                    :   " + benimString.DegerIndis(kelime1, harf) + " \n\n" +
                    "Araya Gir                    :   " + benimString.ArayaGir(3, kelime1, kelime2) + "\n\n" +
                    "Deger Al                     :   " + benimString.DegerAl(3, 5, benimString.Birlestir(kelime1, kelime2)));

                //dizi döndürdüğü için  foreach ile tek tek yazdırma yapılıyor..

                Console.Write("\n\nDiziye Ayir                  :   ");
                foreach (var item in benimString.DiziyeAyir(harf, kelime1))
                {
                    Console.Write(item + " - ");

                }


                Console.Write("\n\nChar Diziye Dönüştür         :   ");

                // char döndüğğü anlaşılması için 
                Console.Write(benimString.CharDiziyeDonustur(kelime1).GetType() + "         ");

                foreach (var item in benimString.CharDiziyeDonustur(kelime1))
                {
                    Console.Write(item + " - ");

                }


                Console.Write("" +
                    "" + "\n\nDeğer Indis                  :   " + benimString.DegerIndis(kelime1, harf) +
                    "" + "\n\nDeğer Indis(overloading)     :   " + benimString.DegerIndis(kelime1, "ia") +
                    "" + "\n\nA-Z Sırala                   :   " + benimString.SiralaAZ(kelime2) +
                    "" + "\n\nZ-A Sırala                   :   " + benimString.SiralaZA(kelime2) +
                    "" + "\n\nTers Çevir                   :   " + benimString.TersCevir(kelime1));

            }
        }
```
