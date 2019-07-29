using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST
{
    interface IPriceCalculator
    {
        decimal Calculate(IEnumerable<string> shoppingList);
    }

    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<string>() { string.Empty };
            var result = (string)null;
            try
            {
                IPriceCalculator calculator = null;
                var price = calculator.Calculate(shoppingList);
                result = "£" + price.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
