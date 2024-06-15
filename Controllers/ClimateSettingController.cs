using Microsoft.AspNetCore.Mvc;
using MushroomFarmAPI.Models;
using MushroomFarmAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimateSettingController : ControllerBase
    {
        private readonly IClimateSettingService _climateSettingService;

        public ClimateSettingController(IClimateSettingService climateSettingService)
        {
            _climateSettingService = climateSettingService;
        }

        // GET: api/ClimateSetting
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClimateSetting>>> GetClimateSettings()
        {
            return Ok(await _climateSettingService.GetAllClimateSettings());
        }

        // GET: api/ClimateSetting/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClimateSetting>> GetClimateSetting(int id)
        {
            var climateSetting = await _climateSettingService.GetClimateSettingById(id);

            if (climateSetting == null)
            {
                return NotFound();
            }

            return Ok(climateSetting);
        }

        // PUT: api/ClimateSetting/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClimateSetting(int id, ClimateSetting climateSetting)
        {
            if (id != climateSetting.Id)
            {
                return BadRequest();
            }

            await _climateSettingService.UpdateClimateSetting(climateSetting);

            return NoContent();
        }

        // POST: api/ClimateSetting
        [HttpPost]
        public async Task<ActionResult<ClimateSetting>> PostClimateSetting(ClimateSetting climateSetting)
        {
            await _climateSettingService.AddClimateSetting(climateSetting);

            return CreatedAtAction("GetClimateSetting", new { id = climateSetting.Id }, climateSetting);
        }

        // DELETE: api/ClimateSetting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClimateSetting(int id)
        {
            await _climateSettingService.DeleteClimateSetting(id);

            return NoContent();
        }
    }
}
