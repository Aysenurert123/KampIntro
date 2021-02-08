using GameProject.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities.Concrete.Order
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int GamerId { get; set; }
        public int OrderName { get; set; }
    }
}
