using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingZeroesToTheEnd
{
    public static class Kata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            // TODO: Program me
            List<int> tempList = new List<int>();

            int zerosCount = 0;
            

            if(arr.Length == 0)
                throw new ArgumentException();

            for(int index = 0; index < arr.Length; index++)
            {
                if(arr[index] != 0)
                {
                    tempList.Add(arr[index]);
                }
                else
                {
                    zerosCount += 1;
                }
            }
            Console.WriteLine("list count " + tempList.Count());
            Console.WriteLine("before adding zeros");
            foreach(int nonZero in tempList)
            {
                Console.WriteLine("nonZero " + nonZero);
            }

            int[] zeros = new int[zerosCount];
            for(int index = 0; index< zeros.Length; index++)
            {
                zeros[index] = 0;
            }
           
            
            tempList.AddRange(zeros);
            Console.WriteLine("after moving zeros");
            foreach(int num in tempList)
            {
                Console.WriteLine("num " + num);
            }
            return tempList.ToArray();
        }
    }
}
