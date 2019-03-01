using System;

namespace Opgave2_2.console.Business
{
    public interface ITemperatureConverter
    {
        double Convert(string temperature);
    }

    public class TemperatureConverter : ITemperatureConverter
    {
        public double Convert(string temperature)
        {
            var temperatureParsed = double.Parse(temperature.Substring(0, temperature.Length - 1));

            return temperature.EndsWith('c')
                ? CelsiusToFahrenheit(temperatureParsed)
                : FahrenheitToCelsius(temperatureParsed);
        }

        private static double CelsiusToFahrenheit(double temperature) => Math.Round(temperature * 1.8 + 32, 3);

        private static double FahrenheitToCelsius(double temperature) => Math.Round((temperature - 32) / 1.8, 3);
    }
}