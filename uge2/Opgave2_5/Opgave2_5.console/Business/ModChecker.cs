using System.Collections.Generic;

namespace Opgave2_5.console.Business
{
    public interface IModChecker
    {
        IEnumerable<string> Check(int min, int max);
    }
    public class ModChecker : IModChecker
    {
        public IEnumerable<string> Check(int min, int max)
        {
            for (var i = min; i <= max; i++)
            {
                yield return i % 2 == 0 ? $"{i} - Lige" : $"{i} - Ulige";
            }
        }
    }
}