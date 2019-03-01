using System;
using Opgave2_1.console.Business;

namespace Opgave2_1.console
{
    public class Program
    {
        private static readonly ICurrencyConverter CurrencyConverter = new CurrencyConverter();

        public static void Main(string[] args)
        {
            var exchangeRate = ParseExchangeRate(CurrencyConverter.ExchangeRate);
            var exchange = ParseExchange();
            var amount = ParseAmount();

            CurrencyConverter.ChangeExchangeRate(exchangeRate);

            var exchangedAmount = exchange.StartsWith('k')
                ? CurrencyConverter.KrToEuro(amount)
                : CurrencyConverter.EuroToKr(amount);

            var exchangeType = exchange.StartsWith('k') ? "Euro" : "Kr.";
            Console.WriteLine($"Dit beløb efter veksling er: {exchangedAmount} {exchangeType}");
        }

        private static double ParseExchangeRate(double actualExchangeRate)
        {
            double parsedExchangeRate;
            while (true)
            {
                Console.WriteLine($"Angiv kurs. Tast <Enter> for at benytte aktuel kurs på {actualExchangeRate}.");
                var exchangeRate = Console.ReadLine();

                if (string.IsNullOrEmpty(exchangeRate))
                {
                    return actualExchangeRate;
                }

                if (!double.TryParse(exchangeRate, out parsedExchangeRate))
                {
                    Console.WriteLine("Ugyldig indtastning!");
                    continue;
                }

                return parsedExchangeRate;
            }
        }

        private static string ParseExchange()
        {
            Console.WriteLine("Angiv k for at veksle Kroner til Euro. Angiv e for at veksle Euro til Kroner.");
            while (true)
            {
                var exchange = Console.ReadLine();

                if (string.IsNullOrEmpty(exchange))
                {
                    Console.WriteLine("Der skal angives k eller e!");
                    continue;
                }

                if (!exchange.ToLower().StartsWith('k') && !exchange.ToLower().StartsWith('e'))
                {
                    Console.WriteLine("Ugyldig indtastning. Der skal angives k eller e!");
                    continue;
                }

                return exchange;
            }
        }

        private static double ParseAmount()
        {
            double parsedAmount;
            while (true)
            {
                Console.WriteLine(("Angiv beløb der skal veksles"));
                var amount = Console.ReadLine();

                if (string.IsNullOrEmpty(amount))
                {
                    Console.WriteLine("Der skal angives et beløb!");
                    continue;
                }

                if (!double.TryParse(amount, out parsedAmount))
                {
                    Console.WriteLine("Ugyldig indtastning!");
                    continue;
                }

                return parsedAmount;
            }
        }
    }
}