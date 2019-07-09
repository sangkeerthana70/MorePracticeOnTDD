using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSunday
{
    public class Services
    {
        
        public static List<DateTime> FindLastSundayOfEachMonth(int year)
        {
            List<DateTime> sundays = new List<DateTime>();

            Dictionary<int, DateTime> lastSundays = new Dictionary<int, DateTime>();
            // convert the input into a date time object
            DateTime firstDay = new DateTime(year, 1, 1);
            Console.WriteLine("firstDay " + firstDay);
            Console.WriteLine("firstDay.DayOfWeek " + firstDay.DayOfWeek);
            DateTime firstSunday = firstDay;
            while (firstSunday.DayOfWeek != DayOfWeek.Sunday)
            {
                firstSunday = firstSunday.AddDays(1);
                Console.WriteLine("Day of Week " + firstSunday.DayOfWeek);

            }

            DateTime date = firstSunday.Date;
            Console.WriteLine("year" + date);
            Console.WriteLine(firstSunday.Month);
            Console.WriteLine(firstSunday.Year);



            
            DateTime currentSunday = firstSunday;

            DateTime previousSunday; 

            while (true)
            {

                previousSunday = currentSunday;

                currentSunday = currentSunday.AddDays(7);
                // method-1 check each sunday with previous sunday(before adding 7 days) to get the last Sunday
                if (previousSunday.Month != currentSunday.Month)
                {
                    Console.WriteLine("adding to list");
                    sundays.Add(previousSunday);
                }


                if (currentSunday.Year != year)
                {
                    break;
                }

                // method-2 Create a Dictionary with month as Key and CurrentSunday as Value.
                // 
                if (lastSundays.ContainsKey(currentSunday.Month))
                {
                    //update Dictionary[key] = value;
                    lastSundays[currentSunday.Month] = currentSunday;  
                }
                else
                {
                    //add key and value
                    lastSundays.Add(currentSunday.Month, currentSunday);
                }
               

                Console.WriteLine("currentSunday " + currentSunday);
                Console.WriteLine("currentSunday year " + currentSunday.Year);
                Console.WriteLine("currentMonth " + currentSunday.Month);
                               
                Console.WriteLine("========================================================");

            }


          foreach(KeyValuePair <int, DateTime> item in lastSundays)
          {
                Console.WriteLine("Item " + item);
                //sundays.Add(item.Value);
          }
           return sundays;
        }
    }
}
