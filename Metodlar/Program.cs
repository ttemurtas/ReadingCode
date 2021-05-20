using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunId = 1;
            product1.UrunAd = "Elma";
            product1.UrunAciklama = "Amasya elması";
            product1.UrunFiyat = 6;

            Product product2 = new Product();
            product2.UrunAd = "Karpuz";
            product2.UrunFiyat = 80;
            product2.UrunAciklama = "Sera Karpuzu";
            product2.UrunId = 2;

            Product[] UrunList = new Product[] { product1, product2 };

            //type-safe -- tip güvenli
            foreach (Product prod in UrunList)
            {
                Console.WriteLine($"Ürün adı:{prod.UrunAd} \nÜrün Açıklaması: {prod.UrunAciklama} \nÜrün Fiyatı: {prod.UrunFiyat}");
                Console.Write("-----------------\n");
            }

            Console.WriteLine("---------------Metodlar----------------");
            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);
        }
    }
}


//Do not yourself - DRY - Clean Code - Best Practice