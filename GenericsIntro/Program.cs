using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("tayfun");

            Console.WriteLine(isimler.Length);

            isimler.Add("Ferdi");

            Console.WriteLine(isimler.Length);

            foreach (var item in isimler.List)
            {
                Console.WriteLine(item);
            }
        }
    }
}
