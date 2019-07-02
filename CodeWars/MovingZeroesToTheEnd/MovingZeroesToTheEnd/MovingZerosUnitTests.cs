using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Write an algorithm that takes an array and moves all of the zeros to the end, 
 * preserving the order of the other elements.
*/ 

namespace MovingZeroesToTheEnd
{
    [TestFixture]
    public class MovingZerosUnitTests
    {
        [Test]
        public void IfArrayIsEmpty_ThrowException()
        {
            int[] input = new int[] { };

            Assert.Throws<System.ArgumentException>(() => Kata.MoveZeroes(input));
        }

        [Test]
        public void ArrayWithOneZeroWithOtherNumbers_MovesZeroToTheEnd()
        {
            int[] arr = new int[] { 1, 2, 0, 3, 4 };
            int[] expected = { 1, 2, 3, 4, 0 };
            int[] actual = Kata.MoveZeroes(arr);
            Console.WriteLine("actual " + String.Join("," ,actual));

            Assert.AreEqual(expected, actual);
        }
    }
}
