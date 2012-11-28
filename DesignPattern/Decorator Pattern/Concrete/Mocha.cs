using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class Mocha: CondimentDecorator
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override string Description
        {
            get 
            {
                return _beverage.Description + ", Mocha";
            }
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }
    }
}
