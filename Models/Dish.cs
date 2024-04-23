
namespace Foodis_restaurant_menu_app.Models;

    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }

        public List<Dish_Ingredient>? Dish_Ingredients { get; set; }
    }