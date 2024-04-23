namespace Foodis_restaurant_menu_app.Models;

public class Ingredient
{
    public int Id {get; set;}
    public required string Name {get;set;}
    public List<Dish_Ingredient>? Dish_Ingredients {get; set;}
}
