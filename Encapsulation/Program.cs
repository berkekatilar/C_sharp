using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenciler Ogrenci1=new Ogrenciler();
            Ogrenci1.Isim = "Berke";
            Ogrenci1.Soyisim = "Katılar";
            Ogrenci1.Sinif = 2;
            Ogrenci1.No = 416;

            Console.WriteLine("******Öğrenci 1******");
            Ogrenci1.OgrenciBilgileri();

            Ogrenci1.Sinif_dusur();
            Ogrenci1.Sinif_dusur();
            Ogrenci1.Sinif_dusur();
        }
    }
    class Ogrenciler
    {
        private string isim;
        private string soyisim;
        private int sinif;
        private int no;


        public Ogrenciler(){}

        public Ogrenciler(string Isim, string Soyisim, int Sinif, int No)
        {
            isim = Isim;
            soyisim = Soyisim;
            sinif = Sinif;
            no = No;
        }
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        public int Sinif
        {
            get { return sinif; }
            set {
                if (Sinif < 1)
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz");
                    sinif = 1;
                }
                else    
                    sinif = value; 
                }
        }

        public void OgrenciBilgileri()
        {
            Console.WriteLine("Ögrencinin Adı       = {0}", Isim);
            Console.WriteLine("Ögrencinin Soyadı    = {0}", Soyisim);
            Console.WriteLine("Ögrencinin Sınıfı    = {0}", Sinif);
            Console.WriteLine("Ögrencinin Numarası  = {0}", No);
        }
        
        public void Sinif_dusur()
        {
            Sinif = Sinif - 1;
        }

        public void Sinif_yukselt()
        {
            Sinif = Sinif + 1;
        }
    }
}
