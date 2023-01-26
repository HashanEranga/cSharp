using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependancyInversionProblem.Problem
{
    public class WeatherAggregatorAPI
    {
        private AccWeather accWeather = new();
        private Bbcweather bbcWeather = new();

        public double getTempreture()
        {
            return (accWeather.getTemperatureInCelcius() + toCelcius(bbcWeather.getTemperatureInFaranheit())) / 2;
        }

        private double toCelcius(double v)
        {
            return (v - 32) / 1.8;
        }
    }
}
