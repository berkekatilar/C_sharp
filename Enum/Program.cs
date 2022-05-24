using System;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazartesi);
            Console.WriteLine((int)Gunler.pazartesi); 
            Console.WriteLine((int)Gunler.sali);

            Console.WriteLine((int)Gunler.persembe); 
            Console.WriteLine((int)Gunler.cuma);

            int derece = int.Parse(Console.ReadLine());
            if ((int)havadurumu.soguk>derece)//şeklinde if ve döngü blokları içinde kullanılabilir
            {
                Console.WriteLine("Hava çok soğuk dışarı çıkılmaz");
            }
            else if((int)havadurumu.normal>derece && (int)havadurumu.soguk<derece)
            {
                Console.WriteLine("Hava güzel dışarı çıkılabilir");
            }
           
        }
    }

    enum Gunler // classların dışında oluşturulur.  Sıralı numerik verileri anlamlı hale getiren okunurluğu arttıran elemanlardı strin-int çifti gibi düşünülebilir.
    {
        //misal program içinde 1.gün 2.gün şeklinde yazmak yerine bir enum oluşturulabilir.
        pazartesi, // ilk elemanın default değeri 0 olarak başlar ve ardışık devam eder 
        sali,
        carsamba, 
        persembe=23, //23
        cuma,//24 şeklinde otomatik devam eder
        cumartesi,
        pazar,
    }


    enum havadurumu 
    { 
        soguk=-5, // şeklinde istediğin değerleri hepsini kendin de atayabiliyon
        normal=15,
        sicak=20,
        cok_sicak=30,
    }
}
