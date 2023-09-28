using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4_3
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string[] Colors { get; set; }
        public int Brand { get; set; }
        public Product(int iD, string name, double price, string[] colors, int brand)
        {
            ID = iD;
            Name = name;
            Price = price;
            Colors = colors;
            Brand = brand;
        }
         override public string ToString()=>$"{ID,3} {Name,12} {Price,5} {Brand,2} {string.Join(",", Colors)}";
    }
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
