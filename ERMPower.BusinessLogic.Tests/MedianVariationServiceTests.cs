using System;
using ERMPower.BusinessLogic.Interfaces;
using NSubstitute;
using NUnit.Framework;

namespace ERMPower.BusinessLogic.Tests
{
    [TestFixture]
    public class MedianVariationServiceTests
    {
        [Test]
        public void GetMedianVariances_ReturnsCorrectData_ForLPRecords()
        {
            var mockRepository = Substitute.For<IRepository>();
            mockRepository.GetLPRecords()
                .Returns(TestDataGenerator.GenerateLPRecords());

            var medianVariationService = new MedianVariationService(mockRepository, new MedianCalculator());
            var actualResult = medianVariationService.GetMedianVariances();

            Assert.AreEqual(20, actualResult[0].MedianValue);
            Assert.AreEqual(0, actualResult[0].VariancePercentage);
            Assert.AreEqual(25, actualResult[1].VariancePercentage);
            Assert.AreEqual(25, actualResult[2].VariancePercentage);
            Assert.AreEqual(10, actualResult[3].VariancePercentage);
            Assert.AreEqual(40, actualResult[4].VariancePercentage);
            Assert.AreEqual(35, actualResult[5].VariancePercentage);
            Assert.AreEqual(20, actualResult[6].VariancePercentage);
        }

        [Test]
        public void GetMedianVariances_ReturnsCorrectData_ForTOURecords()
        {
            var mockRepository = Substitute.For<IRepository>();
            mockRepository.GetTOURecords()
                .Returns(TestDataGenerator.GenerateTOURecords());

            var medianVariationService = new MedianVariationService(mockRepository, new MedianCalculator());
            var actualResult = medianVariationService.GetMedianVariances();

            Assert.AreEqual(12.26m, actualResult[0].MedianValue);
            Assert.AreEqual(53.507, Math.Round(actualResult[0].VariancePercentage, 3));
            Assert.AreEqual(33.116, Math.Round(actualResult[1].VariancePercentage, 3));
            Assert.AreEqual(0, actualResult[4].VariancePercentage);
        }
    }
}