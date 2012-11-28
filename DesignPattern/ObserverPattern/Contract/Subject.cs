using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverPattern.Property;

namespace ObserverPattern.Contract
{
    public interface Subject
    {
        void RegisterObservers(Observer O);
        void RemoveObservers(Observer O);
        void NotifyObservers();
    }
}
