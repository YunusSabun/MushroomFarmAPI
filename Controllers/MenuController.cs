using Microsoft.AspNetCore.Mvc;
using MushroomFarmAPI.Models;
using MushroomFarmAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        // GET: api/Menu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
        {
            return Ok(await _menuService.GetAllMenus());
        }

        // GET: api/Menu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            var menu = await _menuService.GetMenuById(id);

            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }

        // PUT: api/Menu/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenu(int id, Menu menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }

            await _menuService.UpdateMenu(menu);

            return NoContent();
        }

        // POST: api/Menu
        [HttpPost]
        public async Task<ActionResult<Menu>> PostMenu(Menu menu)
        {
            await _menuService.AddMenu(menu);

            return CreatedAtAction("GetMenu", new { id = menu.Id }, menu);
        }

        // DELETE: api/Menu/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            await _menuService.DeleteMenu(id);

            return NoContent();
        }
    }
}
