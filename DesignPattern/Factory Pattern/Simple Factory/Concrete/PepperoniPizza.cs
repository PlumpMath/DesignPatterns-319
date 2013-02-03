using Factory_Pattern.Simple_Factory.Contract;
using System;

namespace Factory_Pattern.Simple_Factory.Concrete
{
    public class PepperoniPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing the base for the pizza. Pouring some pepperoni over them");
        }

        public void Bake()
        {
            Console.WriteLine("Baking the pizza at 250 C");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into proportionate pieces");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza for delivery");
        }
    }
}
