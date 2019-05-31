using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;

namespace FindTheOddInt
{
    public class UnitTests
    {
         

        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void Tests()
            {

                Assert.AreEqual(5, Kata.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            }
        }

    }

    
}
