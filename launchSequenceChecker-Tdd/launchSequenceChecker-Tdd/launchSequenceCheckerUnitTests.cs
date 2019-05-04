﻿using launchSequenceCheckerTdd;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launchSequenceChecker_Tdd
{
    public class launchSequenceCheckerUnitTests
    {
        [Test]
        public void checkIfEmptyArrayInputReturnsCorrectReturnDatatype()
        {
            string[] systemNames = new string[] {"" };
            int[] stepNumbers = new int[] { };
            checkLaunchSequence cLS = new checkLaunchSequence();
            
            var expected = cLS.launchSequenceChecker(systemNames, stepNumbers);
            Assert.AreEqual(expected, true);
        }

        [Test]
        public void checkIfDecreasingSequenceForASystemReturnsFalse()
        {
            string[] systemNames = new string[] { "stage_1", "stage_1" };
            int[] stepNumbers = new int[] { 5, 2 };
            checkLaunchSequence cLS = new checkLaunchSequence();

            var expected = cLS.launchSequenceChecker(systemNames, stepNumbers);
            Assert.AreEqual(expected, false);
        }

        [Test]
        public void checkIfIncreasingSequenceForASystemReturnsTrue()
        {
            string[] systemNames = new string[] { "stage_1", "stage_1" };
            int[] stepNumbers = new int[] { 1, 2 };
            checkLaunchSequence cLS = new checkLaunchSequence();

            var expected = cLS.launchSequenceChecker(systemNames, stepNumbers);
            Assert.AreEqual(expected, true);
        }

        [Test]
        public void checkForMultipleSystemAndDecreasingSequence()
        {
           
        }
    }
}
