namespace MushroomFarmAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int EmployeeTypeId { get; set; }
        public EmployeeType? EmployeeType { get; set; }
        public decimal Salary { get; set; }
        public ICollection<EmployeeTask>? EmployeeTasks { get; set; }
        public ICollection<DailyLabor>? DailyLabors { get; set; }
    }
}
