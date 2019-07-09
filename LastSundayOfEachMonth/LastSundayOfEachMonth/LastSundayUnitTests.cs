using NUnit.Framework;
using System;
using LastSunday;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundayOfEachMonth
{
    [TestFixture]
    public class LastSundayUnitTests
    {


        [Test]
        public void CheckIfInputOfAGivenYear_ReturnsCorrectOutput()
        {
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2019, 1, 27));
            expected.Add(new DateTime(2019, 2, 24));
            expected.Add(new DateTime(2019, 3, 31));
            expected.Add(new DateTime(2019, 4, 28));
            expected.Add(new DateTime(2019, 5, 26));
            expected.Add(new DateTime(2019, 6, 30));
            expected.Add(new DateTime(2019, 7, 28));
            expected.Add(new DateTime(2019, 8, 25));
            expected.Add(new DateTime(2019, 9, 29));
            expected.Add(new DateTime(2019, 10, 27));
            expected.Add(new DateTime(2019, 11, 24));
            expected.Add(new DateTime(2019, 12, 29));

            var actual = LastSunday.Services.FindLastSundayOfEachMonth(2019);
            Assert.AreEqual(expected, actual);
           
        }
        [Test]
        public void CheckIfInputOfLeapYear2020_ReturnsExpectedLastSundayOfFebruary()
        {
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2020,1,26));
            expected.Add(new DateTime(2020,2,23));//Returns expected last Sunday of February 2020-02-23?
            expected.Add(new DateTime(2020,3,29));
            expected.Add(new DateTime(2020,4,26));
            expected.Add(new DateTime(2020,5,31));
            expected.Add(new DateTime(2020,6,28));
            expected.Add(new DateTime(2020,7,26));
            expected.Add(new DateTime(2020,8,30));
            expected.Add(new DateTime(2020,9,27));
            expected.Add(new DateTime(2020,10,25));
            expected.Add(new DateTime(2020,11,29));
            expected.Add(new DateTime(2020,12,27));
            var actual = LastSunday.Services.FindLastSundayOfEachMonth(2020);
            Assert.AreEqual(expected, actual);

        }
        
        [Test]
        public void CheckIfInputOfLeapYear2032_ReturnsExpectedLastSundayOfFebruary()
        {
            List<DateTime> expected = new List<DateTime>();
            expected.Add(new DateTime(2032,1,25));
            expected.Add(new DateTime(2032,2,29));
            expected.Add(new DateTime(2032,3,28));
            expected.Add(new DateTime(2032,4,25));
            expected.Add(new DateTime(2032,5,30));
            expected.Add(new DateTime(2032,6,27));
            expected.Add(new DateTime(2032,7,25));
            expected.Add(new DateTime(2032,8,29));
            expected.Add(new DateTime(2032,9,26));
            expected.Add(new DateTime(2032,10,31));
            expected.Add(new DateTime(2032,11,28));
            expected.Add(new DateTime(2032,12,26));

            var actual = LastSunday.Services.FindLastSundayOfEachMonth(2032);
            Assert.AreEqual(expected, actual);

        }
        
    }
}
