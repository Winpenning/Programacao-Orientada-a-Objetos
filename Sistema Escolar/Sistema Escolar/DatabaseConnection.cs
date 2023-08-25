using MySql.Data.MySqlClient;
namespace Sistema_Escolar
{
    internal class DatabaseConnection
    {
        public MySqlConnection GetConnection()
        {
            
            string conexao = "server=localhost; " +
                "user=root; password=31415; " +
                "database=sistema_vendas;";
            return new MySqlConnection(conexao);

            

            
        }
    }
}
