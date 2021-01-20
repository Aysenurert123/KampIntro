using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2-mobilya
            product1.ProductName = "Masa";
            product1.unitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id=2,CategoryId=5, UnitsInStock=5,ProductName="Kalem", unitPrice=35 };
            //PascalCase  //camelCase
            //case sensitive
            //Product productManager;
            //Örnek oluşturduk
            //stack                           //heap
            ProductManager productManager = new ProductManager();
            // bununla aynı string isim="Ayşenur";
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            //productManager.Topla2(3, 6);
                                //return
            //int toplamaSonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamaSonucu*2);
            //int, double, bool... değer tipte atamalar tamamen değeri üzerinden olur
            //diziler, classlar, abstract class, interface... referans tip
            //ref-out
        
        }
    }
}
