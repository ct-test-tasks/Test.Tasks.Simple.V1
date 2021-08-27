using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2.Services
{
    public class WeatherForecastService
    {
        private static readonly Random Rng = new Random();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public IEnumerable<WeatherForecast> GetAll()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = Rng.Next(-20, 55),
                    Summary = Summaries[Rng.Next(Summaries.Length)]
                })
                .ToArray();
        }
    }
}