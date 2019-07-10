using MarsRover;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverTdd
{
    [TestFixture]
    public class MarsRoverUnitTests
    {
       
       
        [Test]
        public void Command_fMovesRoverToZeroOneFromZeroZero()
        {
            Rover rover = new Rover(new int[] { 0, 0 }, 'e', new int[] { 10,10});
            string command = "e";
            int[] expectedLocation = new int[] { 0, 1};
            char expectedDirection = 'e';
            rover.Move(command);

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

    }
}
