using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //// stack           //heap
            //string[] isimler = new string[] { "Ayşenur", "Resul", "Kübra", "Elif" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            ////new dediğimizde bellekte yeni adres oluşur
            //isimler = new string[5];
            //isimler[4] = "Sema";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Ayşenur", "Resul", "Kübra", "Elif" };
            //isimler2.Add("Ayşenur");
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);

            isimler2.Add("Sema");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }


    }
}
