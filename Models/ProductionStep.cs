namespace MushroomFarmAPI.Models
{
    public class ProductionStep
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production? Production { get; set; }
        public int RecipeStepId { get; set; }
        public RecipeStep? RecipeStep { get; set; }
        public DateTime ScheduledDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
