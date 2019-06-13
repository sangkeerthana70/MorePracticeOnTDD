using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrapKata
{
    [TestFixture]
    public class WordWrapTests
    {
        /*
        [Test]
        public void CheckForInValidInputsThrowsException()
        {
            string input = "Check for punctuation";
            int lineLimit = 7;
        }
        */
        [Test]
        public void InputOfEmptyString_ReturnsAEmptyString()
        {
            string input = "";
            int lineLimit = 0;
            string expected = "";
            Assert.AreEqual(expected, WordWrap.wrap(input, lineLimit));
        }

        [Test]
        public void InputsLengthLessThanTheLineLimit_InsertsLineBreakAfterTheWord()
        {
            string input = "Test";
            int lineLimit = 7;
            string expected = "Test";

            Assert.AreEqual(expected, WordWrap.wrap(input, lineLimit));
        }
        [Test]
        public void InputsLengthGreaterThanLineLimit_InsertsLineBreakAfterEachWord()
        {
            string input = "Hello World";
            int lineLimit = 7;
            string expected = "Hello\nWorld";

            Assert.AreEqual(expected, WordWrap.wrap(input, lineLimit));
        }

        [Test]
        public void InputsLengthGreaterThanLineLimitButDoesNotBreakTheWOrdAtTheEnd()
        {
            string input = "a lot of words for a single line";
            int lineLimit = 10;
            string expected = "a lot of\nwords for\na single\nline";

            Assert.AreEqual(expected, WordWrap.wrap(input, lineLimit));

        }

    }
}
