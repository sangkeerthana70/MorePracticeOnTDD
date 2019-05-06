using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launchSequenceCheckerTdd

{
    public class checkLaunchSequence
    {
        public bool launchSequenceChecker(string[] systemNames, int[] stepNumbers)
        {
            if(systemNames.Length == 0 && stepNumbers.Length == 0)
            {
                return true;
            }

            if(systemNames.Length != stepNumbers.Length)
            {
                throw new ArgumentException("the length of the input arrays are not equal");
               
            }
           
            

            for (int i = 0; i < stepNumbers.Length - 1; i++)
            {

                if (stepNumbers[i] > stepNumbers[i + 1])
                {
                    Console.WriteLine(stepNumbers[i]);
                    Console.WriteLine(stepNumbers[i+1]);
                    return false;
                }
            }
            return true;
        }

            
            
    }


}

