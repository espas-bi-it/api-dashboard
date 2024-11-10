using Dapper;
using DataAccess.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

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
            using (IDbConnection db = new SqlConnection(_connectionString))
            {
                string sqlQuery = "SELECT * FROM collaborator";
                return await db.QueryAsync<Collaborator>(sqlQuery);
            }
        }
    }
}
