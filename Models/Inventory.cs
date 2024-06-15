namespace MushroomFarmAPI.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public string? Unit { get; set; }
    }
}
