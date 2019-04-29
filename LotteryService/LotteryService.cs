using System;

namespace LotteryService
{
    public class LotterNumers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
            Array.Sort(lotteryNums);
            return lotteryNums;
        }
    }
}
