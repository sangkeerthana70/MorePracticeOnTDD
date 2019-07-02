using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNumberInExpandedForm
{
    public static class Kata
    {
        public static string ExpandedForm(long num)
        {
            string numToStr = num.ToString();
            
            /*
            if (numToStr.Length == 1)
                return numToStr;
            if (numToStr.Length == 2)
                return numToStr[0] + "0 + " + numToStr[1];
            if (numToStr.Length == 3)
                return numToStr[0] + "00 + " + numToStr[1] + "0 + " + numToStr[2];
            */

            StringBuilder expandedForm = new StringBuilder();
            int strLength = numToStr.Length -1;

            //if(numToStr.Length > 3)
            //{
                for(int index = 0; index <= strLength; index++)
                {
                    if (numToStr[index] == '0')
                        continue;
                   

                    if (index == strLength)
                    {
                        expandedForm.Append(numToStr[index]);
                    }
                    else
                    {
                        Console.WriteLine("index " + index);
                        expandedForm.Append(numToStr[index]).Append('0', strLength - index).Append(" + ");
                        Console.WriteLine("{0}", expandedForm);
                    }
                    
                    
                    
                }
            return expandedForm.ToString().TrimEnd(' ').Trim('+').TrimEnd(' ');
            //}


            //return numToStr;
        }
    }
}
