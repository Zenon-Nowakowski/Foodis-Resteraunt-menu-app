using Foodis_restaurant_menu_app.Models;
using Microsoft.EntityFrameworkCore;
using Foodis_restaurant_menu_app.Models;

namespace Foodis_restaurant_menu_app.Data;
    public class Menu_Context : DbContext
    {
        public Menu_Context(DbContextOptions<Menu_Context> options) : base(options)
        {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dish_Ingredient>().HasKey(di => new 
        {
            di.Dish_Id,
            di.Ingredient_Id
        });
        modelBuilder.Entity<Dish_Ingredient>().HasOne(d => d.Dish).WithMany(di => di.Dish_Ingredients).HasForeignKey(d => d.Dish_Id);
        modelBuilder.Entity<Dish_Ingredient>().HasOne(i => i.Ingredient).WithMany(di => di.Dish_Ingredients).HasForeignKey(i => i.Dish_Id);

        modelBuilder.Entity<Dish>().HasData(
            new Dish {Id = 1, Name="Pizza", Price=9.99}
        );
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient {Id = 1, Name = "Tomato Sauce"},
            new Ingredient {Id = 2, Name = "Mozzarella"}
        );
        modelBuilder.Entity<Dish_Ingredient>().HasData(
            new Dish_Ingredient {Dish_Id = 1, Ingredient_Id = 1},
            new Dish_Ingredient {Dish_Id = 1, Ingredient_Id = 2}
        );
    }
    public DbSet<Dish> Dishes {get;set;}
    public DbSet<Ingredient> Ingredients {get;set;}
    public DbSet<Dish_Ingredient> Dish_Ingredients {get;set;}
}