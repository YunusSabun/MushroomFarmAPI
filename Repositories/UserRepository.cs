using Microsoft.EntityFrameworkCore;
using MushroomFarmAPI.Data;
using MushroomFarmAPI.Models;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(MushroomFarmContext context) : base(context)
        {
        }

        public async Task<User?> GetByUsername(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.UserName == username);
        }
    }
}
