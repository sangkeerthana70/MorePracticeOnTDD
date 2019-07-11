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
            if(direction == 'e')
            {
                if (command == "f")
                {
                    Console.WriteLine("in east forward");
                    location[1] += 1;
                }

                if (command == "b")
                {
                    Console.WriteLine("in east backward");
                    location[1] -= 1;
                }
            }

            if(direction == 'w')
            {
                if (command == "f")
                {
                    location[1] -= 1;
                }

                if (command == "b")
                {
                    location[1] += 1;
                }
            }
            
            if(direction == 's')
            {
                if(command == "f")
                {
                    location[0] += 1;
                }

                if(command == "b")
                {
                    location[0] -= 1;
                }
            }

            if(direction == 'n')
            {
                if(command == "f")
                {
                    location[0] -= 1;
                }
                if(command == "b")
                {
                    location[0] += 1;
                }
            }
               
        }
        
        public void PrintStatus()
        {
            Console.WriteLine("I am facing " + direction);
            Console.WriteLine("my location is " + String.Join(",",location));
        }
        /*
        public void ResetLocation()
        {
            location[0] = 0;
            location[1] = 0;
        }
        */
    }
}
