using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void CheckIfInputReturnsExpectedOutput()
        {
            int input = 0;
            int expected = 0;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }

        [Test]
        public void Inputof4Returns1Ones_InBinaryRepresentationOf4()
        {
            int input = 4;
            int expected = 1;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }


        [Test]
        public void Inputof7Returns3Ones_InBinaryRepresentationOf7()
        {
            int input = 7;
            int expected = 3;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }
       
    }
}
