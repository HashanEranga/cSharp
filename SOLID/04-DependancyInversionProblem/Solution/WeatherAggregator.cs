using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependancyInversionProblem.Solution
{
    public class WeatherAggregator
    {
        private WeatherSource[] weatherSources;

        public WeatherAggregator(WeatherSource[] weatherSources)
        {
            this.weatherSources = weatherSources;
        }

        public double getTemperature()
        {
            double temperature = weatherSources.Average(weatherSource => weatherSource.getTemperature());
            return temperature;
        }
    }
}
