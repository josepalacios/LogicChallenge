using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic
{
    public interface IPizza
    {
        string Name { get; }
        List<string> Ingredients => new List<string>() { "Tomato Sauce", "Mozzarella" };
        List<string> GetIngredients();
    }
}
