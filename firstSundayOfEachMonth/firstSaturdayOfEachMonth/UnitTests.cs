using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSaturdayOfEachMonth
{
    // program to find list of first Saturday of each month for a given year
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public static void InputOf2019_ReturnsListOfFirstSaturdays()
        {
            int year = 2019;
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2019, 1, 5));
            expected.Add(new DateTime(2019, 2, 2));
            expected.Add(new DateTime(2019, 3, 2));
            expected.Add(new DateTime(2019, 4, 6));
            expected.Add(new DateTime(2019, 5, 4));
            expected.Add(new DateTime(2019, 6, 1));
            expected.Add(new DateTime(2019, 7, 6));
            expected.Add(new DateTime(2019, 8, 3));
            expected.Add(new DateTime(2019, 9, 7));
            expected.Add(new DateTime(2019, 10, 5));
            expected.Add(new DateTime(2019, 11, 2));
            expected.Add(new DateTime(2019, 12, 7));

            Assert.AreEqual(expected, Kata.FindFirstSaturdayOfEachMonth(year));

        }
    }
}
