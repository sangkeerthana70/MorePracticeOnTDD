using System;

namespace LotteryService
{
    public class LotterNumers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
           // Array.Sort(lotteryNums);
           for(int j = 0; j < lotteryNums.Length; j++)
           {
                for (int i = 0; i < lotteryNums.Length - 1; i++)
                {
                    if (lotteryNums[i] > lotteryNums[i + 1])
                    {
                        int temp = lotteryNums[i];
                        lotteryNums[i] = lotteryNums[i + 1];
                        lotteryNums[i + 1] = temp;
                    }
                }
                Console.WriteLine("in" + String.Join(",", lotteryNums));
            }
           
           Console.WriteLine("out" + String.Join(",", lotteryNums));
            return lotteryNums;
        }
    }
}
