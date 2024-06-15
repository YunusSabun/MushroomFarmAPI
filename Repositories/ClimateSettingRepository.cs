using MushroomFarmAPI.Data;
using MushroomFarmAPI.Models;

namespace MushroomFarmAPI.Repositories
{
    public class ClimateSettingRepository : Repository<ClimateSetting>, IClimateSettingRepository
    {
        public ClimateSettingRepository(MushroomFarmContext context) : base(context)
        {
        }

        // ClimateSetting'e özgü ek metotlar burada uygulanabilir.
    }
}
