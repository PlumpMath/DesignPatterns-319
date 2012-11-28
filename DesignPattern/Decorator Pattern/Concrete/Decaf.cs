using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
