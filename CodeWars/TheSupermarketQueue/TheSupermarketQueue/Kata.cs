﻿using System;
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
            for (int i = 0; i < tills.Length; i++)
            {
                tills[i] = 0;
            }
           
            if (customers.Length == 0)
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
            
            int maxVal = Int32.MinValue;
            for (int i = 0; i < customers.Length; i++)
            {               
                int minVal = GetMinimumTillValue(tills);
    
                // get the minimum index value in till array to assign the next customer to the till array
                tills[minVal] += customers[i];
                //Console.WriteLine("till total " + tills[minVal]);
            }

            for (int i = 0; i < tills.Length; i++)
            {
                // return max checkout time of the customers
                if (tills[i] > maxVal)
                {
                    maxVal = tills[i];
                }

            }
            return maxVal;


        }

        public static int GetMinimumTillValue(int[] till)
        {
            int indexValue = 0;
            int minVal = Int32.MaxValue;
            

            for(int i = 0; i < till.Length; i++)
            {
                if(till[i] < minVal)
                {
                    minVal = till[i];
                    
                   // get the minimum index of the till array that has the lowest wait time
                    indexValue = i;
                    
                    
                }
            }
            Console.WriteLine("minval of till array " + minVal);
            Console.WriteLine("indexValue " + indexValue);
            return indexValue;
        }
    }
}
