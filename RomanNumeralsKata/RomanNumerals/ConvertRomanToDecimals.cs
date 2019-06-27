using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class ConvertRoman
    {
        public int ConvertRomanToNumbers(string romanNumeral)
        {
            if (romanNumeral == null)
                throw new ArgumentNullException();
            else if (romanNumeral == "")
                throw new ArgumentException();
            int n = RomanToNumbers(romanNumeral);
            Console.WriteLine("n : " + n);
            return n;
            
            
        }

        private int RomanToNumbers(string rNumeral)
        {
            int number = 0;

            switch (rNumeral)
            {
                case "I":
                    number = 1;
                    break;

                case "V":
                    number = 5;
                    break;
                case "X":
                    number = 10;
                    break;
                case "L":
                    number = 50;
                    break;
                case "C":
                    number = 100;
                    break;
                case "D":
                    number = 500;
                    break;
                case "M":
                    number = 1000;
                    break;
            }

            return number;

        }


    }
}
