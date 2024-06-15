using MushroomFarmAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public interface IClimateSettingService
    {
        Task<IEnumerable<ClimateSetting>> GetAllClimateSettings();
        Task<ClimateSetting> GetClimateSettingById(int id);
        Task<ClimateSetting> AddClimateSetting(ClimateSetting climateSetting);
        Task<ClimateSetting> UpdateClimateSetting(ClimateSetting climateSetting);
        Task DeleteClimateSetting(int id);
    }
}
