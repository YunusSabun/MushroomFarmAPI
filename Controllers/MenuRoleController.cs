using Microsoft.AspNetCore.Mvc;
using MushroomFarmAPI.Models;
using MushroomFarmAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuRoleController : ControllerBase
    {
        private readonly IMenuRoleService _menuRoleService;

        public MenuRoleController(IMenuRoleService menuRoleService)
        {
            _menuRoleService = menuRoleService;
        }

        // GET: api/MenuRole
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuRole>>> GetMenuRoles()
        {
            return Ok(await _menuRoleService.GetAllMenuRoles());
        }

        // GET: api/MenuRole/5/2
        [HttpGet("{menuId}/{roleId}")]
        public async Task<ActionResult<MenuRole>> GetMenuRole(int menuId, int roleId)
        {
            var menuRole = await _menuRoleService.GetMenuRoleById(menuId, roleId);

            if (menuRole == null)
            {
                return NotFound();
            }

            return Ok(menuRole);
        }

        // PUT: api/MenuRole/5/2
        [HttpPut("{menuId}/{roleId}")]
        public async Task<IActionResult> PutMenuRole(int menuId, int roleId, MenuRole menuRole)
        {
            if (menuId != menuRole.MenuId || roleId != menuRole.RoleId)
            {
                return BadRequest();
            }

            await _menuRoleService.UpdateMenuRole(menuRole);

            return NoContent();
        }

        // POST: api/MenuRole
        [HttpPost]
        public async Task<ActionResult<MenuRole>> PostMenuRole(MenuRole menuRole)
        {
            await _menuRoleService.AddMenuRole(menuRole);

            return CreatedAtAction("GetMenuRole", new { menuId = menuRole.MenuId, roleId = menuRole.RoleId }, menuRole);
        }

        // DELETE: api/MenuRole/5/2
        [HttpDelete("{menuId}/{roleId}")]
        public async Task<IActionResult> DeleteMenuRole(int menuId, int roleId)
        {
            await _menuRoleService.DeleteMenuRole(menuId, roleId);

            return NoContent();
        }
    }
}
