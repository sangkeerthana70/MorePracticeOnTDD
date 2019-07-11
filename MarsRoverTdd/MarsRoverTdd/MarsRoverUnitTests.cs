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
        Rover rover = new Rover(new int[] { 0, 0 }, 'e', new int[] { 100, 100 });

        [Test]
        public void a_Command_forward_fromEast_MovesRoverToZeroOneFromZeroZeroByAddingOneToYAxis()
        {
            
            string command = "f";
            int[] expectedLocation = new int[] { 0, 1};
            char expectedDirection = 'e';
            //rover.ResetLocation();
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();
            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }
        
        [Test]
        public void b_Command_backward_FromEast_MovesRoverBackWardsInReverseDirectionToZeroZeroFromZeroOne_SubtractingOneFromYAxis()
        {
            
            string command = "b";
            int[] expectedLocation = new int[] { 0, 0 };
            char expectedDirection = 'e';//moves backward from east but in reverse direction
            //rover.ResetLocation();
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();
            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }
        
        [Test]
        public void c_Command_forward_FromWest_MovesRoverForwardToZeroMinusOneFromZeroZero_SubtractingOneFromYAxis()
        {
            rover.direction = 'w';
            string command = "f";
            int[] expectedLocation = new int[] { 0, -1};
            char expectedDirection = 'w';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void d_Command_backward_FromWest_MovesRoverBackwardToZeroOneFromZeroMinusOne_AddingOneToYAxis()
        {
            //rover.direction = 'w';
            string command = "b";
            int[] expectedLocation = new int[] { 0, 0 };
            char expectedDirection = 'w';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void e_Command_forward_FromSouth_MovesRoverForward_AddingOneToXAxis()
        {
            rover.direction = 's';
            string command = "f";

            int[] expectedLocation = new int[] { 1, 0 };
            char expectedDirection = 's';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void f_Command_backward_FromSouth_MovesRoverBackward_SubtractingOneFromXAxis()
        {
            
            string command = "b";

            int[] expectedLocation = new int[] { 0, 0 };
            char expectedDirection = 's';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void g_Command_forward_FromNorth_MovesRoverForWard_SubtractingOneFromXAxis()
        {
            rover.direction = 'n';

            string command = "f";

            int[] expectedLocation = new int[] { -1, 0 };
            char expectedDirection = 'n';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);

        }

        [Test]
        public void h_Command_backward_FromNorth_MovesRoverBackWard_AddingOneToXAxis()
        {
            rover.direction = 'n';

            string command = "b";

            int[] expectedLocation = new int[] { 0, 0 };
            char expectedDirection = 'n';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);

        }
    }
}
