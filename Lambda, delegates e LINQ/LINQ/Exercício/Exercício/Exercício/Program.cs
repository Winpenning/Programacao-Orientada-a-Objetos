using System.Collections.Generic;
using System.Globalization;
using Exercício.Entities;
using System.IO;
using System.Linq;
namespace Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter Salary: ");
            double value = double.Parse(Console.ReadLine());

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] field = sr.ReadLine().Split(',');
                    string name = field[0];
                    string email = field[1];
                    double salary = Convert.ToDouble(field[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }


            var emails =
                list.Where(p => p.getSalary() > value && p.getEmail != null)
                .OrderBy(p => p.Email)
                .Select(p => p.getEmail());

            Console.WriteLine("Email dos funcionários com salário superior a " + value);
            foreach (string nam in emails)
            {
                Console.WriteLine(nam);
            }

            double Msum = list.Where(p => p.getName()[0] == 'M')
                .Select(p => p.getSalary()).Sum();

            Console.WriteLine("Soma dos salários das pessoas que começam com a letra 'M' " + Msum);


        }
    }
}