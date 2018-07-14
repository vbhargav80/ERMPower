using System.Collections.Generic;
using NUnit.Framework;

namespace ERMPower.BusinessLogic.Tests
{
    [TestFixture]
    public class MedianCalculatorTests
    {
        [Test]
        public void CalculateMedian_WithEvenNumberOfItemsInList_GivesCorrectValue()
        {
            var calculator = new MedianCalculator();
            var mockList = new List<decimal> {1.78m, 6.09m, 0.007m, 1.4m, 2.78m, 8.9m};
            var actualValue = calculator.CalculateMedian(mockList);

            Assert.AreEqual(2.28m, actualValue);
        }

        [Test]
        public void CalculateMedian_WithOddNumberOfItemsInList_GivesCorrectValue()
        {
            var calculator = new MedianCalculator();
            var mockList = new List<decimal> {1.78m, 6.09m, 0.007m, 1.4m, 2.78m, 8.9m, 4.448m, 5.553m, 1.113m};
            var actualValue = calculator.CalculateMedian(mockList);

            Assert.AreEqual(2.78m, actualValue);
        }
    }
}