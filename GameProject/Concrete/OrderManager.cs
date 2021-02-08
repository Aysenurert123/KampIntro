using GameProject.Abstract.IOrderService;
using GameProject.Entities.Concrete.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete.OrderManager
{
    public class OrderManager : IOrderService
    {
        public void Sale(Product product)
        {
            Console.WriteLine("Satış işlemi başarı ile tamamlandı");
            Console.WriteLine("Satın alınan ürün: " + product.ProductName);
        }
    }
}
