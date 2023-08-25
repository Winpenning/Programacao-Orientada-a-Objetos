using MySqlX.XDevAPI.Relational;
using Sistema_Escolar;
using System.Collections.Generic;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {
        SqlConnection sqlConnection = new SqlConnection("server = .\\sqlexpress; database = C:\\USERS\\ZSPHS\\SOURCE\\REPOS\\WINPENNING\\PROGRAMACAO-ORIENTADA-A-OBJETOS\\SISTEMA ESCOLAR\\SISTEMA ESCOLAR\\DATABASE\\SISTEMINHA.MDF");
        var a = 
            from a in sqlConnection.GetTable<>
    }   
}