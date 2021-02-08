using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HeadSpring.Core.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FizzBuzzStrategyShouldNotBeEmpty()
        {
            var game = new FizzBuzz();
            game.Process(null);
        }

        [TestMethod()]
        public void FizzBuzzTest()
        {            
            var game = new FizzBuzz();
            game.Process(new RangeNumbers(1,100));
        }

    }
}