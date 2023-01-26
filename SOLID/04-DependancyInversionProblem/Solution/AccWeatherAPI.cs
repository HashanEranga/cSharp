using SOLID.DependancyInversionProblem.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependancyInversionProblem.Solution
{
    public class AccWeatherAPI : WeatherSource
    {
        public double getTemperature()
        {
            return 50.0;
        }
    }
}
