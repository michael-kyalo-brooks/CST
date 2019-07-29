using System;
using System.Collections.Generic;
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
        public void InvalidArgument()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => DoTest(1m, "Pear"));
        }

        [Test]
        public void OrderIndependent()
        {
            var list = new List<string>() { "Apple", "Orange" };
            var priceForward = _priceCalculator.Calculate(list);
            list.Reverse();
            var priceBackward = _priceCalculator.Calculate(list);
            Assert.AreEqual(priceForward, priceBackward);
        }

        [Test]
        [TestCase(0.6, "Apple")]
        [TestCase(1.2, "Apple", "Apple")]
        [TestCase(1.8, "Apple", "Apple", "Apple")]
        [TestCase(2.4, "Apple", "Apple", "Apple", "Apple")]
        [TestCase(0.25, "Orange")]
        [TestCase(0.5, "Orange", "Orange")]
        [TestCase(0.75, "Orange", "Orange", "Orange")]
        [TestCase(1, "Orange", "Orange", "Orange", "Orange")]
        [TestCase(0.85, "Apple", "Orange")]
        public void VariousLists(decimal target, params string[] items)
        {
            DoTest(target, items);
        }
    }
}
