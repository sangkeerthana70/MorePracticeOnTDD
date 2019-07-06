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

            if(sentence.Length >= 5)
            {
                char[] charArray = sentence.ToCharArray();
                Console.WriteLine("charArray "+ String.Join(",", charArray));
                Array.Reverse(charArray);

                return new string(charArray);
            }

            return sentence;
        }
    }
}
