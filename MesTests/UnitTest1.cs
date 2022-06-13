using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ranges;
using System.Linq;

namespace MesTests
{
    [TestClass]
    public class TestRanges
    {
        [TestMethod]
        public void SmallRangeSizeIsCorrect()
        {
            var range = new Range(1, 10);

            Assert.AreEqual(9, range.Count());
            Assert.IsTrue(range.Contains(8));
        }

        [TestMethod]
        public void LargeRangeSizeIsCorrect()
        {
            var range = new Range(1, 100);

            Assert.AreEqual(99, range.Count());
        }

        [TestMethod]
        public void CanAggregate1()
        {
            var range = new Range(1, 10);

            Assert.AreEqual(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9, range.Aggregate((x, y) => x + y));
        }

        [TestMethod]
        public void CanAggregate2()
        {
            var range = new Range(3, 15);

            Assert.AreEqual(3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11+ 12 + 13 +14, range.Aggregate((x, y) => x + y));
        }
        /*
        public void AggregateCallsGetEnumerator()
        {
            var range = new Range(1, 10);
            using(ShimContext.Create())
            {
                bool called = false;
                Ranges.Fakes.ShimRangeEnumerator.RangeEnumerator = (Range param) =>
                {
                    called = true;
                    return new RangeEnumerator(Range);
                };

                Assert.AreEqual(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9, range.Aggregate((x, y) => x + y));
                Assert.IsTrue(called);

            }
        }
        */
    }
}
