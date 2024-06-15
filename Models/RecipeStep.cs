namespace MushroomFarmAPI.Models
{
    public class RecipeStep
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
        public string? StepName { get; set; }
        public int Day { get; set; }
        public ICollection<ProductionStep>? ProductionSteps { get; set; } // Bu satır eklendi
    }
}
