using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordWrapKata
{
   public  class WordWrap
    {
        public static String wrap(String text, int limit)
        {
            for(int index = 0; index < text.Length; index++)
            {
                if (Char.IsPunctuation(text[index]))
                {
                    return "Invalid input string has punctuation";
                }
            }
            
            return "no punctuations";
        }
    }
}
