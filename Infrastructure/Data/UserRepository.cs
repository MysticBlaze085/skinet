
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Controllers.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly StoreContext _context;
        public UserRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<List<RoleType>> GetRoleTypeAsync()
        {
            return await _context.RoleTypes.ToListAsync();
        }

        public Task<User> GetUserByIdAsync(int id)
        {
            return _context.Users
                .Include(p => p.RoleType)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}