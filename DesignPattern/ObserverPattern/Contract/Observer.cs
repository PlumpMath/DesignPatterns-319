using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Property;

namespace ObserverPattern.Contract
{
    public interface Observer
    {
        void Update(Parameter updatedParameter);
    }
}
