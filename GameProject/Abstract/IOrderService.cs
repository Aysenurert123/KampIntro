using GameProject.Entities.Concrete.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract.IOrderService
{
    public interface IOrderService
    {
        void Sale(Product product);
    }
}
