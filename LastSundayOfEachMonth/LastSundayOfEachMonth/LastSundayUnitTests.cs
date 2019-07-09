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
            expected.Add(new DateTime(2019,1,27));
            expected.Add(new DateTime(2019,2,24));
            expected.Add(new DateTime(2019,3,31));
            expected.Add(new DateTime(2019,4,28));
            expected.Add(new DateTime(2019,5,26));
            expected.Add(new DateTime(2019,6,30));
            expected.Add(new DateTime(2019,7,28));
            expected.Add(new DateTime(2019,8,25));
            expected.Add(new DateTime(2019,9,29));
            expected.Add(new DateTime(2019,10,27));
            expected.Add(new DateTime(2019,11,24));
            expected.Add(new DateTime(2019,12,29));

            var actual = LastSunday.Services.FindLastSundayOfEachMonth(2019);
            Assert.AreEqual(expected, actual);
            //Assert.AreEqual(System.Collections.ICollection expected, System.Collections.ICollection actual, string message);
        }

        
    }
}
