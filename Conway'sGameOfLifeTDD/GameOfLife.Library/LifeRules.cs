using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Library
{
    public class LifeRules
    {
        

        public static string GetNewState(string currentState, int numLiveNeighbors)
        {
            string newState = "";
            if((currentState == "alive") && (numLiveNeighbors < 2))
            {
                newState = "dead";
            }
            return newState;
        }
    }
}
