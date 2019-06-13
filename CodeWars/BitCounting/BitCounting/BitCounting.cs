using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCounting
{
    public class BitCounting
    {
        public static int countBits(int n)
        {
            //throw new NotImplementedException();
            if (n == 0)
            {
                return 0;
            }
            // Convert the number t0 a string given a base of 2 which represents a binary
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("binary " + binary);
            return CheckConsecutiveOnes(binary);
        }

        private static int CheckConsecutiveOnes(string binary)
        {
            int count = 0;
            for (var i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
