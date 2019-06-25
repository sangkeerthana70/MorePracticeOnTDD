using System;
using System.Collections.Generic;
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
            //string solution = string.Concat(str.Where(i => !new[] { '.', ' ', '-', '(', ')' }.Contains(i)));
            string solution1 = Regex.Replace(str, "-", "");

            Console.WriteLine("solution: " + solution1);
            return solution1;
        } 
    }
}
