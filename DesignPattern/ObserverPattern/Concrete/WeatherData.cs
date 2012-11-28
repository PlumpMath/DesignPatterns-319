using System;
using System.Collections;
using ObserverPattern.Contract;
using ObserverPattern.Property;

namespace ObserverPattern.Concrete
{
    public class WeatherData : Subject
    {
        ArrayList ObserversList = new ArrayList();
        Parameter _parameter = new Parameter();
        public void RegisterObservers(Observer O)
        {
            ObserversList.Add(O);
        }

        public void RemoveObservers(Observer O)
        {
            ObserversList.Remove(O);
        }

        public void NotifyObservers()
        {
            foreach (Observer subscriber in ObserversList)
            {
                subscriber.Update(_parameter);
            }
        }
        public void measurementsChanged()
        {
            NotifyObservers();
        }
        public void setMeasurements(float temp, float humidity, float pressure)
        {
            _parameter.Humidity = humidity;
            _parameter.Temp = temp;
            _parameter.Pressure = pressure;
        }
    }
}
