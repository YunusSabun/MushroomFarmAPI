﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MushroomFarmAPI.Data;

#nullable disable

namespace MushroomFarmAPI.Migrations
{
    [DbContext(typeof(MushroomFarmContext))]
    [Migration("20240613221119_UpdateCascadeConstraints")]
    partial class UpdateCascadeConstraints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MushroomFarmAPI.Models.ClimateSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<float>("TargetCO2")
                        .HasColumnType("real");

                    b.Property<float>("TargetHumidity")
                        .HasColumnType("real");

                    b.Property<float>("TargetOxygen")
                        .HasColumnType("real");

                    b.Property<float>("TargetTemperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("ClimateSettings");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.CompostOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TotalWeight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("CompostOrders");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyEnvironment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CO2")
                        .HasColumnType("real");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<float>("Oxygen")
                        .HasColumnType("real");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("DailyEnvironments");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyLabor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TaskMasterDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TaskMasterDataId");

                    b.ToTable("DailyLabors");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<float>("PesticideAmount")
                        .HasColumnType("real");

                    b.Property<string>("PesticideName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int>("TaskMasterDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("TaskMasterDataId");

                    b.ToTable("DailyTasks");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeTypeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.EmployeeTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeTasks");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.EmployeeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeTypes");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Farm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Farms");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Harvest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HarvestDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HarvestPeriod")
                        .HasColumnType("int");

                    b.Property<string>("Quality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Harvests");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.MushroomInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Quality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MushroomInventories");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.PesticideOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PesticideOrders");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTaken")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProductionId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductionId");

                    b.HasIndex("RoomId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Production", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("RoomId");

                    b.ToTable("Productions");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.ProductionStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<int>("ProductionId")
                        .HasColumnType("int");

                    b.Property<int>("RecipeStepId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductionId");

                    b.HasIndex("RecipeStepId");

                    b.ToTable("ProductionSteps");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.RecipeStep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<int>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("StepName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeSteps");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FarmId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FarmId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.SaleDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<string>("MushroomType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SaleId");

                    b.ToTable("SaleDetails");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.SoilOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Supplier")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SoilOrders");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.TaskMasterData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TaskMasterData");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.UserMenu", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("UserMenus");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.ClimateSetting", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyEnvironment", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyLabor", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Employee", "Employee")
                        .WithMany("DailyLabors")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.TaskMasterData", "TaskMasterData")
                        .WithMany()
                        .HasForeignKey("TaskMasterDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("TaskMasterData");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.DailyTask", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.TaskMasterData", "TaskMasterData")
                        .WithMany()
                        .HasForeignKey("TaskMasterDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("TaskMasterData");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Employee", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.EmployeeType", "EmployeeType")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeType");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.EmployeeTask", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Employee", "Employee")
                        .WithMany("EmployeeTasks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Harvest", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Photo", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Production", "Production")
                        .WithMany()
                        .HasForeignKey("ProductionId");

                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.Navigation("Production");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Production", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.Room", "Room")
                        .WithMany("Productions")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.ProductionStep", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Production", "Production")
                        .WithMany("ProductionSteps")
                        .HasForeignKey("ProductionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.RecipeStep", "RecipeStep")
                        .WithMany("ProductionSteps")
                        .HasForeignKey("RecipeStepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Production");

                    b.Navigation("RecipeStep");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.RecipeStep", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Recipe", "Recipe")
                        .WithMany("RecipeSteps")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Room", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Farm", "Farm")
                        .WithMany("Rooms")
                        .HasForeignKey("FarmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farm");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.SaleDetail", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Sale", "Sale")
                        .WithMany("SaleDetails")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.UserMenu", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Menu", "Menu")
                        .WithMany("UserMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.UserRole", b =>
                {
                    b.HasOne("MushroomFarmAPI.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MushroomFarmAPI.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Employee", b =>
                {
                    b.Navigation("DailyLabors");

                    b.Navigation("EmployeeTasks");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Farm", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Menu", b =>
                {
                    b.Navigation("UserMenus");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Production", b =>
                {
                    b.Navigation("ProductionSteps");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Recipe", b =>
                {
                    b.Navigation("RecipeSteps");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.RecipeStep", b =>
                {
                    b.Navigation("ProductionSteps");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Room", b =>
                {
                    b.Navigation("Productions");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.Sale", b =>
                {
                    b.Navigation("SaleDetails");
                });

            modelBuilder.Entity("MushroomFarmAPI.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
