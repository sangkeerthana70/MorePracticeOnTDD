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
            DateTime firstDay = new DateTime(year, 1, 1);
            Console.WriteLine("date " + firstDay);
            Console.WriteLine("firstDay.DayOfWeek " + firstDay.DayOfWeek);

            DateTime firstMonday = firstDay;
            while(firstMonday.DayOfWeek != DayOfWeek.Monday)
            {
                firstMonday = firstMonday.AddDays(1);
               
                Console.WriteLine("firstMonday " + firstMonday);
            }

            DateTime date = firstMonday.Date;
            int firstMondayMonth = firstMonday.Month;
            int currentYear = firstMonday.Year;

            DateTime currentMonday = firstMonday;
            firstMondays.Add(currentMonday);
            
            DateTime previousMonday;

            while (true)
            {
                previousMonday = currentMonday;

                currentMonday = currentMonday.AddDays(7);
                if (currentMonday.Year != year)
                {
                    break;
                }

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
