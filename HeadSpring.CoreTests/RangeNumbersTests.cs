using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HeadSpring.Core.Tests
{
    [TestClass()]
    public class RangeNumbersTests
    {

        [TestMethod()]
        public void ReturnRangeOfNumbersInUpdateRange()
        {
            var range = new RangeNumbers(1, 100);
            range.UpdateRange(2, 20);
            foreach (var number in range.GetNumbers())
            {
                if (number < 2 || number > 20)
                {
                    Assert.Fail("Invalid number returned");
                }
            }
        }

        [TestMethod()]
        public void ReturnRangeOfNumbersInCtor()
        {
            var range = new RangeNumbers(1, 100);
            foreach (var number in range.GetNumbers())
            {
                if (number < 1 || number > 100)
                {
                    Assert.Fail("Invalid number returned");
                }
            }
        }
    }
}