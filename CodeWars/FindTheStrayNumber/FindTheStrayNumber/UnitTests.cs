using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheStrayNumber
{
    /*
     * 
     * You are given an odd-length array of integers, in which all of them are the same,
     * 
     * except for one single number.  Complete the method which accepts such an array,
     * 
     * and returns that single different number.
     * 
        The input array will always be valid! (odd-length >= 3)
        Examples
        [1, 1, 2] ==> 2
        [17, 17, 3, 17, 17, 17, 17] ==> 3
    */


    [TestFixture]
    class UnitTests
    {
        [Test]
        public void CheckIfAInputReturnsTheExpectedOutput()
        {           
            Assert.AreEqual(0, StrayNumbers.Stray(new int[] { }));
        }

        [Test]
        public void SimpleInputArrayReturnsExpectedOutput()
        {
            Assert.AreEqual(2, StrayNumbers.Stray(new int[] { 1, 1, 2 }));
        }

        [Test]
        public void ReturnsFirstElementAsStrayNumber()
        {
            Assert.AreEqual(9, StrayNumbers.Stray(new int[] { 9, 99, 99, 99, 99 }));
        }

        [Test]
        public void ReturnsLastElementAsStrayNumber()
        {
            Assert.AreEqual(2, StrayNumbers.Stray(new int[] { 10, 10, 10, 10, 2 }));
        }

        [Test]
        public void ReturnsMiddleElementAsStrayNumber()
        {
            Assert.AreEqual(3, StrayNumbers.Stray(new int[] { 17, 17, 17, 3, 17, 17, 17}));
        }

        

    }
}
