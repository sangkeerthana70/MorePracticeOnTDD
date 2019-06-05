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
            Console.WriteLine("strNum: " + strNum);
            List<int> numList = new List<int>();
            string number = "";
            
            for(int i = 0; i < strNum.Length; i++)
            {
                numList.Add(strNum[i]);
            }
            numList.Sort();
  
            numList.Reverse();
 
            foreach (char r in numList)
            {
                number += r;
            }
            return Convert.ToInt32(number);
            

        }

        public static UInt64 DescendingOrder(UInt64 num)
        {
            string strNum = num.ToString();
            Console.WriteLine("strNum: " + strNum);
            List<int> numList = new List<int>();
            string number = "";

            for (int i = 0; i < strNum.Length; i++)
            {
                numList.Add(strNum[i]);
            }
            numList.Sort();
            numList.Reverse();

            foreach (char r in numList)
            {
                number += r;
            }
            return Convert.ToUInt64(number);

        }
    }

}