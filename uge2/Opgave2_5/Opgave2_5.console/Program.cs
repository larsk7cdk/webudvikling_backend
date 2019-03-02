using System;
using System.Linq;
using Opgave2_5.console.Business;

namespace Opgave2_5.console
{
    public class Program
    {
        private static readonly IModChecker ModChecker = new ModChecker();

        public static void Main()
        {
            Console.WriteLine("Indtast tal for min værdi");
            var minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Indtast tal for max værdi");
            var maxValue = int.Parse(Console.ReadLine());

            Console.WriteLine();
            var result = ModChecker.Check(minValue, maxValue).ToList();

            result.ForEach(Console.WriteLine);
        }
    }
}
