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
        
        int noOfBooks;
        string bookTitle;
        

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
    }
}
