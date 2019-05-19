using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Library;

namespace Conway_sGameOfLifeTDD
{
    public class GameOfLifeRules
    {
        // Any live cell with fewer than two neighbors dies
        // Any live cell with two or three live neighbors lives
        // Any live cell with more than three neighbors dies
        // Any dead cell with exactly three live neighbors becomes a live cell

        [TestFixture]
        public class GameOfLifeRulesTests
        {
            [Test]
            public void Live_Cell_With_Fewer_Than_Two_Live_Neighbors_Dies()
            {
                // First rule
                // Any live cell with fewer than two neighbors dies

                // Arrange
                string currentState = "alive";
                int numberOfLiveNeighbors = 0;

                //Act
                string result = LifeRules.GetNewState(currentState, numberOfLiveNeighbors);

                //Assert
                Assert.AreEqual("dead", result);

            }

            [Test]
            [TestCase("alive", 2)]
            [TestCase("alive", 3)]
            public void Live_Cell_With_Two_Or_Three_Live_Neighbors_Lives(string currentState, int numberOfLiveNeighbors)
            {
                // Any live cell with two or three live neighbors lives
                // Arrange
                //string currentState = "";
                //int numberOfLiveNeighbors = 0;

                //Act
                string newState = LifeRules.GetNewState(currentState, numberOfLiveNeighbors);
                //Assert
                Assert.AreEqual("alive", newState);
            }
        }
    }
}
