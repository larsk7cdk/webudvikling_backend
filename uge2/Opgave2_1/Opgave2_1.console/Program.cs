using System;
using Opgave2_1.console.Business;

namespace Opgave2_1.console
{
    class Program
    {
        private readonly ICurrencyConverter _currencyConverter = new CurrencyConverter();

        static void Main()
        {

            Console.WriteLine("Hello World!");
        }
    }
}
