namespace MushroomFarmAPI.Models
{
    public class Harvest
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public string? Type { get; set; }
        public int Quantity { get; set; }
        public string? Quality { get; set; }
        public DateTime HarvestDate { get; set; }
        public int HarvestPeriod { get; set; }
    }
}
