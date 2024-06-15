namespace MushroomFarmAPI.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Room>? Rooms { get; set; }
    }
}
