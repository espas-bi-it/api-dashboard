using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using DataAccess.Models;

public class UserService
{
    private readonly string _connectionString;

    public UserService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<IEnumerable<User>> GetAllUsersAsync()
    {
        using (IDbConnection db = new MySqlConnection(_connectionString))
        {
            return await db.QueryAsync<User>("SELECT * FROM User");
        }
    }

    // Weitere Methoden für Insert, Update, Delete usw.
}
