using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ayşenur";
            musteri1.Soyad = "Ertürk";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Resul";
            musteri2.Soyad = "Ertürk";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Elif";
            musteri3.Soyad = "Ertürk";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.List(musteri2);
            musteriManager.Delete(musteri3);
        }
    }
}
