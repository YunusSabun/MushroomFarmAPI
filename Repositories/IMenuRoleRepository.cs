using MushroomFarmAPI.Models;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Repositories
{
    public interface IMenuRoleRepository : IRepository<MenuRole>
    {
        Task<MenuRole?> GetByCompositeKey(int menuId, int roleId);
        Task DeleteByCompositeKey(int menuId, int roleId);
    }
}
