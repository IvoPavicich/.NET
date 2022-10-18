using Dapper;
using ProyectoFinal.Models;
using System.Data.SqlClient;
namespace ProyectoFinal.Rules
{
    public class PublicacionRule
    {
        public Publicacion GetOnePostRandom()
        {
            var connectionString = @"Server=.\SQLEXPRESS;DataBase=BlogDataBase; Trusted_Connection=True";
            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var posts = connection.Query<Publicacion>("SELECT TOP 1 *FROM Publicacion");
                return posts.First();
            }  
        }    
    }

}
