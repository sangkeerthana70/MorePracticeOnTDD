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
            if(text.Length <= limit)
            {
                return text;
            }
            if(text.Length > limit)
            {
                //Regex.Replace(text, @" +", "\n");
                text.Replace(" ", "\n");
                
                return text;
            }

            Console.WriteLine("The final string: '{0}'", text);
            return text;

        }
   }
}
