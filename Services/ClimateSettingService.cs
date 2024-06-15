using MushroomFarmAPI.Models;
using MushroomFarmAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public class ClimateSettingService : IClimateSettingService
    {
        private readonly IClimateSettingRepository _climateSettingRepository;

        public ClimateSettingService(IClimateSettingRepository climateSettingRepository)
        {
            _climateSettingRepository = climateSettingRepository;
        }

        public async Task<IEnumerable<ClimateSetting>> GetAllClimateSettings()
        {
            return await _climateSettingRepository.GetAll();
        }

        public async Task<ClimateSetting> GetClimateSettingById(int id)
        {
            return await _climateSettingRepository.GetById(id);
        }

        public async Task<ClimateSetting> AddClimateSetting(ClimateSetting climateSetting)
        {
            return await _climateSettingRepository.Add(climateSetting);
        }

        public async Task<ClimateSetting> UpdateClimateSetting(ClimateSetting climateSetting)
        {
            return await _climateSettingRepository.Update(climateSetting);
        }

        public async Task DeleteClimateSetting(int id)
        {
            await _climateSettingRepository.Delete(id);
        }
    }
}
