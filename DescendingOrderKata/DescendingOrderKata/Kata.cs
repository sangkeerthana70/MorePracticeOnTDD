using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingOrderKata
{
    public static class Kata
    {
        public static int DescendingOrder(int num)
        {
            // Bust a move right here
            string strNum = num.ToString();
            List<int> numList = new List<int>();
            int number;
            int result = 0;
            for(int i = 0; i < strNum.Length; i++)
            {
                Console.WriteLine("strNum type " + strNum[i].GetType());
                
                numList.Add(strNum[i]);
            }
            numList.Sort();
            foreach(char i in numList)
            {
                Console.WriteLine("char i " + i);
            }
            numList.Reverse();
            Int32.TryParse(numList.ToString(), out number);
            Console.WriteLine("number: " + number);

            foreach (char r in numList)
            {
                 Console.WriteLine("char r " + r.GetType());
                result += r;
                
            }
            return result;


        }
    }

}