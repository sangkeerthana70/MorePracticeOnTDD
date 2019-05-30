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
            double totalBookCost = 8;
            //throw new NotImplementedException();
            if(noOfBooks == 1)
            {
                return totalBookCost;
            }
            if(noOfBooks == 2)
            {
                if (!(titles[0].Equals(titles[1])))
                {
                    float discount = 5 ;
                    float discountPrice = discount / 100;
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
