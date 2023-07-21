using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public Product(int Id, string Name, double Price, Category Category) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Category = Category;
        }
        public Product() { }
        public override string ToString()
        {
            return Id + ", " + Name + ", " + Price + ", " + 
                   Category.Name + ", " + Category.Tier;
        }
    }
}
