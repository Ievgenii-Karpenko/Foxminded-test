using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace MaxElementsSum.Tests
{
    [TestClass()]
    public class MaxSumFinderTests
    {
        [TestMethod()]
        public void CalculateMaxSum_Test()
        {
            var maxSumFinder = new MaxSumFinder();
            var max = maxSumFinder.CalculateMaxSum("testData.txt");


            Assert.AreEqual(100, max.Sum);
            Assert.AreEqual(3, max.Line);
            
            Assert.AreEqual(1, maxSumFinder.FailedLines.Count);
            Assert.AreEqual(4, maxSumFinder.FailedLines.First());
        }
    }
}