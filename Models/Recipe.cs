namespace MushroomFarmAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<RecipeStep>? RecipeSteps { get; set; }
    }
}
