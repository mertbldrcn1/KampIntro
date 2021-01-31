using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product urun1 = new Product();
            urun1.ProductName = "Elma";
            urun1.Price = 15;
            urun1.Explanation = "Amasya Elması";
            urun1.Stock = 6;

            Product urun2 = new Product();
            urun2.ProductName = "Karpuz";
            urun2.Price = 80;
            urun2.Explanation = "Diyarbakır karpuzu";
            urun2.Stock = 4;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product x in urunler)
            {
                Console.WriteLine(x.ProductName);
                Console.WriteLine(x.Price);
                Console.WriteLine(x.Explanation);
                Console.WriteLine("---------------");


            }

            Console.WriteLine("----------------------Metotlar--------------------------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Add(urun1);
            sepetmanager.Add(urun2);

            sepetmanager.Add2("Armut", "Yeşil Armut", 12, 6 );
            sepetmanager.Add2("Elma", "Yeşil Elma", 14, 8 );
            sepetmanager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 10 );
            // diyelimki stok adedi de eklenmek istendi, bu durumda Add2'ya yeni bir parametre eklemek
            //ve tüm sayfalarda tekrar güncelleme yapman gerekmeketedir. 
            //encapsulation
        }
    }
}


//Don't repeat yourself - Clean code - Best practice