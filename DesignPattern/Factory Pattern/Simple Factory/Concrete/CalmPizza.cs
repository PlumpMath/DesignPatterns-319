using Factory_Pattern.Simple_Factory.Contract;
using System;

namespace Factory_Pattern.Simple_Factory.Concrete
{
    public class CalmPizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing base for Calm pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking the pizza at 250 C");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza in proportionate pieces");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza for delivery");
        }
    }
}
