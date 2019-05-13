using NUnit.Framework;
using SmallestService;
using System;

namespace Tests
{
    public class Tests2
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindClosestIntToZero(input));
        }
        [Test]
        public void FindClosestIntToZeroIfArrayLengthIsOneAndInputIsOneReturnOne()
        {
            var finder = new Finder();
            var input = new int[1] { 1 };
            int expected = 1;
            int actual = finder.FindClosestIntToZero(input);
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void FindClosestIntToZeroIfInputIsTwoAndThreeReturnsTwo()
        {
            var finder = new Finder();
            var input = new int[2] { 2, 3 };
            int expected = 2;
            int actual = finder.FindClosestIntToZero(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IfInputLengthIsThreeReturnsClosestToZero()
        {
            var finder = new Finder();
            var input = new int[3] { 7, 8, 0 };
            int expected = 0;
            int actual = finder.FindClosestIntToZero(input);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IfInputContainsNegativeNumberReturnClosestToZero()
        {
            var finder = new Finder();
            var input = new int[4] { 7, 8, 2, -1 };
            int expected = -1;
            int actual = finder.FindClosestIntToZero(input);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void IfInputContainsNegativeNumberAndPostiveNumberBothAreSameClosestToZeroReturnNegativeNumber()
        {
            var finder = new Finder();
            var input = new int[5] {8, 7, -8, 12, -7};
            int expected = -7;
            int actual = finder.FindClosestIntToZero(input);
            Assert.AreEqual(expected, actual);
        }
    }
}