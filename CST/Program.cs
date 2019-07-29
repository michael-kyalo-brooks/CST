using System;
using System.Collections.Generic;

namespace CST
{

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
