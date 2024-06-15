using MushroomFarmAPI.Models;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByUsername(string username);
    }
}
