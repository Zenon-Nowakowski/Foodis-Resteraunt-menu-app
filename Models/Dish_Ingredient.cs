using Azure.Core.Pipeline;

namespace Foodis_restaurant_menu_app.Models;

public class Dish_Ingredient
{
    public int Dish_Id {get; set;}
    public int Ingredient_Id {get;set;}
    public Ingredient? Ingredient {get;set;}
    public Dish? Dish {get;set;}
}
