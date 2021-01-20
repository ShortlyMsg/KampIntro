using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Said");

            MyList<string> liste = new MyList<string>();

            Console.WriteLine("Hello World!");
        }
    }
}
