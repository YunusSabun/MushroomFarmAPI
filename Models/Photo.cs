namespace MushroomFarmAPI.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string? Url { get; set; }
        public DateTime DateTaken { get; set; }
        public int? RoomId { get; set; }
        public Room? Room { get; set; }
        public int? ProductionId { get; set; }
        public Production? Production { get; set; }
    }
}
