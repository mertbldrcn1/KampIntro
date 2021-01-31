using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategorietiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizoranı = 1.45;
            bool sitemegirisyapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");

            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sitemegirisyapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategorietiketi);

            
        }
    }
}
