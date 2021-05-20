using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array = new string[] { "1", "2" };
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            List<string> arrays = new List<string> { "Tayfun", "Ferdi", "Nurgül", "Şahin", "Türkan" };
            Console.WriteLine(arrays[0]);
            Console.WriteLine(arrays[1]);
            Console.WriteLine(arrays[2]);
            Console.WriteLine(arrays[3]);
            Console.WriteLine(arrays[4]);
            arrays.Add("Enes");
            Console.WriteLine(arrays[5]);
            Console.WriteLine(arrays[0]);
        }
    }
}
