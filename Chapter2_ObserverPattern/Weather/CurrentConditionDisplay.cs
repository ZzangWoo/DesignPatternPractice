using Chapter2_ObserverPattern.Weather.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2_ObserverPattern.Weather
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine($"현재 상태 : 온도 - {_temperature}C / 습도 - {_humidity}%");
        }
    }
}
