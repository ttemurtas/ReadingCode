using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    public class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Product product)
        {
            Console.WriteLine("Ürün sepete eklendi : " + product.UrunAd);
        }
        public void Ekle()
        {
            Console.WriteLine("Ürün Sepete Eklendi.");
        }
    }
}
