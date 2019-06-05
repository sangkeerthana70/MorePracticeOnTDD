using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrderKata
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void Test0()
        {
            int input = 0;
            Assert.AreEqual(0, Kata.DescendingOrder(input));
        }

        [Test]
        public void Test1()
        {
            int input = 21445;
            //int expected = 54421;
            //int actual = Kata.DescendingOrder(input);
            Assert.AreEqual(54421, Kata.DescendingOrder(input));
        }

        [Test]
        public void Test2()
        {
            int input = 145263;
            Assert.AreEqual(654321, Kata.DescendingOrder(input));
        }

        [Test]
        public void Test3()
        {
            UInt64 input = 1254859723;
            Assert.AreEqual(9875543221, Kata.DescendingOrder(input));
        }
    }
}
