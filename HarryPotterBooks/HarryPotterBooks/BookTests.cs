﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreServices;

namespace HarryPotterBooks
{
    /*
     * To try and encourage more sales of the 5 different Harry
    Potter books they sell, a bookshop has decided to offer
    discounts of multiple-book purchases.

    One copy of any of the five books costs 8 USD.

    If, however, you buy two different books, you get a 5%
    discount on those two books.

    If you buy 3 different books, you get a 10% discount.

    If you buy 4 different books, you get a 20% discount.

    If you go the whole hog, and buy all 5, you get a huge 25%
    discount.

    Note that if you buy, say, four books, of which 3 are
    different titles, you get a 10% discount on the 3 that
    form part of a set, but the fourth book still costs 8 USD.

    Your mission is to write a piece of code to calculate the
    price of any conceivable shopping basket (containing only
    Harry Potter books), giving as big a discount as possible.

    For example, how much does this basket of books cost?

    2 copies of the first book
    2 copies of the second book
    2 copies of the third book
    1 copy of the fourth book
    1 copy of the fifth book

    Answer: 51.60 USD

    */

    [TestFixture]
    public class BookTests
    {
        

        [Test]
        public void CostOfOneBookReturnsDollar8()
        {
            int numberOfBooks = 1;
            string[] bookTitles = new string[] { };
            double expected = 8;
            var BookStore = new BookStore();
            var actual = BookStore.BookCost(numberOfBooks, bookTitles);
            Assert.AreEqual(expected, actual);

                    
        }

        [Test]
        public void CostOfTwoBookWithDifferentTitleNames_ShouldDiscount_5Percent()
        {
            int numberOfBooks = 2;
            string[] bookTitle = new string[2] {"Sorcerer's stone", "Chamber Of Secrets"};

            double expected = 15;
            var BookStore = new BookStore();
            
            double actual = BookStore.BookCost(numberOfBooks, bookTitle);
            Console.WriteLine("actual: " + actual);
            Assert.AreEqual(expected, actual);
        }


    }
}
