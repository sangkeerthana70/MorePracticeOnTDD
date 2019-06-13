using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordWrapKata
{
   public  class WordWrap
   {
        public static String wrap(String text, int limit)
        {
            if(text == "")
            {
                return "";
            }

            if(text.Length <= limit)
            {
                return text;
            }

            if(text.Length > limit)
            {        
                //text.Replace(" ", Environment.NewLine);
 
                return System.Text.RegularExpressions.Regex.Replace(text, @"\s+", "\n");
                //return System.Text.RegularExpressions.Regex.Replace(text, @"\s+", Environment.NewLine);
            }

            Console.WriteLine("The final string: '{0}'", text);
            return text;

        }
   }
}
