using SOLID.DependancyInversionProblem.Problem;
using SOLID.DependancyInversionProblem.Solution;
using SOLID.LiskovSubstitutionProblem.Solution;

// solid principle 3
CrowBird crow = new();
crow.Eat();
crow.Fly();

//ostrich
OstrichBird ostrichBird = new();
ostrichBird.Eat();

// DI problem
WeatherAggregatorAPI weather = new();
Console.WriteLine(weather.getTempreture());

// DI Solution
AccWeatherAPI accWeather = new();
BbcWeatherAPI bbcWeather = new();

WeatherSource[] sources = { accWeather, bbcWeather };

WeatherAggregator wetherAggregate = new(sources);
Console.WriteLine(wetherAggregate.getTemperature());
