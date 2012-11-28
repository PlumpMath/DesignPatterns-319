using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class Soy: CondimentDecorator
    {
        public Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description
        {
            get 
            {
                return _beverage.Description + ", Soy";
            }
        }

        public override double Cost()
        {
            return 0.35 + _beverage.Cost();
        }
    }
}
