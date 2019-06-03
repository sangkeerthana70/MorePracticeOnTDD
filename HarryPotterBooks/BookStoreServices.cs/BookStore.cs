using BookStoreServices.cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreServices
{
    public class BookStore: IBookStore
    {
        
        //int noOfBooks;
        //string bookTitle;
        
        public double BookCost(Dictionary<string, int> bookOrder)
        {

            int setCount = bookOrder.Values.Max();
            Console.WriteLine("setCount: " + setCount);

            int[] sets = new int[setCount];
            

            int copies = 0;
            foreach (KeyValuePair<string,int> order in bookOrder)
            {
                Console.WriteLine("Key value: " + order.Key + " " + order.Value);
                copies = order.Value;
                Console.WriteLine("no of copies of each book" + copies);
                for (int i = 0; i < copies; i ++)
                {
                    Console.WriteLine("i is: " + i);
                    sets[i] += 1;
                    Console.WriteLine("sets[i] " + sets[i]);
                    
                }
            }
            //Console.WriteLine("Total Book count of all books " + String.Join(",", sets));

            double cost = 0;
            double discount = 0;
            double costAfterDiscount = 0;
            int count = 0;
            for (int i = 0; i < setCount; i++)
            {
                Console.WriteLine("i in setCount");
                count = sets[i];
                Console.WriteLine("count : " + count);
                cost = count * 8;
                discount = Discount(count);
                costAfterDiscount += (cost - (cost * discount));
            }

            return costAfterDiscount;

        }


        private double Discount(int count)
        {
            if (count == 1)
            {
                return 0;
            }
            if (count == 2)
            {
                return 0.05;// 5%
            }
            if (count == 3)
            {
                return 0.1;//10%
            }
            if (count == 4)
            {
                return 0.2;//20%
            }
            if (count == 5)
            {
                return 0.25;// 25%
            }
            return 0;

        }

        /*
        public double BookCost(int noOfBooks, string[] titles)
        {
            //throw new NotImplementedException();
            double totalBookCost = 8;
            float discount = 0;
            float discountPrice = 0;

            if (noOfBooks == 1)
            {
                return totalBookCost;
            }
            if(noOfBooks == 2)
            {
                if (!(titles[0].Equals(titles[1])))
                {
                    discount = 5 ;
                    discountPrice = discount / 100;
                    Console.WriteLine("discountPrice: " + discountPrice);
                    totalBookCost = (2 * totalBookCost) - discountPrice;
                    Console.WriteLine("totalBookCost " + totalBookCost);
                    return Math.Floor(totalBookCost);

                }
                else
                    return (2 * totalBookCost);
            }
             return totalBookCost;
        }
        */
    }
}
