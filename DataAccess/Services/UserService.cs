using System.Data.SqlClient;
using Dapper;
using DataAccess.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public class UserService
    {
        private readonly IConfiguration _configuration;

        public UserService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            var connectionString = _configuration.GetConnectionString("Default");
            using (var connection = new SqlConnection(connectionString))
            {
                var query = "SELECT Id, FirstName, LastName FROM [dbo].[user]";
                return await connection.QueryAsync<UserModel>(query);
            }
        }
    }
}
