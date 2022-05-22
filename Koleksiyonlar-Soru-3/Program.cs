using System;
using System.Collections;
namespace Koleksiyonlar_Soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cumle=Console.ReadLine();
            ArrayList cumle_dizi = new ArrayList();
            ArrayList sesli_dizi = new ArrayList();
            foreach (var i in cumle)
                cumle_dizi.Add(i);
            Console.WriteLine("Girilen cümlenin uzunluğu = "+cumle.Length);

            for(int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i]=='a'|| cumle[i] == 'e'|| cumle[i] == 'ı'|| cumle[i] == 'i'|| cumle[i] == 'o'|| cumle[i] == 'ö'|| cumle[i] == 'u'|| cumle[i] == 'ü')
                {
                    sesli_dizi.Add(cumle[i]);
                }
            }
            Console.Write("Yazılan cümle içindeki sesli harfler =");
            foreach (var a in sesli_dizi)
            { 
                Console.Write(" " + a); 
            }
        }
    }
}
 