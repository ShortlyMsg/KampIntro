using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
             //int, decimal, float, enum, boolean = value types/değer tipler
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 100;

            Console.WriteLine("Sayı 1 : " + sayi1);


            //arrays, class, interface... reference types/ referans tipler

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine("Sayılar1 [0] : "+ sayilar1[0]);
        }
    }
}
