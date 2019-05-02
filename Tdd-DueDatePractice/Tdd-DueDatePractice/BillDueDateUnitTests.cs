using NUnit.Framework;
using Tdd_DueDatePractice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_DueDatePractice
{
    public class Tests
    {
        [TestFixture]
        public class BillShould
        {
            [Test]
            public void ifBussinessDay_ReturnDueDate()
            {
                var input = new DateTime(2018, 8, 6);
                var mockHolidayService = new HolidayService ();
                var _bill = new Bill(mockHolidayService);
                var output = _bill.CheckDate(input);
                var expected = input;
                Assert.AreEqual(expected, output);
            }

            [Test]
            public void ifSaturday_ReturnMonday()
            {
                var input = new DateTime(2019, 5, 4);
                var mockHolidayService = new HolidayService();
                var _bill = new Bill(mockHolidayService);
                var output = _bill.CheckDate(input);
                var expected = new DateTime(2019, 5, 6);
                Assert.AreEqual(expected, output);

            }
            [Test]
            public void ifSunday_ReturnMonday()
            {
                var input = new DateTime(2019, 5, 5);
                var mockHolidayService = new HolidayService();
                var _bill = new Bill(mockHolidayService);
                var output = _bill.CheckDate(input);
                var expected = new DateTime(2019, 5, 6);
                Assert.AreEqual(expected, output);

            }
            [Test]
            public void ifHoliday_ReturnNonHoliday()
            {
                // input is friday expected output should be Monday
                var input = new DateTime(2018, 8, 3);
                var mockHolidayService = new HolidayService();
                var _bill = new Bill(mockHolidayService);
                var output = _bill.CheckDate(input);
                var expected = new DateTime(2018, 8, 6);
                Assert.AreEqual(expected, output);
            }
            
            [Test]
            public void ifHoliday_ReturnWeekday()
            {
                // input is a holiday on tuesday expect output the next day which is a weekday
                var input = new DateTime(2018, 12, 25);
                var mockHolidayService = new HolidayService();
                var _bill = new Bill(mockHolidayService);
                var output = _bill.CheckDate(input);
                var expected = new DateTime(2018, 12, 26);
                Assert.AreEqual(expected, output);
            }
            
        }
    }
}
