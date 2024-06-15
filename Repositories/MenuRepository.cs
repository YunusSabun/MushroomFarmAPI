using MushroomFarmAPI.Data;
using MushroomFarmAPI.Models;

namespace MushroomFarmAPI.Repositories
{
    public class MenuRepository : Repository<Menu>, IMenuRepository
    {
        public MenuRepository(MushroomFarmContext context) : base(context)
        {
        }

        // Menu'ye özgü ek metotlar burada uygulanabilir.
    }
}
