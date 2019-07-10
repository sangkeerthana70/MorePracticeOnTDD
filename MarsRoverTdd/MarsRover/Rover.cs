using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public int[] location = new int[2];
        public char direction;
        public int[] grid = new int[2];

        //public Rover()
        //{
        //}

        public Rover(int[] loc, char direction, int[] grid)
        {
            this.location = loc;
            this.direction = direction;
            this.grid = grid;
        }

        public void Move(string command)
        {
            if(command.Length == 1)
            {
                if (command == "e")
                {
                    location[1] += 1;
                }               
                Console.WriteLine("location " + String.Join(",", location));
            }
        }
    }
}
