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
            long checkOutTime = 0;
            if(customers.Length == 0)
            {
                return 0;
            }

            if(n == 1)
            {
                for(int i = 0; i < customers.Length; i++)
                {
                    checkOutTime += customers[i];
                }
                
            }
            Console.WriteLine(checkOutTime);
            return checkOutTime;
        }
    }
}
