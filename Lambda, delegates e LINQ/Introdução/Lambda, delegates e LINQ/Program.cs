using Lambda__delegates_e_LINQ.Entities;
using System.Globalization;

namespace Lambda
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Fogão Industrial", 6000));
            products.Add(new Product("Xbox Series X", 3500));
            products.Add(new Product("Alicate", 99.99));

            
            products.Sort((p1, p2) => p1.getName().ToUpper().CompareTo(p2.getName().ToUpper()));
            
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
            
        } 
    }
}