using NUnit.Framework;
using SmallestService;
using System;


namespace Tests
{
    public class Tests
    {
        [Test]
        public void ThrowsExceptionIfArrayInputIsEmpty()
        {
            var finder = new Finder();
            var input = new int[0];
            Assert.Throws<System.ArgumentException>(() => finder.FindSmallestInt(input));
        }
        
        [Test]
        public void IfArrayLengthIsOneReturnInt()
        {
            var finder = new Finder();
            var input = new int[1] { 10 };
            int actual = finder.FindSmallestInt(input);
            int expected = 10;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IfArrayLengthIsTwoReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[2] { 10, 15 };
            int actual = finder.FindSmallestInt(input);
            int expected = 10;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IfArrayLengthIsThreeReturnLowestInt()
        {
            var finder = new Finder();
            var input = new int[3] { 10, 15, 20 };
            int actual = finder.FindSmallestInt(input);
            int expected = 10;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IfArrayLengthIsGreaterThanZeroReturnSmallestInt()
        {
            var finder = new Finder();
            var input = new int[5] { 20, 25, 30, 10, 15, };
            int actual = finder.FindSmallestInt(input);
            int expected = 10;
            Assert.AreEqual(expected, actual);

        }

    }
}