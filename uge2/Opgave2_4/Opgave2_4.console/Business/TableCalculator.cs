using System.Collections.Generic;

namespace Opgave2_4.console.Business
{
    public interface ITableCalculator
    {
        IEnumerable<int> Calc(int number);
    }

    public class TableCalculator : ITableCalculator
    {
        public IEnumerable<int> Calc(int number)
        {
            for (var i = 1; i <= 10; i++)
            {
                yield return number * i;
            }
        }
    }
}