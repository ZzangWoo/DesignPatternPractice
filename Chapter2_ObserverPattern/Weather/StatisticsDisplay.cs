using Chapter2_ObserverPattern.Weather.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_ObserverPattern.Weather
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _maxTemperature = 0.0f;
        private float _minTemperature = 200f;
        private float _temperatureSum = 0.0f;
        private int _numReadings;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperatureSum += temperature;
            _numReadings++;

            if (temperature > _maxTemperature)
            {
                _maxTemperature = temperature;
            }

            if (temperature < _minTemperature)
            {
                _minTemperature = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Avg/Max/Min temperature = {(_temperatureSum / _numReadings)} / {_maxTemperature} / {_minTemperature}");
        }
    }
}
