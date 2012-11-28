using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_Pattern.Abstract
{
    public abstract class Beverage
    {
        public string _description = "Unknown Beverage";

        public virtual string Description
        {
            get
            {
                return _description;
            }
        }

        public abstract double Cost();
    }
}
