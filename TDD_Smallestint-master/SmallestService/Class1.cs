using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {


        public int FindSmallestInt(int[] input)
        {
            //throw new NotImplementedException();
            if (input.Length == 0)
            {
                throw new System.ArgumentException("the array cannot be empty");

            }

            else if (input.Length == 1)
            {
                return input[0];
            }

            else if (input.Length == 2)
            {
                if (input[0] < input[1])
                {
                    return input[0];
                }
                else return input[1];
            }
            else
            {
                int minVal = input[0];
                for(int i = 1; i < input.Length; i++)
                {
                    if(input[i] < minVal)
                    {
                        minVal = input[i];
                    }
                }
                return minVal;
            }
            
        }

        public int FindClosestIntToZero(int[] input)
        {
            //throw new NotImplementedException();
            if (input.Length == 0)
            {
                throw new ArgumentException("array cannot be empty");
            }
            else if (input.Length == 1)
                return 1;
            else if (input.Length == 2)
            {
                return (input[0] < input[1]) ? input[0] : input[1];
            }
            else
            {
                int maxVal = input[0];
                /*
                foreach(int num in input)
                {
                    if(num < maxVal)
                    {
                        maxVal = num;
                        Console.WriteLine("maxValue : " + maxVal);
                    }
                }
                */

                for (int i = 1; i < input.Length; i++)
                {
                    if(Math.Abs(input[i]) < Math.Abs(maxVal))
                    {
                        maxVal = input[i];
                    }

                    if((Math.Abs(input[i]) == Math.Abs(maxVal)) && (input[i] < maxVal))
                    {
                        maxVal = input[i];
                    }
                }
                return maxVal;
            }
            
        }
    }
}
