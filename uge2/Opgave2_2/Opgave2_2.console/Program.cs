using System;
using System.Globalization;
using System.Threading;
using Opgave2_2.console.Business;

namespace Opgave2_2.console
{
    internal class Program
    {
        private static readonly ITemperatureConverter TemperatureConverter = new TemperatureConverter();

        private static void Main(string[] args)
        {
            Console.WriteLine("For at afslutte, tast q og <Enter>");

            while (true)
            {
                var input = ParseInput();

                if (input.Equals("q"))
                    Environment.Exit(0);

                var temperature = ParseTemperature(input);
                var temperatureType = temperature.EndsWith('c') ? " grader Fahrenheit" : " grader Celsius";
                var temperatureConverted = TemperatureConverter.Convert(temperature);

                Console.WriteLine($"Omregnet temperatur er: {temperatureConverted}{temperatureType}");
                Console.WriteLine();
            }
        }

        private static string ParseInput()
        {
            Console.WriteLine("Indtast en temperatur som 1,23c for Celsius, eller 1,23f for Fahrenheit");
            while (true)
            {
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Du skal indtaste q eller en temperatur!");
                    continue;
                }

                if (input.StartsWith('q'))
                {
                    return "q";
                }

                if (!input.ToLower().EndsWith('c') && !input.ToLower().EndsWith('f'))
                {
                    Console.WriteLine("Temperatur skal afsluttes med c eller f!");
                    continue;
                }

                return input;
            }
        }

        private static string ParseTemperature(string input)
        {
            var x = input;

            while (true)
            {
                if (string.IsNullOrEmpty(x))
                {
                    Console.WriteLine("Du skal indtaste en temperatur!");
                    continue;
                }

                var temp = x.Substring(0, x.Length - 2);

                if (double.TryParse(temp, out _)) return x;

                Console.WriteLine("Ugyldig temperatur, prøv igen!");
                x = Console.ReadLine();
            }
        }
    }
}