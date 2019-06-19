using NUnit.Framework;
using GreetingServices;


namespace GreetingKata
{
    [TestFixture]
    public class UnitTests
    {
        Greeting greeting = new Greeting();

        [Test]
        public void GreetASinglePersonByTheirName()
        {
            string name = "Bob";
            string expected = "Hello, Bob.";
            string actual = greeting.GreetName(name);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GreetNameShouldHandleNullIfNameIsNull()
        {
            string name = "";
            string expected = "Hello, my friend.";
            string actual = greeting.GreetName(name);
            Assert.AreEqual(expected, actual);
        }
    }
}
