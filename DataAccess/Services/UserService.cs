using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using DataAccess.Models;

namespace Services // Stelle sicher, dass der Namespace korrekt ist
{
    public class UserService
    {
        private readonly IConfiguration _configuration;

        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IDbConnection CreateConnection()
        {
            return new MySqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            using (var connection = CreateConnection())
            {
                string sql = "SELECT * FROM user";
                return await connection.QueryAsync<User>(sql);
            }
        }
    }
}
