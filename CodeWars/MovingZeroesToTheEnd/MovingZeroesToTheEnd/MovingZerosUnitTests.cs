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
        public void ArrayWithOneZero_MovesZeroToTheEnd()
        {
            int[] arr = new int[] { 1, 2, 0, 3, 4 };
            int[] expected = { 1, 2, 3, 4, 0 };
            int[] actual = Kata.MoveZeroes(arr);
            Console.WriteLine("actual " + String.Join("," ,actual));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArrayWithTwoZeros_MovesZeroToTheEnd()
        {
            int[] arr = new int[] { 5, 4, 0, 3, 0, 2 };
            int[] expected = { 5, 4, 3, 2, 0, 0};
            int[] actual = Kata.MoveZeroes(arr);
            Console.WriteLine("actual " + String.Join(",", actual));
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnyNumberOfZerosInTheMiddleOfArray_MovesZeroToTheEnd()
        {
            int[] arr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            int[] expected = { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
            int[] actual = Kata.MoveZeroes(arr);
            Console.WriteLine("actual " + String.Join(",", actual));
            Assert.AreEqual(expected, actual);
        }
    }
}
