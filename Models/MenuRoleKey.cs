namespace MushroomFarmAPI.Models
{
    public class MenuRoleKey
    {
        public int MenuId { get; set; }
        public int RoleId { get; set; }

        public MenuRoleKey(int menuId, int roleId)
        {
            MenuId = menuId;
            RoleId = roleId;
        }
    }
}
