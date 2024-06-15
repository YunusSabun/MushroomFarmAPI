namespace MushroomFarmAPI.Models
{
    public class Production
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
        public DateTime StartDate { get; set; }
        public ICollection<ProductionStep>? ProductionSteps { get; set; }
    }
}
