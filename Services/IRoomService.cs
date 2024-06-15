using MushroomFarmAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetAllRooms();
        Task<Room> GetRoomById(int id);
        Task<Room> AddRoom(Room room);
        Task<Room> UpdateRoom(Room room);
        Task DeleteRoom(int id);
    }
}
