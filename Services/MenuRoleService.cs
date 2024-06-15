using MushroomFarmAPI.Models;
using MushroomFarmAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public class MenuRoleService : IMenuRoleService
    {
        private readonly IMenuRoleRepository _menuRoleRepository;

        public MenuRoleService(IMenuRoleRepository menuRoleRepository)
        {
            _menuRoleRepository = menuRoleRepository;
        }

        public async Task<IEnumerable<MenuRole>> GetAllMenuRoles()
        {
            return await _menuRoleRepository.GetAll();
        }

        public async Task<MenuRole?> GetMenuRoleById(int menuId, int roleId)
        {
            return await _menuRoleRepository.GetByCompositeKey(menuId, roleId);
        }

        public async Task<MenuRole> AddMenuRole(MenuRole menuRole)
        {
            return await _menuRoleRepository.Add(menuRole);
        }

        public async Task<MenuRole> UpdateMenuRole(MenuRole menuRole)
        {
            return await _menuRoleRepository.Update(menuRole);
        }

        public async Task DeleteMenuRole(int menuId, int roleId)
        {
            await _menuRoleRepository.DeleteByCompositeKey(menuId, roleId);
        }
    }
}
