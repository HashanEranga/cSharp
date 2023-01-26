using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependancyInversionProblem.Solution
{
    public interface WeatherSource
    {
        double getTemperature();
    }
}
