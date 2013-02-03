using Factory_Pattern.Simple_Factory.Contract;
using System;

namespace Factory_Pattern.Simple_Factory.Concrete
{
    public class CheesePizza : IPizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing the pizza base. Spreading cheese all over it.");
        }

        public void Bake()
        {
            Console.WriteLine("Baking at 250 C");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into proportionate pieces");
        }

        public void Box()
        {
            Console.WriteLine("Boxing the pizza");
        }
    }
}
