namespace MushroomFarmAPI.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string? Customer { get; set; }
        public DateTime SaleDate { get; set; }
        public ICollection<SaleDetail>? SaleDetails { get; set; }
    }
}
