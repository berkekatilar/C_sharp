 try //hata olması muhtemel kod bloğu
            {
                Console.WriteLine("Bir sayı giriniz :");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı : " + sayi);
            }
            catch (Exception ex) //Hata alındığında çalışır
            {
                Console.WriteLine("Hata :" + ex.Message.ToString());
            }
            finally //Hata olsun olmasın çalışır
            {
                Console.Write("İşlem tamamlandı.");
            }



            try
            {
                Console.WriteLine("Bir sayı daha giriniz");
                int a = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("NULL girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi yanlış.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Değişkenin range'i dışında değer.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }