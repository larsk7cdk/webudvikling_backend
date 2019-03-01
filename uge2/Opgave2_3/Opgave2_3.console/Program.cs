using System;
using Opgave2_3.console.Business;

namespace Opgave2_3.console
{
    class Program
    {
        private static readonly IDice Dice = new Dice();

        public static void Main()
        {
            Console.WriteLine("Terningen kastes indtil den viser 6 øjne");
            var eye = 0;
            do
            {
                eye = Dice.Throw();
                Console.WriteLine($"Terningens øjne viser: {eye}");
            } while (eye != 6);
        }
    }
}
