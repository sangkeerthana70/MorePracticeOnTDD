using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheOddInt
{
    class Kata
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> numberDict = new Dictionary<int, int>();
            int result = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                if (numberDict.ContainsKey(seq[i]))
                {
                    numberDict[seq[i]] += 1;
                }
                else
                {
                    numberDict.Add(seq[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> numSeq in numberDict)
            {
                if (numSeq.Value % 3 == 0)
                {
                    result = numSeq.Key;
                    Console.WriteLine("result " + result);
                }
            }
            return result;
        }

    }
}
