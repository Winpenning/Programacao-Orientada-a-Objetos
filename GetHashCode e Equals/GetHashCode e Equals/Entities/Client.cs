using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetHashCode_e_Equals.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Int64 Cpf { get; set; }

        public Client(string Name, string Email, Int64 Cpf)
        {
            this.Name = Name;
            this.Email = Email;
            this.Cpf = Cpf;
        }

        // Em nossa regra de negócio, o parâmetro para comparação de objetos será o cpf
        public override bool Equals(object? obj)
        {
            if (!(obj is Client)) // programação defensiva
            {
                return false;
            }
            Client other = obj as Client; // downcasting
            return Cpf.Equals(other.Cpf);
        }
        public override int GetHashCode()
        {
            return Cpf.GetHashCode();
        }
    }
}
