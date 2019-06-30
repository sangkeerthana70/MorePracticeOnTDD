using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSupermarketQueue
{
    class Kata
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] tills = new int[n];
            long checkOutTime = 0;
            if(customers.Length == 0)
            {
                return 0;
            }

            /*
            if(n == 1)
            {
                for(int i = 0; i < customers.Length; i++)
                {
                    checkOutTime += customers[i];
                }
                
            }
            Console.WriteLine(checkOutTime);
            return checkOutTime;
            */
            int maxCheckOutTime = 0;
            for(int i = 0; i < customers.Length -1; i++)
            {
                if(i < n)
                {
                    tills[i] = customers[i];
                    maxCheckOutTime += customers[i];
                    Console.WriteLine("maxTime " + maxCheckOutTime);
                }
                if(i > n)
                {
                    int minVal = GetMinimumTillValue(tills);
                    Console.WriteLine("element in tills: " + String.Join(",", tills));
                    Console.WriteLine("minVal " + minVal);
                    tills[minVal] = customers[i];
                    maxCheckOutTime += customers[i];
                    Console.WriteLine("maxTime " + maxCheckOutTime);
                }
            }
            return maxCheckOutTime;
        }

        public static int GetMinimumTillValue(int[] till)
        {
            int indexValue = 0;
            int minVal = Int32.MaxValue;
            int minIndexValue = Int32.MaxValue;

            for(int i = 0; i < till.Length; i++)
            {
                if(till[i] < minVal)
                {
                    minVal = till[i];
                    Console.WriteLine("minval of till array " + minVal);
                    indexValue = i;
                    
                    Console.WriteLine("indexValue " + indexValue);
                }
            }
            return indexValue;
        }
    }
}
