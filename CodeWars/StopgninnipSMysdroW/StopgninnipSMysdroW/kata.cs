using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopgninnipSMysdroW
{
    public class kata
    {
        public static string SpinWords(string sentence)
        {
            if (sentence == string.Empty)
            {
                throw new System.ArgumentException();
            }

            if (sentence == null)
            {
                throw new System.NullReferenceException();
            }

            string[] words = sentence.Split(' ');
            Console.WriteLine("words " + string.Join(" ", words));

            string reversed = "";
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Length >= 5)
                {
                    char[] charArray = words[i].ToCharArray();
                    Array.Reverse(charArray);
                    reversed += new string(charArray) + " ";
                }
                else
                {
                    reversed += words[i] + " ";
                }
            }
            //return String.Join(" ", reversed);
            return reversed.TrimEnd();
        }
    }
}
