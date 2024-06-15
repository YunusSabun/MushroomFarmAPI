namespace MushroomFarmAPI.Models
{
    public class SaleDetail
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public Sale? Sale { get; set; }
        public string? MushroomType { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
    }
}
