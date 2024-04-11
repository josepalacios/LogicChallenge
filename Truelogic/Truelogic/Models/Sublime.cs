using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic.Models
{
    public class Sublime : IPizza
    {
        public string Name => "Sublime";
        public List<string> Ingredients => new List<string>() { "Cheddar", "Mignon" };
        public List<string> GetIngredients()
        {
            return Ingredients;
        }
    }
}
