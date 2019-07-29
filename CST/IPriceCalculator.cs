using System.Collections.Generic;

namespace CST
{
    public interface IPriceCalculator
    {
        decimal Calculate(IEnumerable<string> shoppingList);
    }

}
