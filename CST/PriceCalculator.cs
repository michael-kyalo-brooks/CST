using System.Collections.Generic;
using System.Linq;

namespace CST
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal Calculate(IEnumerable<string> list)
        {
            if (list.Count() > 0)
            {
                return 0.6m;
            }

            return 0m;
        }
    }
}
