using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class ProductManager
    {
        public static void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public static void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public static int Topla(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Topla2(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}
