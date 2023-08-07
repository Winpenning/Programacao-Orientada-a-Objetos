using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_e_SortedSet.Entities
{
    public class People
    {
        public Int64 Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public People(Int64 cpf, string nome, string email)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + 
                   "\nCpf: " + Cpf +
                   "\nE-mail: " + Email;
        }
    }
}
