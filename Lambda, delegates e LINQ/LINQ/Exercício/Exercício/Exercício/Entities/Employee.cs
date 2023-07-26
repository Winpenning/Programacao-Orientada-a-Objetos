using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício.Entities
{
    internal class Employee
    {
        private string Name { get; set; }
        public string Email { get; set; }
        private double Salary { get; set; }
        public Employee(string Name, string Email, double Salary) {
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
        }

        public double getSalary()
        {
            return Salary;
        }
        public string getName()
        {
            return Name;
        }
        public string getEmail()
        {
            return Email;
        }
    }
}
