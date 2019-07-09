using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSundayOfEachMonth
{

    // Program to find the first monday of each month

    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void InputOfYear2019Returns_ExpectedListOfFirstMondays()
        {
            int year = 2019;
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2019, 1, 7));
            expected.Add(new DateTime(2019, 2, 4));
            expected.Add(new DateTime(2019, 3, 4));
            expected.Add(new DateTime(2019, 4, 1));
            expected.Add(new DateTime(2019, 5, 6));
            expected.Add(new DateTime(2019, 6, 3));
            expected.Add(new DateTime(2019, 7, 1));
            expected.Add(new DateTime(2019, 8, 5));
            expected.Add(new DateTime(2019, 9, 2));
            expected.Add(new DateTime(2019, 10, 7));
            expected.Add(new DateTime(2019, 11, 4));
            expected.Add(new DateTime(2019, 12, 2));

            Assert.AreEqual(expected, Kata.FindFirstMondayOfMonth(year));
        }

        [Test]
        public void InputOf2020LeapYear_ReturnsExpectedListOfFirstMondays()
        {
            int year = 2020;
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2020, 1, 6));
            expected.Add(new DateTime(2020, 2, 3));
            expected.Add(new DateTime(2020, 3, 2));
            expected.Add(new DateTime(2020, 4, 6));
            expected.Add(new DateTime(2020, 5, 4));
            expected.Add(new DateTime(2020, 6, 1));
            expected.Add(new DateTime(2020, 7, 6));
            expected.Add(new DateTime(2020, 8, 3));
            expected.Add(new DateTime(2020, 9, 7));
            expected.Add(new DateTime(2020, 10, 5));
            expected.Add(new DateTime(2020, 11, 2));
            expected.Add(new DateTime(2020, 12, 7));


            Assert.AreEqual(expected, Kata.FindFirstMondayOfMonth(year));

        }

        [Test]
        public void InputOf2032_ReturnsExpectedResult()
        {
            int year = 2032;
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2032, 1, 5));
            expected.Add(new DateTime(2032, 2, 2));
            expected.Add(new DateTime(2032, 3, 1));
            expected.Add(new DateTime(2032, 4, 5));
            expected.Add(new DateTime(2032, 5, 3));
            expected.Add(new DateTime(2032, 6, 7));
            expected.Add(new DateTime(2032, 7, 5));
            expected.Add(new DateTime(2032, 8, 2));
            expected.Add(new DateTime(2032, 9, 6));
            expected.Add(new DateTime(2032, 10, 4));
            expected.Add(new DateTime(2032, 11, 1));
            expected.Add(new DateTime(2032, 12, 6));

            Assert.AreEqual(expected, Kata.FindFirstMondayOfMonth(year));
        }
    }
}
