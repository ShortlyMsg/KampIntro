using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Topla(2,3)
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int toplam = sayi1 - sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Carp(int sayi1, int sayi2)
        {
            int toplam = sayi1 * sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
        public void Bol(int sayi1, int sayi2)
        {
            int toplam = sayi1 / sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
