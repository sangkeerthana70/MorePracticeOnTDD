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
            double cost = 0;
            double discount = 0;
            double costAfterDiscount = 0;

            foreach (KeyValuePair<string,int> order in bookOrder)
            {
                cost += order.Value * 8;
            }


            if (bookOrder.Count == 1)
            {
                discount = 0;
            }
            if (bookOrder.Count == 2)
            {
                discount = 0.05;// 5%
            }
            if (bookOrder.Count == 3)
            {
                discount = 0.1;//10%
            }
            if (bookOrder.Count == 4)
            {
                discount = 0.2;//20%
            }
            if (bookOrder.Count == 5)
            {
                discount = 0.25;// 25%
            }


            costAfterDiscount = cost - (cost * discount);


            return costAfterDiscount;

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
