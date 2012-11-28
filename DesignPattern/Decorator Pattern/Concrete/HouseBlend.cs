using Decorator_Pattern.Abstract;
namespace Decorator_Pattern.Concrete
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
