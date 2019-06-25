﻿using NUnit.Framework;

using FractionSubtractionTddServices;

namespace UnitTests
{
    [TestFixture]
    public class KataTests
    {
        [Test]
        public void CheckIfBothDenominatorsAreTheSame_ReturnSubtractedFraction()
        {
            int[] firstFraction = { 3, 4 };
            int[] secondFraction = { 2, 4 };
            int[] result = { 1, 4 };

            var expected = result;
            var actual = FractionSubtraction.Subtract(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CheckIfBothDenominatorsAreSame_ReturnsSubtractedAndReducedFraction()
        {
            int[] firstFraction = { 8, 10 };
            int[] secondFraction = { 6, 10 };
            int[] result = { 1, 5 };

            var expected = result;
            var actual = FractionSubtraction.Subtract(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void CheckIfBothDenominatorsAredifferent_ReturnsSubtractedFraction()
        {
            int[] firstFraction = { 2, 5 };
            int[] secondFraction = { 1, 10 };
            int[] result = { 3, 10 };

            var expected = result;
            var actual = FractionSubtraction.Subtract(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void CheckIfBothDenominatorsAredifferent_ReturnsSubtractedReducedFraction()
        {
            int[] firstFraction = { 2, 4 };  //  {2*9/4*9}  = 18 / 36 
            int[] secondFraction = { 5, 9 }; //{ 5*4/9*4} = 20 / 36  == (18-20)/ 36 = -2 / 36 == -1 / 18
            int[] result = { -1, 18 };

            var expected = result;
            var actual = FractionSubtraction.Subtract(firstFraction, secondFraction);

            Assert.AreEqual(expected, actual);

        }
    }           
}
