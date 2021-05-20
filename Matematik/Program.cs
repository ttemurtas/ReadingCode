using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem islem = new DortIslem();

            islem.Topla(5,10);
            islem.Cikar(4, 50);
            islem.Carp(5, 10);
            islem.Bolme(10, 3);
        }
    }
}
