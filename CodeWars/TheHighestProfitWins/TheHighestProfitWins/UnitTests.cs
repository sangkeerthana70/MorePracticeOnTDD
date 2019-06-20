using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHighestProfitWins
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public static void CheckIfInputGives_ExpectedOutput()
        {
            Assert.AreEqual(new int[] {1, 1}, MinMax.minMax(new int[] {1}));
        }

        [Test]
        public static void CheckMinAndMaxFor_TwoGivenELementsInArray()
        {
            Assert.AreEqual(new int[] { 5, 2334454 }, MinMax.minMax(new int[] { 2334454, 5 }));

        }


        [Test]
        public static void CheckMinAndMaxFor_MoreThanTwoElements()
        {
            Assert.AreEqual(new int[] { -1, 20 }, MinMax.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
        }
        
        [Test]
        public static void CheckMinAndMax_ForBiggerArrays()
        {
            Assert.AreEqual(new int[] { -3, 500 }, MinMax.minMax(new int[] { 487, 346, 299, 144, 1, 2, 5, 1, 12, 20, 67, 85, -3, 98, 57, 66, 500, 43, 39, 26, 11, 17 }));
        }
    }
}
