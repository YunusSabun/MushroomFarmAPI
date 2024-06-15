using MushroomFarmAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<Menu>> GetAllMenus();
        Task<Menu?> GetMenuById(int id);
        Task<Menu> AddMenu(Menu menu);
        Task<Menu> UpdateMenu(Menu menu);
        Task DeleteMenu(int id);
    }
}
