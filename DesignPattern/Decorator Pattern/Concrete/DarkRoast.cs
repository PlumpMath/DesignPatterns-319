using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
