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
        public void InputOfASingleRomanNumeralI_ReturnsOne()
        {
            string input = "I";
            Assert.AreEqual(1, numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void InputOfASingleRomanNumeralV_ReturnsFive()
        {
            string input = "V";
            Assert.AreEqual(5, numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void InputOfASingleRomanNumeralC_ReturnsOneHundred()
        {
            string input = "C";
            Assert.AreEqual(100, numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void InputOfTwoRomanNumeralsVI_ReturnsSix()
        {
            string input = "VI";
            Assert.AreEqual(6, numbers.ConvertRomanToNumbers(input));
        }

        [Test]
        public void InputOfThreeRomanNumeralsXIX_ReturnsExpectedOutput()
        {
            string input = "XIX";
            Assert.AreEqual(19, numbers.ConvertRomanToNumbers(input));
        }

        [Test]

        public void ReturnNumericValuesForStrings_MMXIX()
        {
            string romanNumeral = "MMXIX";
            //var expected = 2019;
            Assert.AreEqual(2019, numbers.ConvertRomanToNumbers(romanNumeral));

        }

        [Test]
        public void ReturnNumericValuesForMultipleStrings_MCMXLIV()
        {
            string romanNumeral = "MCMXLIV";           
            Assert.AreEqual(1944, numbers.ConvertRomanToNumbers(romanNumeral));
        }
    }
}
