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

        [Test]
        [TestCase(0.6, "Apple")]
        [TestCase(1.2, "Apple", "Apple")]
        [TestCase(1.8, "Apple", "Apple", "Apple")]
        [TestCase(2.4, "Apple", "Apple", "Apple", "Apple")]
        public void VariousLists(decimal target, params string[] items)
        {
            DoTest(target, items);
        }
    }
}
