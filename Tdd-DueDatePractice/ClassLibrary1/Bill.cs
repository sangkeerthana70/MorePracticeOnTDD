using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd_DueDatePractice
{
    public class Bill
    {
        HolidayService holidayService;
        public Bill(HolidayService hs)
        {
            this.holidayService = hs;
        }
        //bring in holiday service to check for holidays
        //use dependency injection
        public DateTime CheckDate(DateTime dueDate)
        {
            //throw new NotImplementedException();
            
           if(dueDate.DayOfWeek == DayOfWeek.Saturday)
           {
                return dueDate.AddDays(2);
           }
           if(dueDate.DayOfWeek == DayOfWeek.Sunday)
           {
                return dueDate.AddDays(1);
           }
           
            if(holidayService.isHoliday(dueDate))
            {
                if(dueDate.DayOfWeek == DayOfWeek.Friday)
                {
                    return dueDate.AddDays(3);
                }
                else
                {
                    return dueDate.AddDays(1);

                }
                
              
            }

            


            return dueDate;
            
            
        }
    }
}
