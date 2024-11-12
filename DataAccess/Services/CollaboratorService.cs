using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using DataAccess.Models;

namespace DataAccess.Services
{
    public class CollaboratorService
    {
        private readonly string _connectionString;

        public CollaboratorService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<Collaborator>> GetCollaboratorsAsync()
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                var query = "SELECT * FROM collaborator";
                return await connection.QueryAsync<Collaborator>(query);
            }
        }

        // Weitere Methoden für Insert, Update, Delete usw.
    }
}
