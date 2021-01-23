using System;

namespace Hafta4Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(0, "Ayşenur");
            myDictionary.Add(1, "Kübra");
            myDictionary.Add(2, "Resul");
            myDictionary.Add(3, "Elif");
        }
    }
}
