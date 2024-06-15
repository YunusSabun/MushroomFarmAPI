namespace MushroomFarmAPI.Models
{
    public class DailyTask
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public int TaskMasterDataId { get; set; }
        public TaskMasterData? TaskMasterData { get; set; }
        public DateTime Date { get; set; }
        public string? PesticideName { get; set; }
        public float PesticideAmount { get; set; }
        public bool IsCompleted { get; set; }
    }
}
