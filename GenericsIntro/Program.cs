using System;

namespace GenericsIntro
{
    class Program
    { //liste.count --> listenin eleman sayısı
        static void Main(string[] args)
        {
            MyList <string >isimler = new MyList<string>();
            isimler.Add("Ayşenur");
        }
    }
}
