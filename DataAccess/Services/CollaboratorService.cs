using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;
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
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "SELECT * FROM collaborator";
                return await connection.QueryAsync<Collaborator>(query);
            }
        }
    }
}
