
using Factory_Pattern.Simple_Factory.Concrete;
using System;
namespace Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaStore = new PizzaStore();
            pizzaStore.OrderPizza(PizzaType.Cheese);
            Console.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Calm);
            Console.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Pepperoni);
            Console.WriteLine();
            pizzaStore.OrderPizza(PizzaType.Veggie);
            Console.ReadKey();
        }
    }
}
