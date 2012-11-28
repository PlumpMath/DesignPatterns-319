using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class Whip : CondimentDecorator
    {
        public Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description
        {
            get
            {
                return _beverage.Description + ", Whip";
            }
        }

        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }
    }
}
