namespace MushroomFarmAPI.Models
{
    public class MenuRole
    {
        public int MenuId { get; set; }
        public Menu? Menu { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
