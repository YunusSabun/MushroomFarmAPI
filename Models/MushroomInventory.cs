namespace MushroomFarmAPI.Models
{
    public class MushroomInventory
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public int Quantity { get; set; }
        public string? Quality { get; set; }
    }
}
