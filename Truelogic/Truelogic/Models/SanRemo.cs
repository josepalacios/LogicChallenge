using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic.Models
{
    public class SanRemo : IPizza
    {
        public string Name => "SanRemo";
        public List<string> Ingredients => new List<string>() { "Mushroom", "Shrimp", "Parmesan", "Parsley" };
        public List<string> GetIngredients()
        {
            return Ingredients;
        }
    }
}
