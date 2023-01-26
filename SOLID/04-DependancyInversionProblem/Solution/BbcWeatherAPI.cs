using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependancyInversionProblem.Solution
{
    public class BbcWeatherAPI : WeatherSource
    {
        public double getTemperature()
        {
            return toCelcius(getTemperatureFarenheit());
        }

        private double getTemperatureFarenheit()
        {
            return 50.0;
        }

        private double toCelcius(double value)
        {
            return (value - 32) / 1.8;
        }
    }
}
