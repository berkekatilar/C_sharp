Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Convert.ToString(Console.ReadLine());

            string[] parcalanmısCumle = cumle.Split(" ");
            char[] harf = cumle.ToCharArray();
            int ktoplam = 0;
            int htoplam = 0;


            foreach (var item in parcalanmısCumle)
            {
                ktoplam++;
            }

            foreach (var item in harf)
            {
                if(item == ' ')
                {
                    continue;
                }
                htoplam++;
            }

            Console.WriteLine("Kelime sayısı: " +ktoplam);
            Console.WriteLine("Harf Toplamı: " +htoplam);