﻿using Chapter2_ObserverPattern.Weather.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_ObserverPattern.Weather
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _lastPressure = _currentPressure;
            _currentPressure = pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("Forecast : ");

            if (_currentPressure > _lastPressure)
            {
                Console.WriteLine("Improving weather on the way!");
            }
            else if (_currentPressure == _lastPressure)
            {
                Console.WriteLine("More of the same");
            }
            else if (_currentPressure < _lastPressure)
            {
                Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}
