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
        static void Add()
        {
            Console.WriteLine("Added");
        }
        static int Add2(int number1, int number2 = 30) // Default parametreli method.
        {
            return number1 + number2;
        }
        static int Add3(ref int number1, int number2)
        {
            return number1 + number2;
            //Ref keyword'ü değer tipli olan bir sayıyı referans tip gibi algılatır ve bu değer tipli değişken referans tipli davranarak değerini değiştirebilir.
        }
        static int Add4(params int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }
    }
}


//Do not repeat yourself - DRY - Clean Code - Best Practice