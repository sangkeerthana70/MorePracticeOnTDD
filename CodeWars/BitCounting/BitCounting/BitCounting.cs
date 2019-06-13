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
            //string binary = Convert.ToString(n, 2);
            //Console.WriteLine("binary " + binary);

            if(n == 0)
            {
                return 0;
            }

            
            List<int> result = new List<int>();
            int quotient = n;
            int remainder = 0;
                
            while (quotient != 0)
            {
                // Continue dividing the quotient by 2 until you get a quotient of zero
                remainder = quotient % 2;
                Console.WriteLine("remainder: " + remainder);
                quotient = quotient / 2;
                result.Add(remainder);
            }
            Console.WriteLine("result: " + String.Join(",", result));
            int numOfOnes = 0;
            string binary = string.Empty;
            for (var i = 0; i < result.Count; i++)
            {
                // reverses the elements in result array
                binary += result[result.Count - 1 - i];
                Console.WriteLine("binary: " + binary);
            }
            return CheckConsecutiveOnes(binary);

        }

        private static int CheckConsecutiveOnes(string binary)
        {
            //binary = "11101111";
            //Console.WriteLine(binary);
            int count = 0;
            int maxCount = 0;

            for (var i = 0; i < binary.Length; i++)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("binary[i]: " + binary[i]);
                Console.WriteLine(binary[i].GetType());
                Console.WriteLine(binary[i] == '1');
                if (binary[i] == '1')
                {
                    count += 1;
                }
                // if(binary[i] == '0'
                else
                {
                    count = 0;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                }
                //Console.WriteLine("count: " + count);
                //Console.WriteLine("maxCount: " + maxCount);
            }

            //Console.WriteLine("count: " + maxCount);
            return maxCount;
        }
    }
}
