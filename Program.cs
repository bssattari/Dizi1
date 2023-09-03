using System;

namespace Dizi1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] sayilar=new int[10]{25,42,89,6,3,6,9,78,15,34};
            int[] sayilar = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(1,100);
                Console
                    .WriteLine("{0}. Indexteki Sayı = {1}",
                    i,
                    sayilar[i].ToString());
            }
        }
    }
}
