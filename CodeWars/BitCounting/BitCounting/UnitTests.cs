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

        [Test]
        public void Inputof9Returns2Ones_InBinaryRepresentationOf9()
        {
            int input = 9;
            int expected = 2;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }

        [Test]
        public void Inputof10Returns2Ones_InBinaryRepresentationOf10()
        {
            int input = 10;
            int expected = 2;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }
        [Test]
        public void Inputof1234Returns5Ones_InBinaryRepresentationOf1234()
        {
            int input = 1234;
            int expected = 5;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }

        [Test]
        public void Inputof1500Returns7Ones_InBinaryRepresentationOf1500()
        {
            int input = 1500;
            int expected = 7;
            Assert.AreEqual(expected, BitCounting.countBits(input));
        }

    }
}
