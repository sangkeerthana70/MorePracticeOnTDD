using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSundayOfEachMonth
{
    public class Kata
    {
        public static List<DateTime> FindFirstMondayOfMonth(int year)
        {
            List<DateTime> firstMondays = new List<DateTime>();
            // convert the input into a date time object
            DateTime firstDay = new DateTime(year, 1, 1);
            Console.WriteLine("date " + firstDay);
            Console.WriteLine("firstDay.DayOfWeek " + firstDay.DayOfWeek);

            DateTime firstMonday = firstDay;
            // add daysuntil we get first Monday
            while(firstMonday.DayOfWeek != DayOfWeek.Monday)
            {
                firstMonday = firstMonday.AddDays(1);
               
                Console.WriteLine("firstMonday " + firstMonday);
            }

            DateTime date = firstMonday.Date;
            Console.WriteLine("firstMonday.Date " + date);
            

            DateTime currentMonday = firstMonday;
            firstMondays.Add(currentMonday);
            
            DateTime previousMonday;
            // add all mondays in a year until the year changes to next year
            while (true)
            {
                previousMonday = currentMonday;
                Console.WriteLine("previousMonday " + previousMonday);

                currentMonday = currentMonday.AddDays(7);
                Console.WriteLine("currentMonday " + currentMonday);
                if (currentMonday.Year != year)
                {
                    break;
                }
                // if there is difference in month then add the mondays to the list
                if (previousMonday.Month != currentMonday.Month)
                {
                    
                    firstMondays.Add(currentMonday);
                }

                
            }

            foreach(var monday in firstMondays)
            {
                Console.WriteLine("monday " + monday);
            }
            return firstMondays;
        }
    }
}
