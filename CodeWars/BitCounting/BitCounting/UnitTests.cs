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
        public void Inputof1Returns4Ones_InBinaryRepresentationOf1()
        {
            int input = 1;
            int expected = 4;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }
    }
}
