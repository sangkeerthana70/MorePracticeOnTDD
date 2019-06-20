using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHighestProfitWins
{
    public class MinMax
    {
        public static int[] minMax(int[] lst)
        {
            List<int> minAndMaxNum = new List<int>();
            minAndMaxNum.Add(lst.Min());
            
            minAndMaxNum.Add(lst.Max());

            foreach(int num in minAndMaxNum)
                Console.WriteLine("num: " + num);
            return minAndMaxNum.ToArray();
        }
    }
}
