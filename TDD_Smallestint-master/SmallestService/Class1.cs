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
                int minVal = Int32.MaxValue;                
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] < minVal)
                    {
                        minVal = input[i];
                    }

                }
                return minVal;
            }
            
            
        }

        public int FindClosestIntToZero(int[] input)
        {
            throw new NotImplementedException();

        }
    }
}
