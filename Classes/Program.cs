using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.ad = "Berke";
            calisan1.soyad = "Katılar";
            calisan1.departman = "Mühendis";
            calisan1.no = 1;

            Calisan calisan2= new Calisan();
            calisan2.ad = "Filiz";
            calisan2.soyad = "Katılar";
            calisan2.departman = "Mühendis";
            calisan2.no = 2;

            calisan1.CalisanBilgiler();
            Console.WriteLine("*********************************");
            calisan2.CalisanBilgiler();

        }
    }

    class Calisan
    {
        public  string ad;
        public  string soyad;
        public  string departman;
        public  int no;


        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı = {0}" ,ad);
            Console.WriteLine("Çalışan Soyadı = {0}" ,soyad);
            Console.WriteLine("Çalışan Departmanı = {0}", departman);
            Console.WriteLine("Çalışan No = {0}", no);
        }
    }
}

