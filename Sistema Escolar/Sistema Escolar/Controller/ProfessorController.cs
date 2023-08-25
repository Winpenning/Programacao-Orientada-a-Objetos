using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Sistema_Escolar.Controller
{
    public class ProfessorController
    {
        private MySqlConnection _Connection;
        public ProfessorController() 
        {
            this._Connection = new DatabaseConnection().GetConnection();
        }

        public void InsertProfessor()
        {
            _Connection.Open();
            
            var a = new MySqlCommand("",_Connection);  
        }

    }
}
