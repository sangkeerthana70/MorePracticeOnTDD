using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheStrayNumber
{
    [TestFixture]
    class UnitTests
    {
        [Test]
        public void CheckIfAInputReturnsTheExpectedOutput()
        {

            int expected = 0;
            Assert.AreEqual(0, StrayNumbers.Stray(new int[] { 0, 0, 0 }));
        }
        
        [Test]
        public void AnArrayOfLength3Returns2AsOutput()
        {
            Assert.AreEqual(2, StrayNumbers.Stray(new int[] { 1, 1, 2 }));
        }

        [Test]
        public void AnArrayOfOddInputReturns3AsOutput()
        {
            Assert.AreEqual(3, StrayNumbers.Stray(new int[] { 17, 17, 3, 17, 17, 17, 17 }));
        }

    }
}
