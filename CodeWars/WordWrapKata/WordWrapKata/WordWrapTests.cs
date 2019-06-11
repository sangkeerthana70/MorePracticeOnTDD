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
        [Test]
        public void CheckForInValidInputsAndThrowException()
        {
            string input = "Check for punctuation";
            int lineLimit = 7;
            string expected = "no punctuations";

            Assert.AreEqual(expected, WordWrap.wrap(input, lineLimit));
        }
    }
}
