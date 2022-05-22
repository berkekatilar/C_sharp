using System;

namespace Koleksiyonlar_Soru_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] sayilar = new int[20];

			for (int i=0;i<20;i++)
            {
				string deger = Console.ReadLine();
				while (true)
				{
					if (int.TryParse(deger, out sayilar[i]))
					{
						sayilar[i]=int.Parse(deger);
						break;
					}
					else
					{
						Console.WriteLine("Lütfen bir sayı giriniz");
						deger = Console.ReadLine();
					}
				}
            }
			Array.Sort(sayilar);
			Console.WriteLine("Dizinin en büyük üç elemanı = " + sayilar[sayilar.Length - 3] + " , " + sayilar[sayilar.Length - 2] + " , " + sayilar[sayilar.Length - 1] + "\nDizinin en büyük üç elemanı = " + sayilar[0] + " , " + sayilar[1] + " , " + sayilar[2]);
			float kucuk_avg = (float)(sayilar[0] + sayilar[1] + sayilar[2]) / 3;
			float buyuk_avg = (float)(sayilar[sayilar.Length - 3] + sayilar[sayilar.Length - 2] + sayilar[sayilar.Length - 1]) / 3;
			Console.WriteLine("En büyük üç sayının ortalaması = " + buyuk_avg + "\nEn küçük üç sayının ortalaması = " + kucuk_avg);
		}
	}
}
