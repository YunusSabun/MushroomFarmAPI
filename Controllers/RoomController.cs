using Microsoft.AspNetCore.Mvc;
using MushroomFarmAPI.Models;
using MushroomFarmAPI.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        // GET: api/Room
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            return Ok(await _roomService.GetAllRooms());
        }

        // GET: api/Room/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _roomService.GetRoomById(id);

            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        // PUT: api/Room/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.Id)
            {
                return BadRequest();
            }

            await _roomService.UpdateRoom(room);

            return NoContent();
        }

        // POST: api/Room
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            await _roomService.AddRoom(room);

            return CreatedAtAction("GetRoom", new { id = room.Id }, room);
        }

        // DELETE: api/Room/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoom(int id)
        {
            await _roomService.DeleteRoom(id);

            return NoContent();
        }
    }
}
