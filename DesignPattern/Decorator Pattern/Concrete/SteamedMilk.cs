using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class SteamedMilk : CondimentDecorator
    {
        public Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description
        {
            get 
            {
                return _beverage.Description + ", Steamed Milk";
            }
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
