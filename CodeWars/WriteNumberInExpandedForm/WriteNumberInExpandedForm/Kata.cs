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
            string numberStr = num.ToString();


            StringBuilder expandedForm = new StringBuilder();
            int strLength = numberStr.Length -1;

            for(int index = 0; index <= strLength; index++)
            {
                // if number has zeros in any place continue to next loop
                if (numberStr[index] == '0')
                    continue;
                   
                // if last element in string
                if (index == strLength)
                {
                    expandedForm.Append(numberStr[index]);
                }
                else
                {
                    expandedForm.Append(numberStr[index]).Append('0', strLength - index).Append(" + ");
                }
            }
            // remove the " + " space, plus and space at the end of string added at the ones place of the number
            return expandedForm.ToString().TrimEnd(' ').Trim('+').TrimEnd(' ');
           
        }
    }
}
