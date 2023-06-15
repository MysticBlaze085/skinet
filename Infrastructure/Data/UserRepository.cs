
using Core.Entities;
using Infrastructure.Controllers.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class UserRepository
    {
        private readonly StoreContext _context;
        public UserRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}