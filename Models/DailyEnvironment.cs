namespace MushroomFarmAPI.Models
{
    public class DailyEnvironment
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime Date { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Oxygen { get; set; }
        public float CO2 { get; set; }
    }
}
