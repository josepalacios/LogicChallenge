using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic.Models
{
    public class Calabria : IPizza
    {
        public string Name => "Calabria";
        public List<string> Ingredients => new List<string>() { "Pepperoni", "Bacon" };

        public List<string> GetIngredients()
        {
            return Ingredients;
        }
    }
}
