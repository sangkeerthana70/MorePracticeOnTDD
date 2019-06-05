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
                Console.WriteLine("strNum type " + strNum[i].GetType());
                
                numList.Add(strNum[i]);
            }
            numList.Sort();
            foreach(char i in numList)
            {
                Console.WriteLine("char i " + i);
            }
            numList.Reverse();
            
            Console.WriteLine("number: " + number);

            foreach (char r in numList)
            {
                 Console.WriteLine("char r " + r.GetType()+ r);
                number += r;
                Console.WriteLine("result: " + number);
                
            }
            return Convert.ToInt32(number);
            

        }
    }

}