namespace MushroomFarmAPI.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<UserMenu>? UserMenus { get; set; }
    }
}
