using System;
using System.Collections.Generic;
using System.Text;

namespace Metods
{
    class SepetManager
    {
        public void Add(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.ProductName);
            
        }

        public void Add2(string urunAdi, string Aciklama, double Fiyat, int StockAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi + " : " + StockAdedi);

        }
    }
}
