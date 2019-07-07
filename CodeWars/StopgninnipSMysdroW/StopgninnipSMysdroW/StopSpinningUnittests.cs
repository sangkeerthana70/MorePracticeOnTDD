using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopgninnipSMysdroW
{
    /*
     * Write a function that takes in a string of one or more words, 
     * and returns the same string, but with all five or more letter words
     * reversed (Just like the name of this Kata). Strings passed in will
     * consist of only letters and spaces. Spaces will be included only 
     * when more than one word is present.
     * 
     * */

     
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

        [Test]
        public static void InputStringWithLessThanFiveWords_ReturnsTheSameStringWithoutReversing()
        {
            Assert.AreEqual("This is a test", kata.SpinWords("This is a test"));
        }

        [Test]
        public static void MixOfWordsOfDefferentLengths_ReturnsExpectedOutput()
        {
            Assert.AreEqual("Hey wollef sroirraw", kata.SpinWords("Hey fellow warriors"));
        }

        [Test]
        public static void Test4()
        {
            Assert.AreEqual("This is rehtona test", kata.SpinWords("This is another test"));
        }

        [Test]
        public static void Test5()
        {
            Assert.AreEqual("You are tsomla to the last test", kata.SpinWords("You are almost to the last test"));
        }

        [Test]
        public static void Test6()
        {
            Assert.AreEqual("Just gniddik ereht is llits one more", kata.SpinWords("Just kidding there is still one more"));
        }

    }
}
