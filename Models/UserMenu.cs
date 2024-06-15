namespace MushroomFarmAPI.Models
{
    public class UserMenu
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
