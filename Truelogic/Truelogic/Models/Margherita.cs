using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic.Models
{
    public class Margherita: IPizza
    {
        public List<string> Ingredients => new List<string>() { "Tomato", "Basil" };

        public string Name => "Margherita";

        public List<string> GetIngredients()
        {
            return Ingredients;
        }
    }
}
