using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }
        public Category(int Id,  string Name, int Tier)
        {
            this.Id = Id;
            this.Name = Name;
            this.Tier = Tier;
        }
        public Category() { }

        public override string ToString()
        {
            return Id + " " + Name + " " + Tier;
        }
    }
}
