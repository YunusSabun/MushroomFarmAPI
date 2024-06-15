using MushroomFarmAPI.Models;
using MushroomFarmAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<Menu>> GetAllMenus()
        {
            return await _menuRepository.GetAll();
        }

        public async Task<Menu?> GetMenuById(int id)
        {
            return await _menuRepository.GetById(id);
        }

        public async Task<Menu> AddMenu(Menu menu)
        {
            return await _menuRepository.Add(menu);
        }

        public async Task<Menu> UpdateMenu(Menu menu)
        {
            return await _menuRepository.Update(menu);
        }

        public async Task DeleteMenu(int id)
        {
            await _menuRepository.Delete(id);
        }
    }
}
