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
        public void GreetNameShouldHandleNullsIfInputIsNull()
        {
            string name = null;
            string expected = "Hello, my friend.";
            string actual = greeting.GreetName(name);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GreetNameShouldHandle_EmptyStringInput()
        {
            string name = "";

            Assert.Throws<System.ArgumentException>(() => greeting.GreetName(name));
        }

        [Test]
        public void GreetNameShouldHandle_UpperCaseStringInput()
        {
            string name = "JERRY";
            string expected = "HELLO JERRY!";
            string actual = greeting.GreetName(name);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GreetNameShouldHandle_TwoNamesAsInput()
        {
            string[] names = new string[] { "Jill", "Jane"};
            string expected = "Hello, Jill and Jane!";
            string actual = greeting.GreetName(names);
            Assert.AreEqual(expected, actual);
        }
    }
}
