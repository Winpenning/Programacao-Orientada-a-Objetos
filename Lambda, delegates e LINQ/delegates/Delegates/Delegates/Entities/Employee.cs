using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double FirstSalary { get; set; }
        public double LastSalary { get; set; }

        public Employee(int id, string? name, double firstSalary, double lastSalary)
        {
            Id = id;
            Name = name;
            FirstSalary = firstSalary;
            LastSalary = lastSalary;
        }
        public double GetDiference() => FirstSalary - LastSalary;
        public double MaxSalary() => FirstSalary >= LastSalary ? FirstSalary : LastSalary;



    }
}
