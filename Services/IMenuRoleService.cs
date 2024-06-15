using MushroomFarmAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public interface IMenuRoleService
    {
        Task<IEnumerable<MenuRole>> GetAllMenuRoles();
        Task<MenuRole?> GetMenuRoleById(int menuId, int roleId);
        Task<MenuRole> AddMenuRole(MenuRole menuRole);
        Task<MenuRole> UpdateMenuRole(MenuRole menuRole);
        Task DeleteMenuRole(int menuId, int roleId);
    }
}
