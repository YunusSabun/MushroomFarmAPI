using MushroomFarmAPI.Models;
using MushroomFarmAPI.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MushroomFarmAPI.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task<IEnumerable<Room>> GetAllRooms()
        {
            return await _roomRepository.GetAll();
        }

        public async Task<Room> GetRoomById(int id)
        {
            return await _roomRepository.GetById(id);
        }

        public async Task<Room> AddRoom(Room room)
        {
            return await _roomRepository.Add(room);
        }

        public async Task<Room> UpdateRoom(Room room)
        {
            return await _roomRepository.Update(room);
        }

        public async Task DeleteRoom(int id)
        {
            await _roomRepository.Delete(id);
        }
    }
}
