using Microsoft.EntityFrameworkCore;
using MushroomFarmAPI.Models;

namespace MushroomFarmAPI.Data
{
    public class MushroomFarmContext : DbContext
    {
        public MushroomFarmContext(DbContextOptions<MushroomFarmContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<UserMenu> UserMenus { get; set; }
        public DbSet<Farm> Farms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeStep> RecipeSteps { get; set; }
        public DbSet<Production> Productions { get; set; }
        public DbSet<ProductionStep> ProductionSteps { get; set; }
        public DbSet<DailyTask> DailyTasks { get; set; }
        public DbSet<TaskMasterData> TaskMasterData { get; set; }
        public DbSet<DailyEnvironment> DailyEnvironments { get; set; }
        public DbSet<CompostOrder> CompostOrders { get; set; }
        public DbSet<SoilOrder> SoilOrders { get; set; }
        public DbSet<PesticideOrder> PesticideOrders { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Harvest> Harvests { get; set; }
        public DbSet<MushroomInventory> MushroomInventories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
        public DbSet<DailyLabor> DailyLabors { get; set; }
        public DbSet<ClimateSetting> ClimateSettings { get; set; }
        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                .HasKey(ur => new { ur.UserId, ur.RoleId });

            modelBuilder.Entity<UserMenu>()
                .HasKey(um => new { um.UserId, um.MenuId });

            modelBuilder.Entity<CompostOrder>()
                .Property(co => co.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SoilOrder>()
                .Property(so => so.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<PesticideOrder>()
                .Property(po => po.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SaleDetail>()
                .Property(sd => sd.UnitPrice)
                .HasColumnType("decimal(18,2)");

            // Cascade delete constraint modifications
            modelBuilder.Entity<ProductionStep>()
                .HasOne(ps => ps.Production)
                .WithMany(p => p.ProductionSteps)
                .HasForeignKey(ps => ps.ProductionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProductionStep>()
                .HasOne(ps => ps.RecipeStep)
                .WithMany(rs => rs.ProductionSteps)
                .HasForeignKey(ps => ps.RecipeStepId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
