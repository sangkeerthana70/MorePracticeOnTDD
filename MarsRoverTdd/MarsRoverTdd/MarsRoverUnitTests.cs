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

        [Test]// Tests to change location
        public void a_Command_forward_fromEast_MovesRoverAddingOneToYAxis()
        {

            string command = "f";
            int[] expectedLocation = new int[] { 0, 1 };
            char expectedDirection = 'e';
            //rover.ResetLocation();
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();
            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void b_Command_backward_FromEast_MovesRoverBackWardsInReverseDirectionSubtractingOneFromYAxis()
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
        public void c_Command_forward_FromWest_MovesRoverForwardSubtractingOneFromYAxis()
        {
            rover.direction = 'w';
            string command = "f";
            int[] expectedLocation = new int[] { 0, -1 };
            char expectedDirection = 'w';
            rover.PrintStatus();
            rover.Move(command);
            rover.PrintStatus();

            Assert.AreEqual(expectedLocation, rover.location);
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void d_Command_backward_FromWest_MovesRoverBackwardAddingOneToYAxis()
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

        [Test] // tests to change direction of Rover
        public void i1_CommandLeft_ChangesDirectionFrom_East_ToNorth()
        {
            rover.direction = 'e';// reset direction from above test case's direction
            string command = "l";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 'n';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void i2_CommandRight_ChangesDirectionFrom_East_ToSouth()
        {
            rover.direction = 'e';
            string command = "r";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 's';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void j1_CommandLeft_ChangesDirectionFrom_West_ToSouth()
        {
            rover.direction = 'w';
            string command = "l";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 's';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void j2_CommandRight_ChangesDirectionFrom_West_ToNorth()
        {
            rover.direction = 'w';
            string command = "r";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 'n';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void k1_CommandLeft_ChangesDirectionFrom_North_ToWest()
        {
            rover.direction = 'n';
            string command = "l";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 'w';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]
        public void k2_CommandRight_ChangesDirectionFrom_North_ToEast()
        {
            rover.direction = 'n';
            string command = "r";
            rover.PrintStatus();
            rover.ChangeDirection(command);
            rover.PrintStatus();
            char expectedDirection = 'e';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]

        public void l1_CommandLeft_ChangesDirectionFrom_South_ToEast()
        {
            rover.direction = 's';
            string command = "l";
            rover.ChangeDirection(command);

            char expectedDirection = 'e';
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]

        public void l2_CommandRight_ChangesDirectionFrom_South_ToWest()
        {
            rover.direction = 's';
            string command = "r";
            rover.ChangeDirection(command);
            char expectedDirection = 'w';
            
            Assert.AreEqual(expectedDirection, rover.direction);
        }

        [Test]// EX-1 Testing rover movement using example in kata
        public void m_RoverPositionZeroZero_FacingSouth_Commandsfflff_MovesRoverToTwoTwo()
        {
            rover.direction = 's';
            string commands = "fflff";
            rover.PrintStatus();
            rover.OperateCommands(commands);
            rover.PrintStatus();

            int[] expectedLocation = new int[] { 2, 2 };
            Assert.AreEqual(expectedLocation, rover.location);
        }

        [Test]// Ex-2
        public void n_RoverPositionTwoTwo_FacingEast_Commandsffrff_MovesRoverToTwoTwo()
        {
            rover.direction = 'e';
            string commands = "ffrff";
            rover.PrintStatus();
            rover.OperateCommands(commands);
            rover.PrintStatus();

            int[] expectedLocation = new int[] { 4, 4 };
            Assert.AreEqual(expectedLocation, rover.location);
        }

        [Test]// Ex-3
        public void o_RoverPosition_FacingSouth_Commandsrffffffffff_MovesRoverToDesiredPosition()
        {
            string commands = "rffffffffff";
            rover.PrintStatus();
            rover.OperateCommands(commands);
            rover.PrintStatus();

            int [] expectedLocation = new int[] { 4, -6};
            Assert.AreEqual(expectedLocation, rover.location);
        }
    }
}
