using System;
using System.Collections.Generic;
using System.Linq;

namespace CST
{
    public class PriceCalculator : IPriceCalculator
    {
        int appleCount;
        int orangeCount;

        public decimal Calculate(IEnumerable<string> list)
        {
            appleCount = 0;
            orangeCount = 0;

            return list.Select(GetPrice).Sum();
        }

        private decimal GetPrice(string item)
        {
            if (item.ToUpperInvariant() == "APPLE")
            {
                appleCount++;
                if (appleCount % 2 == 0)
                {
                    return 0m;
                }

                return 0.6m;
            }
            else if (item.ToUpperInvariant() == "ORANGE")
            {
                orangeCount++;
                if (orangeCount % 3 == 0)
                {
                    return 0m;
                }

                return 0.25m;
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
