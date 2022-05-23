using System;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);//Calisan class'ına ilk erişim burdadır ve burda static constructor çalışmıştır

            Calisan calisan_1 = new Calisan("atakan", "uludağ", "Software Developer");
            Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
            calisan_1.EkranaYazdir();

            //Islemler islemler1 = new Islemler(); --> Şeklinde static class içinde nesne tanımlanamaz 
            //içlerindeki veriye, metotlara vs direk class isimleriyle erişilir
            long toplama = Islemler.Topla(100, 200);
            long cikarma = Islemler.Cikar(400, 50);
            Console.WriteLine("Toplama işlemi : --> {0}", toplama);
            Console.WriteLine("Çıkarma işlemi : --> {0}", cikarma);
        }
    }

    class Calisan
    {
        public static int calisanSayisi; //statik field tanımlama
        public static int CalisanSayisi 
        {
            get { return calisanSayisi; } // static field'in encapsulation'u

        }
        private string Isim;
        private string Soyisim;
        private string Departman;
        static Calisan() // static constructor tanımlama
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman) // normal constructor
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
        public void EkranaYazdir()
        {
            Console.WriteLine("İsim : {0}", Isim);
            Console.WriteLine("Soyİsim : {0}", Soyisim);
            Console.WriteLine("Departman: {0}", Departman);
        }
    }

    static class Islemler //static class tanımlama (içindeki hiçbir değişken metot vs static dışında tanımlanamaz hepsi static'tir)
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
