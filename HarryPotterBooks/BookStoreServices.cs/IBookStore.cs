using System.Collections.Generic;


namespace BookStoreServices.cs
{
    public interface IBookStore
    {
        //double BookCost(int number, string[] titles);
        double BookCost(Dictionary<string, int> bookOrder);
    }
}