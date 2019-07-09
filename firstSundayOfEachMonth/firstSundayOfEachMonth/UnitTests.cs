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

    }
}
