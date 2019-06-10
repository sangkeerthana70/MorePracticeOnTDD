using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetCalculatorKata
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void CheckIfInputHasAStartTimeAndAnEndTime()
        {
            float startTime = 08.00f;
            float endTime = 16.00f;
            float breakTime = 0f;

            var expected = 8.00f;

            var actual = TimeSheetCalculator.CalculateTime(startTime, breakTime, endTime);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SwitchTheOrderOfInputShouldReturnCorrectResult()
        {
            float startTime = 16.00f;
            float endTime = 8.00f;
            float breakTime = 0f;

            var expected = 8.00f;

            var actual = TimeSheetCalculator.CalculateTime(startTime, breakTime, endTime);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReturnCorrectResultIfThereIsABreakTime()
        {
            float startTime = 07.02f;
            float endTime = 16.22f;
            float breakTime = 0f;

            var expected = 9.20f;

            var actual = TimeSheetCalculator.CalculateTime(startTime, breakTime ,endTime);
            Assert.AreEqual(expected, actual);
        }
    }
}
