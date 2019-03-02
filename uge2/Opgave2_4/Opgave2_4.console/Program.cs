using System;
using System.Linq;
using Opgave2_4.console.Business;

namespace Opgave2_4.console
{
    public class Program
    {
        private static readonly ITableCalculator TableCalculator = new TableCalculator();

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Indtast tal for den tabel du vil se, eller q for at afslutte");

                var input = Console.ReadLine();

                if (input != null && input.Equals("q"))
                    Environment.Exit(0);

                var number = ParseInput(input);
                var result = TableCalculator.Calc(number).ToList();

                result.ForEach(x => Console.Write($"{x}  "));

                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static int ParseInput(string input)
        {
            var x = input;

            while (true)
            {
                if (string.IsNullOrEmpty(x))
                {
                    Console.WriteLine("Du skal indtaste et tal!");
                    x = Console.ReadLine();
                    continue;
                }

                if (int.TryParse(x, out var y)) return y;

                Console.WriteLine("Ugyldig indtastning, prøv igen!");
                x = Console.ReadLine();
            }
        }
    }
}
