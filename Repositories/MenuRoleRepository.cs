using MushroomFarmAPI.Data;
using MushroomFarmAPI.Models;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Repositories
{
    public class MenuRoleRepository : Repository<MenuRole>, IMenuRoleRepository
    {
        public MenuRoleRepository(MushroomFarmContext context) : base(context)
        {
        }

        public async Task<MenuRole?> GetByCompositeKey(int menuId, int roleId)
        {
            return await _context.Set<MenuRole>().FindAsync(new MenuRoleKey(menuId, roleId));
        }

        public async Task DeleteByCompositeKey(int menuId, int roleId)
        {
            var entity = await GetByCompositeKey(menuId, roleId);
            if (entity != null)
            {
                _context.Set<MenuRole>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
