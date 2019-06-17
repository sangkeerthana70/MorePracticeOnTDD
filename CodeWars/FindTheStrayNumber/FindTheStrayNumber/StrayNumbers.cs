using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheStrayNumber
{
    public class StrayNumbers
    {
        public static int Stray(int[] numbers)
        {
            
            int result = 0;
            IEnumerable<int> strayNumber = numbers.Distinct();
            //foreach (int num in numbers)
            //{
            //    result = num;
            //    Console.WriteLine("stray num " + num);
            //}
            for (int i = 0; i < numbers.Length -1; i++)
            {
                if(numbers[0] != numbers[1])
                {
                    result = numbers[0];
                    break;
                }

                if(numbers[i] != numbers[i + 1])
                {
                    //Console.WriteLine("unique: " + numbers[i+1]);
                    result = numbers[i+1];
                    break;
                }
                result = numbers[i];
            }
            return result;
            

        }
    }
   
}
