namespace MushroomFarmAPI.Models
{
    public class DailyLabor
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime Date { get; set; }
        public int TaskMasterDataId { get; set; }
        public TaskMasterData? TaskMasterData { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
