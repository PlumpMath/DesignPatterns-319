using Factory_Pattern.Simple_Factory.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Simple_Factory.Concrete
{
    public class PizzaStore
    {
        private IPizzaFactory _factory;

        public PizzaStore()
        {
            _factory = new PizzaFactory();
        }
        public void OrderPizza(PizzaType type)
        {
            IPizza pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
