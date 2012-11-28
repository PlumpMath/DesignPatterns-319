using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Contract;
using ObserverPattern.Property;

namespace ObserverPattern.Concrete
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private Parameter _parameter;
        private Subject _subject;

        public CurrentConditionsDisplay(Subject subject)
        {
            _subject = subject;
            _subject.RegisterObservers(this);
            _parameter = new Parameter();
        }
        public void Update(Parameter updatedParameter)
        {
            _parameter = updatedParameter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + _parameter.Temp + "F Degrees and " + _parameter.Humidity + "% humidity");
        }
    }
}
