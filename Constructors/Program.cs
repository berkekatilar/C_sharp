using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Berke";
            calisan1.soyad = "Katılar";
            calisan1.bolum = "Mühendis";
            calisan1.no = 1;

            Calisan calisan2= new Calisan("Filiz","Katılar","Mühendis",2);

            Calisan calisan3 = new Calisan("Bülen", "Şenemci");

            Console.WriteLine("******Çalışan1******\n");
            calisan1.CalisanBilgiler();
           
            Console.WriteLine("******Çalışan2******\n");
            calisan2.CalisanBilgiler();
            
            Console.WriteLine("******Çalışan1******\n");
            calisan3.CalisanBilgiler();
                
        }
    }

    public class Calisan
    {
        public string ad;
        public string soyad;
        public string bolum;
        public int no;
        public Calisan(string isim,string soyisim, string departman, int numara)
        {
            this.ad = isim;         //this.ad derken bu classtaki yani calisan classındaki adı almış oluyoruz. this bu class'ın elemanı demek
            this.soyad = soyisim;       
            bolum = departman;      //böyle yazmakla aynı şey
            no = numara;
        }
        
        public Calisan() { } // şeklinde boş overload edilirse main içinde class'ı oluştururken parametre vermeden oluşturursak hata vermez yoksa parametre bekler

        public Calisan(string isim, string soyisim) // ya da şeklinde overload edersek sadece bu parametreleri aldığında da hata vermez
        {
            this.ad = isim;       
            this.soyad = soyisim;
        }

        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı = {0}",ad);
            Console.WriteLine("Çalışan Soyadı = {0}", soyad);
            Console.WriteLine("Çalışan Bölümü = {0}", bolum);
            Console.WriteLine("Çalışan No = {0}", no);
        }
    }
}
