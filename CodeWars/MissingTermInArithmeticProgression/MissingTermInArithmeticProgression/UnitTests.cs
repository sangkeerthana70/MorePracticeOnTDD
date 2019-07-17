﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingTermInArithmeticProgression
{
    [TestFixture]
    public class UnitTests
    {
        /*
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new[] { new List<int> { 1, 3, 5, 9, 11 } }).Returns(7);
                yield return new TestCaseData(new[] { new List<int> { 0, 5, 10, 20, 25 } }).Returns(15);
                yield return new TestCaseData(new[] { new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 } }).Returns(10);
                yield return new TestCaseData(new[] { new List<int> { 1040, 1220, 1580 } }).Returns(1400);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(List<int> list) => Kata.FindMissing(list);
        */
        [Test]
        public void a_IntegerList_ReturnsMissingNumberInSeries()
        {
            List<int> ints = new List<int> { 1, 3, 5, 9, 11 };
            int expected = 7;
            int actual = Kata.FindMissing(ints);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void b_IntegerList_ReturnsMissingNumberInSeries()
        {
            List<int> ints = new List<int> { 0, 5, 10, 20, 25 };
            int expected = 15;
            int actual = Kata.FindMissing(ints);
            Assert.AreEqual(expected, actual);
        }
    }
}
