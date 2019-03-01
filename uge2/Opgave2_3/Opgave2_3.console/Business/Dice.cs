using System;

namespace Opgave2_3.console.Business
{
    public interface IDice
    {
        int Throw();
    }

    public class Dice : IDice
    {
        private readonly int _maxEyes;

        public Dice(int maxEyes = 6)
        {
            _maxEyes = maxEyes;
        }

        public int Throw() => new Random().Next(0, _maxEyes) + 1;
    }
}