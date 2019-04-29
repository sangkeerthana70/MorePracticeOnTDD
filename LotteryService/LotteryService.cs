using System;

namespace LotteryService
{
    public class LotterNumers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
           // Array.Sort(lotteryNums);
           for(int i = 0; i < lotteryNums.Length-1; i++)
           {
                if(lotteryNums[i] > lotteryNums[i + 1])
                {
                    int temp = lotteryNums[i];
                    lotteryNums[i] = lotteryNums[i + 1];
                    lotteryNums[i + 1] = temp;
                }
           }
            return lotteryNums;
        }
    }
}
