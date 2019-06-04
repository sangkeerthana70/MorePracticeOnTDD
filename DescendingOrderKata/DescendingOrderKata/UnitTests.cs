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
            int input = 21445;
            //int expected = 54421;
            //int actual = Kata.DescendingOrder(input);
            Assert.AreEqual(54421, Kata.DescendingOrder(input));
        }
    }
}
