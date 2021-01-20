using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            // sayı1 in değeri eşittir sayi2 nin değeri
            //sayi1 ?? 30 

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]?? 999
            //sayilar1 in değeri eşittir sayilar2 nin değeri
            //sayilar2 nin 0. indeksi 999
            //sayilar1 in de 0. indeksi 999 olur

        }
    }
}
