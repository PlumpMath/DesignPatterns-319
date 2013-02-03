using Factory_Pattern.Simple_Factory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Simple_Factory.Concrete
{
    public class PizzaFactory : IPizzaFactory
    {
        private IPizza _pizza;
        public IPizza CreatePizza(PizzaType type)
        {
            if (type == PizzaType.Calm)
                _pizza = new CalmPizza();
            else if (type == PizzaType.Cheese)
                _pizza = new CheesePizza();
            else if (type == PizzaType.Veggie)
                _pizza = new VeggiePizza();
            else if (type == PizzaType.Pepperoni)
                _pizza = new PepperoniPizza();
            return _pizza;
        }
    }
}
