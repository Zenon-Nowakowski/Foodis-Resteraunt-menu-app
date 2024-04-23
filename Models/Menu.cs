namespace Foodis_restaurant_menu_app.Models;

public class Menu
{
    public int Id {get; set;}
    public required string Name {get;set;}
    public string? ImageUrl {get;set;}
    public double Price {get;set;}
}
