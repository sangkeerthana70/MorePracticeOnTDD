using NUnit.Framework;
using System;


namespace TheSupermarketQueue
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void IfCustomersArrayIsEmpty_ReturnZero()
        {
            long expected = 0;

            long actual = Kata.QueueTime(new int[] { }, 1);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void IfTillIsOne_ReturnTotalCheckOutTimeOfCustomersInArray()
        {
            long expected = 10;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void IfTillIsTwo_ReturnMaximumTimeTakenByTheCustomersWithLongerCheckOutTime()
        {
            long expected = 9;

            long actual = Kata.QueueTime(new int[] { 3, 2, 2, 3, 4, 4 }, 2);

            Assert.AreEqual(expected, actual);
        }
        /*
        [Test]
        public void ExampleTest4()
        {
            long expected = 5;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.AreEqual(expected, actual);
        }
        */
    }
}

