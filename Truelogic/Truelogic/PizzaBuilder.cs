using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truelogic
{
    public class PizzaBuilder
    {
        private IPizza _pizza;

        public void setPizza(IPizza pizza) { 
            _pizza = pizza;
        }

        public IEnumerable<string> GetPizzaIngredientes(string toopings) {
            return Enumerable.Union(_pizza.Ingredients, _pizza.GetIngredients()).ToList();
            //return _pizza.GetIngredients();
            //var fullIngredients = _pizza.Ingredients;
            //return fullIngredients = new List<string>().Add()
        }
    }
}
