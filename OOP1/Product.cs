using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet
    class Product  //Entity(varlık)
    {
        //bu tip classlarda sadece özellik olur.
        public int  Id { get; set; }
        public int CategoryId { get; set; }
        //Ürün ismi
        public string ProductName { get; set; }
        //Ürün Fiyatı
        public double unitPrice { get; set; }
        //Ürün  stok adedi
        public int UnitsInStock { get; set; }
        
      
    }
}
