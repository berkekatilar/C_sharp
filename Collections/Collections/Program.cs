using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class --> T generic olduğunu gösterir birden fazla veri tipi alabilir (aslında obje)
            //System.Collection.Generic --> kullanır using ile eklemeti unutma başa
            // T-> object türündedir

            List<int> sayiListesi = new List<int>();//Yeni liste oluşturma
            sayiListesi.Add(12);
            sayiListesi.Add(25);
            sayiListesi.Add(64);
            sayiListesi.Add(10);
            sayiListesi.Add(46);
            sayiListesi.Add(78);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("yeşil");
            renkListesi.Add("mavi");
            renkListesi.Add("mor");
            renkListesi.Add("sarı");
            renkListesi.Add("kırmızı");

            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(12);
            renkListesi.Remove("yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(3);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste içinde arama
            if (sayiListesi.Contains(10))
                Console.WriteLine("10 liste içinde bulunmaktadır.");

            //eleman ile indexe erişim
            Console.WriteLine(renkListesi.BinarySearch("mor"));
            Console.WriteLine(renkListesi.BinarySearch("sarı"));


            //diziyi list'e dönüştürme
            string[] hayvanlar = { "kedi", "köpek", "at", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //Liste içerisinde nesne tutmak
            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Ayşe";
            kullanici1.Soyisim = "Yılmaz";
            kullanici1.Yas = 24;

            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Ahmet";
            kullanici2.Soyisim = "Yıldırım";
            kullanici2.Yas = 15;

            kullanıcıListesi.Add(kullanici1);
            kullanıcıListesi.Add(kullanici2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar()
                {
                    Isim = "Deniz",
                    Soyisim = "Arda",
                    Yas = 18
                });


            foreach (var kullanici in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanici.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanici.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + kullanici.Yas);
            }

            yeniListe.Clear();
        }

        public class Kullanıcılar
        {
            string isim;
            string soyisim;
            int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
    }
    
}
