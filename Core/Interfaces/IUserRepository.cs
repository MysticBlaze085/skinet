using Core.Entities;

namespace Core.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByIdAsync(int id);
        Task<List<User>> GetUsersAsync();
        Task<List<RoleType>> GetRoleTypeAsync();
    }
}