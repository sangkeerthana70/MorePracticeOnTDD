using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingTermInArithmeticProgression
{
    public class Kata
    {
        public static int FindMissing(List<int> list)
        {
            //return list[0];

            int difference = list[1] - list[0];
            int missingNum = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i + 1] - list[i] == difference)
                {
                    continue;
                }
                else
                {                   
                    int newDifference = list[i + 1] - list[i];                  
                    missingNum = list[i] + (newDifference - difference); 
                }

            }
            return missingNum;
        }
    }
}
