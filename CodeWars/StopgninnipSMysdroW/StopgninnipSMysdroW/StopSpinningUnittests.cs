using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopgninnipSMysdroW
{
    [TestFixture]
    public class StopSpinningUnittests
    {
       
        [Test]
        public void CheckIfInputString_IsEmpty()
        {
            string input = "";
            Assert.Throws <ArgumentException>(() => kata.SpinWords(input));
        }

        [Test]
        public void CheckIfInputString_IsNull()
        {
            string input = null;
            Assert.Throws<System.NullReferenceException>(() => kata.SpinWords(input));
        }

        [Test]
        public void InputOfOneWordWithFiveOrMoreLetter_ReversesTheWord()
        {
            string input = "Welcome";
            string expected = "emocleW";
            string actual = kata.SpinWords(input);
            Console.WriteLine("actual " + actual);
            Assert.AreEqual(expected, actual);
        }


    }
}
