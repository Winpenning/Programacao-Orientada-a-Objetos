using Delegates.Entities;
using Delegates.Services;
using System;

namespace Delegates
{
    public delegate void BinaryNumericOperation(double n1, double n2);
    public delegate double DelegateOperation(/*double firstSalary, double lastSalary*/);
    public class Program
    {
        public static void Main(string[] args)
        {
            ExamplePredicates(new Employee(1,"Paulo",500,700));
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

        public static void ExamplePredicates(Employee e)
        {
            DelegateOperation op = e.MaxSalary;
            
            Console.WriteLine(op.Invoke());
            op.Invoke();
        }
    }
}