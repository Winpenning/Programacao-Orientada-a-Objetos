using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResticoesParaGenerics.Entities
{
    public class Product : IComparable
    {
        private string Name { get; }
        private double Value { get; }
        public Product(string name, double value)
        {
            this.Name = name;
            this.Value = value;
        }
        public string GetName()
        {
            return Name;
        }
        public double GetValue()
        {
            return Value;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("EXCEPTION! argument is not a Product!");
            }
            Product other = obj as Product;
            return Value.CompareTo(other.Value);
        }
        public override string ToString()
        {
            return Name + ", " + Value;
        }
    }
}
