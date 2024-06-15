namespace MushroomFarmAPI.Models
{
    public class SoilOrder
    {
        public int Id { get; set; }
        public string? Supplier { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
