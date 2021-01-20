using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi: " +musteri.Ad);
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi: " + musteri.Ad);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi: " + musteri.Ad);
        }
    }
}