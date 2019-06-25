using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertStringToCamelCase
{
    public class Kata
    {
        public static string ToCamelCase(string str)
        {
            /*
            //using String.Concat
            
            string solution = string.Concat(str.Where(i => !new[] { '.', ' ', '-', '&','(', ')' }.Contains(i)));
            
            // using Regex
            //string solution1 = Regex.Replace(str, "[-.()&_]+", "");
            */

            
            char[] delimiter = { '-', '_' };

            string[] words = str.Split(delimiter);




            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            string output = words[0];
            for (int i = 0; i < words.Length - 1; i++)
            {
                output += myTI.ToTitleCase(words[i + 1]);
                Console.WriteLine("\"{0}\" to titlecase: {1}", words[i + 1], myTI.ToTitleCase(words[i + 1]));
            }
            Console.WriteLine("output: " + output);
            return output;
        }


    }

}

