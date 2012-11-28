using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Decorator_Pattern.Abstract;

namespace Decorator_Pattern.Concrete
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }       
}
