using Decorator_Pattern.Abstract;
using Decorator_Pattern.Concrete;
using System;
namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage objBeverage = new Espresso();
            Console.WriteLine(objBeverage.Description + " $" + objBeverage.Cost());

            Beverage objDarkRoast = new DarkRoast();
            objDarkRoast = new Mocha(objDarkRoast);
            objDarkRoast = new Mocha(objDarkRoast);
            objDarkRoast = new Whip(objDarkRoast);
            Console.WriteLine(objDarkRoast.Description + " $" + objDarkRoast.Cost());

            Beverage objHouseBlend = new HouseBlend();
            objHouseBlend = new Soy(objHouseBlend);
            objHouseBlend = new Mocha(objHouseBlend);
            objHouseBlend = new Whip(objHouseBlend);
            Console.WriteLine(objHouseBlend.Description + " $" + objHouseBlend.Cost());
            
            Console.ReadKey();
        }
    }
}
