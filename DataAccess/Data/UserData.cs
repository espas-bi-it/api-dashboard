using DataAccess.DBAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;
    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<TeamMembers>> GetUsers() =>
        _db.LoadData<TeamMembers, dynamic>(storedProcedure: "dbo.spUser_GetAll", new { });

    public async Task<TeamMembers?> GetUser(int id)
    {
        var results = await _db.LoadData<TeamMembers, dynamic>(
            storedProcedure: "dbo.spUser_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertUser(TeamMembers user) =>
       _db.SaveData(storedProcedure: "dbo.spUser_Insert", new { user.FirstName, user.LastName });

    public Task UpdateUser(TeamMembers user) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Update", user);

    public Task DeleteUser(int id) =>
        _db.SaveData(storedProcedure: "dbo.spUser_Delete", new { Id = id });
}
 