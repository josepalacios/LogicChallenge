using Truelogic.Models;

namespace Truelogic
{
    internal class PizzaMaker
    {
        PizzaBuilder pizzaBuilder = new PizzaBuilder();

        public IEnumerable<string> GetRequiredIngredients(string topping)
        {
            switch (topping)
            {
                case "Margherita":
                     pizzaBuilder.setPizza(new Margherita());
                     return pizzaBuilder.GetPizzaIngredientes(topping);
                case "San Remo":
                    pizzaBuilder.setPizza(new SanRemo());
                    return  pizzaBuilder.GetPizzaIngredientes(topping);
                case "Sublime":
                    pizzaBuilder.setPizza(new Sublime());
                    return  pizzaBuilder.GetPizzaIngredientes(topping);
                case "Calabria":
                    pizzaBuilder.setPizza(new Calabria());
                    return  pizzaBuilder.GetPizzaIngredientes(topping);
                case "Firenze":
                    pizzaBuilder.setPizza(new Firenze());
                    return  pizzaBuilder.GetPizzaIngredientes(topping);
                default:
                    throw new ArgumentException("unknown topping.");
            }
        }
    }
}
