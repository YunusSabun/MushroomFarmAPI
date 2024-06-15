using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MushroomFarmAPI.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int FarmId { get; set; }
        public Farm? Farm { get; set; }
        public ICollection<Production>? Productions { get; set; }
    }
}
