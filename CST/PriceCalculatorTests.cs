using NUnit.Framework;

namespace CST
{
    [TestFixture]
    public class PriceCalculatorTests
    {
        public IPriceCalculator _priceCalculator = new PriceCalculator();
        
        private void DoTest(decimal targetPrice, params string[] items)
        {
            var price = _priceCalculator.Calculate(items);
            Assert.AreEqual(targetPrice, price);
        }

        [Test]
        public void EmptyListIsZero()
        {
            DoTest(0m);
        }
    }
}
