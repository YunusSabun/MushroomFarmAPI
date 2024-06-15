using MushroomFarmAPI.Models;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public interface IAuthService
    {
        Task<string?> Authenticate(string username, string password);
        Task<User?> GetUserById(int id);
    }
}
