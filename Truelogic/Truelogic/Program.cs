// See https://aka.ms/new-console-template for more information
using Truelogic;

Console.WriteLine("Hello, World!");

var toppings = new[] { "Margherita", "San Remo", "Sublime", "Calabria", "Firenze", "Not a topping" };
var p = new PizzaMaker();

foreach (var topping in toppings)
{
    Console.WriteLine(new string('-', 16));
    Console.WriteLine($"Topping: {topping}");
    try
    {
        foreach (var ingredient in p.GetRequiredIngredients(topping))
        {
            Console.WriteLine($"- {ingredient}");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}