using System;

namespace Opgave2_1.console.Business
{
    public interface ICurrencyConverter
    {
        double ExchangeRate { get; }
        void ChangeExchangeRate(double newExchangeRate);
        double KrToEuro(double amount);
        double EuroToKr(double amount);
    }

    public class CurrencyConverter : ICurrencyConverter
    {
        public double ExchangeRate { get; private set; } = 7.45;

        public CurrencyConverter()
        {
        }

        public CurrencyConverter(double exchangeRate)
        {
            ExchangeRate = exchangeRate;
        }

        public void ChangeExchangeRate(double newExchangeRate) => ExchangeRate = newExchangeRate;

        public double KrToEuro(double amount) => Math.Round(amount / ExchangeRate, 2);

        public double EuroToKr(double amount) => Math.Round(amount * ExchangeRate, 2);
    }
}