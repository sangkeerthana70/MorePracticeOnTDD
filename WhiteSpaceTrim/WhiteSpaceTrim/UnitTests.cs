using NUnit.Framework;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteSpaceTrim
{
    [TestFixture]
    public class UnitTests
    {
        [Test]

        public void CheckIfAStringIsNull_ReturnException()
        {
            string input = null;
            Assert.Throws<System.NullReferenceException>(() => TrimSpaces.CheckForWhiteSpace(input));
        }

        [Test]

        public void CheckIfAStringIsEmpty_ReturnException()
        {
            string input = "";
            Assert.Throws<System.ArgumentException>(() => TrimSpaces.CheckForWhiteSpace(input));
        }

        [Test]
        
        public void CheckForNoWhitespace_InAString()
        {
            string input = "abc";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        
        public void RemoveWhiteSpacesAtEndOfString()
        {
            string input = "abc    ";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        
        public void KeepsWhitespaceAtBeginningOfString()// this test should retain white space at the beginning of a string
        {
            string input = "      abc    ";
            string expected = "      abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckForTabsAndRemoveThemFromString()// check for tabs and remove
        {
            string input = "abc\t ";
            string expected = "abc";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveWhiteSpaceAtTheEndOfSecondLine()// remove white space at the end of string
        {
            string input = "abc\r\n cd \r\n";
            string expected = "abc\r\ncd\r\n";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void InputOfNewLineInAString_ReturnsANewLine()// input returns a new line char
        {
            string input = "\r\n";
            string expected = "\r\n";
            var actual = TrimSpaces.CheckForWhiteSpace(input);
            Assert.AreEqual(expected, actual);
        }

    }
}
