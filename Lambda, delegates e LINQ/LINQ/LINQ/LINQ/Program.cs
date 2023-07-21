using LINQ.Entities;
using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Print<T>(string message, IEnumerable<T> items)
        {
            Console.WriteLine(message);
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            // Usando uma função externa
            var Example1 =
                products.Where(Tier1);
            Print("Produtos de Tier 1 com preços menores que 900:", Example1);

            // Nomes de produtos que são ferramentas
            var Example2 =
                products.Where(p => p.Category == c1)
                .Select(p => p.Name);
            Print("Nomes de produtos que são ferramentas:", Example2);

            // Nomes que começam com 'C' e objeto anônimo
            var Example3 =
                products.Where(p => p.Name.ToUpper()[0] == 'C')
                .Select(p => new { p.Name, p.Price, NomeDaCategoria = p.Category.Name });
            Print("Nomes que começam com 'C' e objeto anônimo: ", Example3);

            // Tier 1 e ordenação decrescente por preço e depois por nome
            IEnumerable<Product> Example4 =
                products.Where(p => p.Category.Tier == 1)
                .OrderByDescending(p => p.Price)
                .ThenBy(p => p.Name);
            Print("Tier 1 e ordenação decrescente por preço e depois por nome", Example4);

            // Tier 1 e ordenar por preço e depois por nome, pular 2, pegar 4
            var Example5 =
                products.Where(p => p.Category.Tier == 1)
                .OrderBy(p => p.Price)
                .ThenBy(a => a.Name)
                .Skip(2)
                .Take(4);
            Print("Tier 1 e ordenar por preço e depois por  nome, pular 2, pegar 4", Example5);

            // Primeiro ou padrão
            var Example6 =
                products.FirstOrDefault();
            Console.WriteLine("FirstOrDefault " + Example6);

            var Example7 =
                products.Where(p => p.Price > 4000)
                .FirstOrDefault();
            Console.WriteLine("FirstOrDefault2 " + Example7);


            // Um ou padrão
            var Example8 =
                products.Where(p => p.Id == 3)
                .SingleOrDefault();
            Console.WriteLine("Single or default test: ", Example8);

            var Example9 =
                products.Where(p => p.Id == 30)
                .SingleOrDefault();
            Console.WriteLine("Single or default test2: " + Example9);
            Console.WriteLine();

            // Retornando o máximo
            var Example10 =
                products.Max(p => p.Price);
            Console.WriteLine("Max price: " + Example10);

            // Retornando o mínimo
            var Example11 =
                products.Max(p => p.Name);
            Console.WriteLine("Min name: " + Example11);

            // SE DEIXARMOS O Max ou Min SEM FUNÇÕES PARA DEFINIR O QUE SERÁ O MÁXIMO
            // OU MINIMO, O LINQ IRÁ BUSCAR UMA IMPLEMENTAÇÃO DO IComparable NA LISTA,
            // SE NÃO ACHAR RETORNARÁ UMA EXCEÇÃO

            // Soma de uma fonte de dados
            var Example12 =
                products.Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Sum();
            Console.WriteLine("Category 1 sum: " + Example12);

            // média
            var Example13 =
                products.Where(p => p.Category.Id == 2)
                .Average(p => p.Price);
            Console.WriteLine("Category 2 average: " + Example13);
            // média
            var Example14 =
                products.Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .DefaultIfEmpty(0.0)
                .Average();
            Console.WriteLine("Category 1 average: " + Example14);

            //soma por agregação
            var Example15 =
                products.Where(p => p.Category.Id == 1)
                .Select(p => p.Price)
                .Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category aggregate sum: " + Example15);

            Console.WriteLine();
            // Agrupando 
            var Example16 =
                products.GroupBy(p => p.Category);

            foreach(IGrouping<Category, Product> group in Example16)
            {
                Console.WriteLine("Category: " + group.Key.Name);
                foreach(Product product in group)
                {
                    Console.WriteLine(product);
                }
                Console.WriteLine();
            }

        }
        static bool Tier1(Product p)
        {
            return p.Category.Tier == 1 && p.Price < 900;
        }

        static void LinqIntroduction()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            IEnumerable<int> enumerable =
                list.Where(x => x % 2 == 0).Select(x => x * 10); ;

            foreach (int x in enumerable)
            {
                Console.WriteLine(x);
            }
        }
    }
}