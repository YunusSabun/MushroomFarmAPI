namespace MushroomFarmAPI.Models
{
    public class ClimateSetting
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public DateTime Date { get; set; }
        public float TargetTemperature { get; set; }
        public float TargetHumidity { get; set; }
        public float TargetCO2 { get; set; }
        public float TargetOxygen { get; set; }
        public string? Mode { get; set; }
    }
}
