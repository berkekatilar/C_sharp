using System;
using System.Collections;
using System.Linq;

namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            ArrayList asal = new ArrayList();
            ArrayList asal_degil = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                string deger = Console.ReadLine();
                while (true)
                {


                    if (Int32.TryParse(deger, out sayilar[i]))
                    {
                        sayilar[i] = int.Parse(deger);
                        if(sayilar[i] < 1)
                        {
                            Console.WriteLine("Lutfen pozitif tam sayi giriniz");
                            deger = Console.ReadLine();
                        }
                        else { break; }
                        
                    }
                    else
                    { 
                        Console.WriteLine("Lutfen pozitif tam sayi giriniz");
                        deger=Console.ReadLine();
                    }
                }

                if (sayilar[i] == 1)
                    asal_degil.Add(sayilar[i]);
                else if (sayilar[i] == 2)
                    asal.Add(sayilar[i]);
                for (int j = 2 ; j < sayilar[i]; j++)
                    {
                        
                        if (sayilar[i] % j == 0 || sayilar[i]==1)
                        {
                            asal_degil.Add(sayilar[i]);
                            break;
                        }
                        else
                        {
                            asal.Add(sayilar[i]);
                            break;
                        }
                    }
            }
            float sum = 0;
            if (asal_degil.Count > 0)
            {
                asal_degil.Sort();
                Console.Write("Asal olmayan sayılar \n");
                foreach (int a in asal_degil)
                {
                    Console.Write(a + " ");
                    sum = sum + a;
                }
                Console.Write("\nDizi " + asal_degil.Count + " uzunluğundadır.\n " + "Dizinin ortalaması = " + (sum / asal_degil.Count)+"\n******************************\n");
            }
            else
                Console.WriteLine("Asal sayı olmayan sayı yok\n**************************");



            if (asal.Count > 0)
            {
                sum = 0;
                asal.Sort();
                Console.WriteLine("Asal sayılar \n");
                foreach (int a in asal)
                {
                    Console.Write(a + " ");
                    sum = sum + a;
                }
                Console.WriteLine("\nDizi " + asal.Count + " uzunluğundadır. " + "Dizinin ortalaması = " + (sum / asal.Count)+ "\n******************************\n");
            }
            else
                Console.WriteLine("\nAsal sayı yok\n**************************");
            
        }
    }
}
