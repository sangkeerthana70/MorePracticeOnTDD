using NUnit.Framework;
using RomanNumerals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    [TestFixture]
    public class UnitTests
    {
        ConvertRoman numbers = new ConvertRoman();
        [Test]
        public void CheckIfInputIsEmpty_ThrowsArgumentNullException()
        {
            string input = "";
            Assert.Throws<ArgumentException>(()=> numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void CheckIfInputIsNull_ThrowsArgumentNullException()
        {
            string input = null;
            Assert.Throws<ArgumentNullException>(() => numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void InputOfRomanNumeralI_ReturnsOne()
        {
            string input = "I";
            Assert.AreEqual(1, numbers.ConvertRomanToNumbers(input));
        }
    }
}
