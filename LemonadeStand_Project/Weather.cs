using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        public int currentTemperature;
        public string currentWeatherCondition;
        public string weatherCondition;

        public string CurrentWeatherCondition()
        {
            Random randomWeather = new Random();
            int weather = randomWeather.Next(1, 4);
            switch (weather)
            {
                case 1:
                    weatherCondition = "HOT";
                    CurrentTemperature();
                    break;
                case 2:
                    weatherCondition = "RAIN";
                    CurrentTemperature();
                    break;
                default:
                    weatherCondition = "CLOUDY";
                    CurrentTemperature();
                    break;
            }
            return weatherCondition;
        }
        public void CurrentTemperature()
        {
            Random randomTemperature = new Random();
            int currentTemperature = randomTemperature.Next(80, 85);
            this.currentTemperature = TemperatureChange(currentTemperature);
        }
        public int TemperatureChange(int currentTemperature)
        {
            if (weatherCondition == "RAIN")
            {
                currentTemperature -= 20;
                return currentTemperature;
            }
            else if (weatherCondition == "HOT")
            {
                currentTemperature = currentTemperature += 10;
                return currentTemperature;
            }
            else
            {
                currentTemperature = currentTemperature -= 5;
                return currentTemperature;
            }
        }
    }
}
