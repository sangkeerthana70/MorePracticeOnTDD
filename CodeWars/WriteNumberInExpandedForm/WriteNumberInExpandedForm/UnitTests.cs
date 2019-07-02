using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumberInExpandedForm
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void InputOfOneDigitNumber_ReturnsNumberOfOnes()
        {
            Assert.That(Kata.ExpandedForm(1), Is.EqualTo("1"));
        }


        [Test]
        public void InputOfTwoDigitNumber_ReturnsNumberOfTensAndOnes()
        {
            Assert.That(Kata.ExpandedForm(12), Is.EqualTo("10 + 2"));
        }

        [Test]
        public void InputOfThreeDigitNumber_ReturnsNumberOfHundredsTensAndOnes()
        {
            Assert.That(Kata.ExpandedForm(125), Is.EqualTo("100 + 20 + 5"));
        }

        [Test]
        public void InputOfANumberGreaterThanThreeDigits_ReturnsExpectedOutput()
        {
            Assert.That(Kata.ExpandedForm(3479), Is.EqualTo("3000 + 400 + 70 + 9"));
        }
        [Test]
        public void IfLengthIsMoreThanThreeAndNoZeros_ReturnHundredsTensAndOnes()
        {
            //long number = 54213;
            string expected = "50000 + 4000 + 200 + 10 + 3";
            string actual = Kata.ExpandedForm(54213);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IfLengthIsMoreThanThreeAndHasZeros_ReturnHundredsTensAndOnes()
        {
            //long number = 54203;
            string expected = "50000 + 4000 + 200 + 3";
            string actual = Kata.ExpandedForm(54203);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void IfOnlyFirstDigitIsANumberNotEqualToZero_ReturnExpectedOutput()
        {
            //long number = 9000000;
            string expected = "9000000";
            string actual = Kata.ExpandedForm(9000000);
            Assert.AreEqual(expected, actual);
        }
        

    }
}
