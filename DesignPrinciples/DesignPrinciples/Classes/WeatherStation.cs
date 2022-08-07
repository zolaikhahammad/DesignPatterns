using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class WeatherStation : ISubject
    {
        private int pressure;
        private int temprature;
        private int humidity;
        public void SetPressure(int p)
        {
            pressure = p;
            NotifyAllObserver();
        }
        public void SetTemo(int t)
        {
            temprature = t;
            NotifyAllObserver();
        }
        public void SetHumidity(int h)
        {
            humidity = h;
            NotifyAllObserver();
        }
        public List<IObserver> observers;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObserver()
        {
            foreach (var ob in observers)
                ob.Update(pressure,temprature,humidity);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
