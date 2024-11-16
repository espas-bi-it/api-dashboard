using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int id);
        Task<TeamMembers?> GetUser(int id);
        Task<IEnumerable<TeamMembers>> GetUsers();
        Task InsertUser(TeamMembers user);
        Task UpdateUser(TeamMembers user);
    }
}