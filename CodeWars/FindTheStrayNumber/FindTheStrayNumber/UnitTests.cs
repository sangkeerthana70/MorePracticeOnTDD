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

            int expected = 0;
            Assert.AreEqual(0, StrayNumbers.Stray(new int[] { 0, 0, 0 }));
        }
        
        [Test]
        public void AnArrayOfLength3Returns2AsOutput()
        {
            Assert.AreEqual(2, StrayNumbers.Stray(new int[] { 1, 1, 2 }));
        }

        [Test]
        public void AnArrayOfOddNumberOFInputsReturns3AsOutput()
        {
            Assert.AreEqual(3, StrayNumbers.Stray(new int[] { 17, 17, 3, 17, 17, 17, 17 }));
        }

        [Test]
        public void AnArrayOfOddNumberOfInputsReturns9AsOutput()
        {
            Assert.AreEqual(9, StrayNumbers.Stray(new int[] { 99, 99, 9, 99, 99 }));
        }

    }
}
