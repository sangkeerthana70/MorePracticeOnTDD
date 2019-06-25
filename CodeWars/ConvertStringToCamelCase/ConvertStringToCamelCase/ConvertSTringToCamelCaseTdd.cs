using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertStringToCamelCase
{
    [TestFixture]
    public class ConvertSTringToCamelCaseTdd
    {
 
        [Test]
       
        public void InputOfDashDelimitedWords_ShouldRemoveDashesAndConvertToCamelCase()
        {
            string input = "the-stealth-warrior";
            string expected = "theStealthWarrior";

            string actual = Kata.ToCamelCase(input);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        public void InputOfUnderscoreDelimitedWords_ShouldRemoveDashesAndConvertToCamelCase()
        {
            string input = "the_rain_maker";
            string expected = "theRainMaker";

            string actual = Kata.ToCamelCase(input);
            Assert.AreEqual(expected, actual);
        }

       
        [Test]
        public void FirstWordIntheOutputShouldBeCapitalized_OnlyIfOriginalWordWasCapitalizedToPreservePascalCase()
        {
            Assert.AreEqual("ThreeMenInABoat", Kata.ToCamelCase("Three_Men_In_A_Boat"));
        }
    }
}
