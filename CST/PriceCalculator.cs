using System;
using System.Collections.Generic;
using System.Linq;

namespace CST
{
    public class PriceCalculator : IPriceCalculator
    {
        public decimal Calculate(IEnumerable<string> list)
        {
            return list.Select(GetPrice).Sum();
        }

        private decimal GetPrice(string item)
        {
            if (item.ToUpperInvariant() == "APPLE")
            {
                return 0.6m;
            }
            else if (item.ToUpperInvariant() == "ORANGE")
            {
                return 0.25m;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
