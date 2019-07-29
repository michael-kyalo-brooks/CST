using System.Collections.Generic;
using System.Linq;

namespace CST
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal Calculate(IEnumerable<string> list)
        {
            return list.Count() * 0.6m;
        }
    }
}
