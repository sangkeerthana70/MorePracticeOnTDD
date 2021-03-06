﻿using System;
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
            int currVal = 0;
            int nextVal = 0;
            int result = 0;

            if (romanNumeral == null)
                throw new ArgumentNullException();
            else if (romanNumeral == "")
                throw new ArgumentException();


            for (int i = 0; i < romanNumeral.Length; i++)
            {
                currVal = RomanToNumbers(romanNumeral[i]);
                result = currVal;
                Console.WriteLine("result " + result);
                if(i == romanNumeral.Length - 1)
                {
                    result += currVal;
                }
                else
                {
                    nextVal = RomanToNumbers(romanNumeral[i + 1]);
                    Console.WriteLine("nextVal: " + nextVal);
                    if (currVal > nextVal)
                    {                        
                        result += nextVal;
                        Console.WriteLine("result in currVal > nextVal: " + result);
                        i++;
                    }
                    else
                    {
                        result = currVal - nextVal;
                        Console.WriteLine("result in currVal < nextVal: " + result);
                    }
                }
                
                
            }
           return result;            
        }

        private int RomanToNumbers(char rNumeral)
        {
            int number = 0;

            switch (rNumeral)
            {
                case 'I':
                    number = 1;
                    break;

                case 'V':
                    number = 5;
                    break;
                case 'X':
                    number = 10;
                    break;
                case 'L':
                    number = 50;
                    break;
                case 'C':
                    number = 100;
                    break;
                case 'D':
                    number = 500;
                    break;
                case 'M':
                    number = 1000;
                    break;
                default:
                    number = 0;
                    break;
            }

            return number;

        }


    }
}
