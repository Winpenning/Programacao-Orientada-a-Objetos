using Delegates.Entities;
using Delegates.Services;
using System;
using System.Linq;
using System.Net;
using System.Runtime.Intrinsics.X86;

namespace Delegates
{
    public delegate void BinaryNumericOperation(double n1, double n2);
    public delegate double DelegateOperation(/*double firstSalary, double lastSalary*/);
    public class Program
    {
        public static void Main(string[] args)
        {
            Func();
            //  Action();
            //ExamplePredicates(new Employee(1,"Paulo",500,700));
            //  MulticastDelegates();
            //   Predicates();
        }
        public static void MulticastDelegates()
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
        public static void Predicates()
        {
            /*Fazer um programa que, a partir de uma lista de produtos, remova da
            lista somente aqueles cujo preço mínimo seja 100.*/
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
    
            // UTILIZANDO lambda
            //list.RemoveAll(p => p.price >= 100.00);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n");

            list.RemoveAll(Predicates2);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static bool Predicates2(Product p)
        {
            return p.price >= 100;
        }

        public static void ExampleDelegates(Employee e)
        {
            DelegateOperation op = e.MaxSalary;
            
            Console.WriteLine(op.Invoke());
            op.Invoke();
        }

        public static void Action()
        {
            /* Fazer um programa que, a partir de uma lista de produtos, 
             * aumente o preço dos produtos em 10 %. */
            List<Product> list = new List<Product>();
            list.Add(new Product("TV", 900));
            list.Add(new Product("Bicicleta", 500));
            list.Add(new Product("Frigideira", 90));
            list.Add(new Product("Xbox Series X", 6000));

            // podemos fazer assim
            Action<Product> aumento = p => { p.price += p.price * 0.1; };
            // coloca-se chaves na lambda quando damos um comando. Sem retorno.
            list.ForEach(aumento);

            foreach(Product p in list) 
            {
                Console.WriteLine(p);
            }
            
            // ou assim
            list.ForEach(p => p.price += p.price * 0.1);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            //ou usando um delegate para uma função externa
            Action<Product> aumento2 = Action2;
            list.ForEach(aumento2);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        public static void Action2(Product p)
        {
            p.price += p.price * 0.1;
        }
        public static void Func()
        {
            /*Fazer um programa que, a partir de uma lista de produtos, 
            gere uma nova lista contendo os nomes dos produtos em caixa alta.*/
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
    
            // podemos fazer assim
            List<string> list2 =  list.Select<Product, string>(Func2).ToList();

            foreach(string p in list2)
            {
                Console.WriteLine(p);
            }

            // ou assim
            Func<Product, string> func = Func2;
            List<string> list3 = list.Select<Product, string>(func).ToList();
            foreach (string p in list3)
            {
                Console.WriteLine(p);
            }

            // ou assim
            Func<Product, string> func2 = p => p.name.ToUpper();
            List<string> list4 = list.Select(func2).ToList();
            foreach (string p in list4)
            {
                Console.WriteLine(p);
            }

            // ou ainda podemos fazer inline
            List<string> list5 = list.Select(p => p.name.ToUpper()).ToList();
            foreach (string p in list5)
            {
                Console.WriteLine(p);
            }
        }
        public static string Func2(Product p)
        {
            return p.name.ToUpper();
        }
        
    }
}