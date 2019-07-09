using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstSaturdayOfEachMonth
{
    public class Kata
    {
        public static List<DateTime> FindFirstSaturdayOfEachMonth(int year)
        {
            List<DateTime> firstSaturdays = new List<DateTime>();
            DateTime firstDay = new DateTime(year, 1, 1);
            Console.WriteLine(firstDay);
            Console.WriteLine(firstDay.Date);
            Console.WriteLine(firstDay.DayOfWeek);
            Console.WriteLine(firstDay.Month);

            DateTime firstSaturday = firstDay;

            while(firstSaturday.DayOfWeek != DayOfWeek.Saturday)
            {
                firstSaturday = firstSaturday.AddDays(1);
            }

            DateTime currentSaturday = firstSaturday;
            firstSaturdays.Add(currentSaturday);
            Console.WriteLine(firstSaturday);
            Console.WriteLine("firstSaturday " + firstSaturday.DayOfWeek);

            DateTime previousSaturday;
            
            while(true)
            {
                previousSaturday = currentSaturday;
                Console.WriteLine("previousSaturday " + previousSaturday);

                currentSaturday = currentSaturday.AddDays(7);
                Console.WriteLine("currentSaturday " + currentSaturday);

                if (currentSaturday.Year != year)
                {
                    break;
                }

                if (previousSaturday.Month != currentSaturday.Month)
                {
                    firstSaturdays.Add(currentSaturday);
                }
            }
            

            foreach(var saturday in firstSaturdays)
            {
                Console.WriteLine("Saturday in Saturdays " + saturday);
            }

            return firstSaturdays;

        }
    }
}
