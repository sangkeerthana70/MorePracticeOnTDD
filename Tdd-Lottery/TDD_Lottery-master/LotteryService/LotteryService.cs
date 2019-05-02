using System;

namespace LotteryService
{
    public class LotterNumers
    {
        public int[] SortNumbers(int[] lotteryNums)
        {
            //throw new NotImplementedException();
            // Array.Sort(lotteryNums);
            int swapCounter = 0;
           for(int j = 0; j < lotteryNums.Length; j++)
           {
                int x = 0;
                for (int i = 0; i < lotteryNums.Length - 1; i++)
                {
                    if (lotteryNums[i] > lotteryNums[i + 1])
                    {
                        int temp = lotteryNums[i];
                        lotteryNums[i] = lotteryNums[i + 1];
                        lotteryNums[i + 1] = temp;
                        swapCounter += 1;
                        Console.WriteLine("swap counter: " + swapCounter);
                        x++;
                    }
                }
                Console.WriteLine("in " + x + " "+ String.Join(",", lotteryNums));
            }
           
           Console.WriteLine("out" + String.Join(",", lotteryNums));
            return lotteryNums;
        }
    }
}
