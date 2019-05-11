using System;
using System.Linq;

namespace SmallestService
{
    public class Finder
    {
       

        public int FindSmallestInt(int[] input)
        {
            //throw new NotImplementedException();
            if(input.Length == 0)
            {
                throw new  System.ArgumentException("the array cannot be empty");
                
            }
            
            if(input.Length == 1)
            {
                return input[0];
            }

            int minVal = Int32.MaxValue;
            Console.WriteLine("minVal: " + minVal);
            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] < minVal)
                {
                    minVal = input[i];
                }

            }
            return minVal;
            
        }

        public int FindClosestIntToZero(int[] input)
        {
            throw new NotImplementedException();

        }
    }
}
