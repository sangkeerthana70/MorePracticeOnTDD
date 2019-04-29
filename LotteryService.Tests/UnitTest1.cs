using NUnit.Framework;
using LotteryService;

namespace Tests
{
    public class Tests
    {
        
        LotterNumers _testService = new LotterNumers();
        [Test]
        public void return_Array()
        {
            int[]lotteryNumbers0 = new int[0];
            var output = _testService.SortNumbers(lotteryNumbers0);
            Assert.AreEqual(new int[0],output);
        }

        [Test]
        public void return_OneNumSorted()
        {
            int[] lotteryNumberReturns1 = new int[1];
           
            int[] actual = _testService.SortNumbers(lotteryNumberReturns1);
            System.Console.WriteLine("actual: " + actual.ToString());
            Assert.AreEqual(new int[1], actual);
        }


        
        [Test]
        public void return_twoNumSorted()
        {
            int[] lotteryNumberReturnsTwoNumSorted = new int[2] { 8, 7 };
            
            int[] actual = _testService.SortNumbers(lotteryNumberReturnsTwoNumSorted);
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(new int[2] { 7, 8 }, actual);

        }
        
        [Test]
        public void return_threeNumSorted()
        {
            int[] lotteryNumberReturnsThreeNumSorted = new int[3] { 100 , 99 ,87 };

            int[] actual = _testService.SortNumbers(lotteryNumberReturnsThreeNumSorted);
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(new int[3] { 87, 99, 100}, actual);

        }
        /*
        [Test]
        public void return_tenNumSorted()
        {
            int[] lotteryNumberReturnsTenNumSorted = new int[10] { 100, 99, 87, 3, 6, 1, 2, 8, 20,10 };

            int[] actual = _testService.SortNumbers(lotteryNumberReturnsTenNumSorted);
            System.Console.WriteLine("actual: " + actual);
            Assert.AreEqual(new int[10] { 1, 2, 3, 6, 8, 10, 20, 87, 99, 100 }, actual);
        }
        */
    }
}