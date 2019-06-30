using NUnit.Framework;
using System;

/*
 * There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!

    input
    customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
    n: a positive integer, the number of checkout tills.
    output
    The function should return an integer, the total time required.

    Examples:

    queueTime([5,3,4], 1)
    // should return 12
    // because when there is 1 till, the total time is just the sum of the times

    queueTime([10,2,3,3], 2)
    // should return 10
    // because here n=2 and the 2nd, 3rd, and 4th people in the 
    // queue finish before the 1st person has finished.

    queueTime([2,3,10], 2)
    // should return 12
    */

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
            Console.WriteLine("actual " + actual);

            Assert.AreEqual(expected, actual);
        }

        
        
        [Test]
        public void IfTillIsTwo_ReturnMaximumTimeTakenByTheCustomersWithLongerCheckOutTime()
        {
            long expected = 9;

            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);
            Console.WriteLine("actual " + actual);
            Assert.AreEqual(expected, actual);
        }
        
        [Test]

        public void IfTillsIsGreaterThanTwo_ReturnTheMaxCheckOutTime()
        {
            long expected = 5;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);
            Console.WriteLine("actual " + actual);
            Assert.AreEqual(expected, actual);
        }
        
    }
}

