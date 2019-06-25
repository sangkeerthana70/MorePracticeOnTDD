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
        public void InputStringWithDashesInbetween_ShouldBeRemovedFromTheOutput()
        {
            string input = "the-Stealth-Warrior";
            string expected = "theStealthWarrior";

            string actual = Kata.ToCamelCase(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
