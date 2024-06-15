using MushroomFarmAPI.Data;
using MushroomFarmAPI.Models;

namespace MushroomFarmAPI.Repositories
{
    public class RoomRepository : Repository<Room>, IRoomRepository
    {
        public RoomRepository(MushroomFarmContext context) : base(context)
        {
        }

        // Room'a özgü ek metotlar burada uygulanabilir.
    }
}
