namespace MushroomFarmAPI.Models
{
    public class EmployeeTask
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public string? TaskName { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
