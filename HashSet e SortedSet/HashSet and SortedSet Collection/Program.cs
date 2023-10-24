using System;
using System.Linq;
namespace HashSet_and_SortedSet_Collection
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> products1 = new HashSet<Product>()
            {
                new Product("TV", 900.00),
                new Product("Xbox Series X", 5000),
                new Product("Produto1", 1),
                new Product("Produto0", 0)
            };
            HashSet<Product> products2 = new HashSet<Product>();
            for (int i = 0; i < 10; i++) 
            {
                products2.Add(new Product($"Produto{i}", i));
            }

            //products1.RemoveWhere(p => products1.Contains(products2.First()));
            //products1.IntersectWith(products2);
            foreach (Product p in products1)
            {
                Console.WriteLine(p.Name);
            }

        }
    }
}