using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HeadSpring.Core.Tests
{
    [TestClass()]
    public class DefinedNumbersTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DefinedNumbersShouldNotAcceptNullNumbers()
        {
            var x = new DefinedNumbers(null);
        }

        [TestMethod()]
        public void ReturnDefinedNUmberInUpdateNUmbers()
        {
            var lst = new List<int> { 5, 7, 8, 9, 2, 200, 300 };
            var x = new DefinedNumbers(new List<int> { 5, 7, 8, 9, 2, 200 });
            x.UpdateNumbers(lst);
            foreach (var number in x.GetNumbers())
            {
                if (!lst.Exists(l => l.Equals(number)))
                {
                    Assert.Fail("Invalid number returned");
                }
            }
        }

        [TestMethod()]
        public void ReturnDefinedNUmberInCtor()
        {
            var lst = new List<int> { 5, 7, 8, 9, 2, 200, 300 };
            var x = new DefinedNumbers(lst);
            foreach (var number in x.GetNumbers())
            {
                if (!lst.Exists(l => l.Equals(number)))
                {
                    Assert.Fail("Invalid number returned");
                }
            }
        }
    }
}