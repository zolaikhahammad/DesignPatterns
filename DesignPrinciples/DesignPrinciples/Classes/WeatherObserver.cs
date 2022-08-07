using DesignPrinciples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciples.Classes
{
    public class WeatherObserver : IObserver
    {
        private int pressure;
        private int temprature;
        private int humidity;
        private ISubject subject;
        public WeatherObserver(ISubject _subject)
        {
            subject = _subject;
            subject.AddObserver(this);
        }
        public void Update(int _pressure, int _temprature, int _humidity)
        {
            pressure = _pressure;
            temprature = _temprature;
            humidity=_humidity;
            ShowData();
        }
        public void ShowData()
        {
            Console.WriteLine("Pressure: "+pressure+" Temprature: "+temprature+" Humidity:"+humidity);
        }
    }
}
