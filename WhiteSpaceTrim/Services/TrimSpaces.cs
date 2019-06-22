using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services
{
    public class TrimSpaces
    {
        public static string CheckForWhiteSpace(string input)
        {
            
            if (input == null)
                throw new NullReferenceException();

            if (input == string.Empty)
                throw new ArgumentException();

            bool firstLetterFound = false;
            StringBuilder sb = new StringBuilder(input);

            for (int i = 0; i < sb.Length; i++)
            {
                if (firstLetterFound == false && (!char.IsWhiteSpace(sb[i])))
                {
                    firstLetterFound = true;
                }
                if (firstLetterFound && sb[i] == ' ' || sb[i] == '\t')
                {
                    sb[i] = 'x';
                }
            }

            return sb.Replace("x", "").ToString();

            /*
            char[] phraseAsChars = input.ToCharArray();
            int spaceIndex = input.IndexOf("   ");
            Console.WriteLine("space index: " + spaceIndex);
            if (spaceIndex != -1)
            {
                phraseAsChars[spaceIndex++] = ' ';
                phraseAsChars[spaceIndex++] = ' ';
                phraseAsChars[spaceIndex] = ' ';
            }

            string updatedPhrase = new string(phraseAsChars);
            Console.WriteLine("updatedPhrase: " + updatedPhrase);
            for(int i = 0; i < updatedPhrase.Length; i++)
            {
                if(updatedPhrase[i] == ' ')
                {                  
                    //updatedPhrase.Replace(" ", "");
                    
                }

                if (!char.IsWhiteSpace(updatedPhrase[i]))
                {
                
                    //get the last index of non white space character's index
                    int index = updatedPhrase.LastIndexOf(updatedPhrase[i]);
                    Console.WriteLine("index: " + index);
                    updatedPhrase.Substring(index + 1);
                    Console.WriteLine("substring: " + updatedPhrase);
                }
                
            }
 
            return updatedPhrase.TrimEnd();
            */

        }
    }
}
