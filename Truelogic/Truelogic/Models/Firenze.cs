using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic.Models
{
    public class Firenze : IPizza
    {
        public string Name => "Firenze";
        public List<string> Ingredients => new List<string>() { "Heart of Palm", "Mushroom", "Chicken", "Cream Cheese" };

        public List<string> GetIngredients()
        {
            return Ingredients;
        }
    }
}
