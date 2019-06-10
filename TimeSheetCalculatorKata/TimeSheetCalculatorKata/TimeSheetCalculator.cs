using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetCalculatorKata
{
    class TimeSheetCalculator
    {
        public static float CalculateTime(float start, float breakTime, float end)
        {
            if(start != null && end!= null)
            {
                if(end > start)
                {
                    if (breakTime != 0)
                    {
                        return (end - start - breakTime) - 0.40f;
                    }
                   
                    return (end - start - breakTime);
                }
                else
                {
                    if (breakTime != 0)
                    {
                        return ( start - end - breakTime) - 0.40f;
                    }

                    return (start - end - breakTime) ;
                }
            }

            throw new ArgumentException("input was not in correct format");
        }
    }
}
