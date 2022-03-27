using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class08.ExtraExercise
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, int price, Category category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public Product()
        {
        }
    }
}
