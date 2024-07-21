using System;

namespace manavUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rüya Manavı'na hoşgeldiniz!");
            Console.WriteLine("Elma=2 TL\nArmut=3 TL\nÇilek=2 TL\nMuz=3 TL\nDiğer bütün meyveler=4 TL\n\n");

            Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

            /*string meyve = Console.ReadLine().ToLower(); // Büyük harf ile kullanıcı girişi olmasına karşın ToLower kullanıldı.

            if (string.IsNullOrEmpty(meyve)) // Eğer veri olmazsa ekrana sonuç vermeyecek
            {
                Console.Write("Boş değer girdiniz.\n ");
                return;
            }
            else if (!string.IsNullOrEmpty(meyve))
            {
                if (meyve == "elma")
                {
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL'dir.");

                }

                else if (meyve == "armut")
                {
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL'dir.");
                }

                else if (meyve == "çilek")
                {
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 2 TL'dir.");
                }

                else if (meyve == "muz")
                {
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 3 TL'dir.");
                }

                else if (meyve == "diğer")
                {
                    Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4 TL'dir.");
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz meyve listede yoksa diğer olarak belirtiniz.");
                }

            }
        }*/

            // İstenilen uygulamada çok fazla girdi var. else if yapılarında tüm if yapılarına girip kontrol edilmesi yeri, switch case'de her case yapısında break komutu olduğu için hepsine girmeyecek.

            string Meyve = Console.ReadLine().ToLower(); // Büyük harf ile kullanıcı girişi olmasına karşın ToLower kullanıldı.

            if (string.IsNullOrEmpty(Meyve)) //Konsolda veri girilmeden enter'a basıldığında bilgi vermesi için 
            {
                Console.Write("Boş değer girdiniz.\n ");
                return;
            }

            else if (!string.IsNullOrEmpty(Meyve)) 
            {

                switch (Meyve)
                {
                    case "elma":
                        Console.WriteLine("Elma fiyatı 2 TL");
                        break;
                    case "armut":
                        Console.WriteLine("Armut fiyatı 3 TL");
                        break;
                    case "çilek":
                        Console.WriteLine("Çilek fiyatı 2 TL");
                        break;
                    case "muz":
                        Console.WriteLine("Muz fiyatı 3 TL");
                        break;
                    case "diğer":
                        Console.WriteLine("Seçtiğiniz meyvenin fiyatı 4 TL");
                        break;
                    default:
                        Console.WriteLine("Seçtiğiniz meyve listede yoksa diğer olarak belirtiniz.");
                        break;



                }
            }




        }





    }
}
  










