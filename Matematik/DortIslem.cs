using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    public class DortIslem
    {
        public double Topla(double sayi1, double sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
            return sayi1 + sayi2;
        }
        public double Cikar(double sayi1, double sayi2)
        {
            Console.WriteLine(sayi1 - sayi2);
            return sayi1 - sayi2;
        }
        public double Bolme(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 / sayi2);
            return sayi1 / sayi2;
        }
        public double Carp(double sayi1, double sayi2)
        {
            Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
            return sayi1 * sayi2;
        }
    }
}
