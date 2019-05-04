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
            //throw new NotImplementedException();
            for(int i  = 0; i < stepNumbers.Length -1; i++)
            {
                if(stepNumbers[i] > stepNumbers[i + 1])
                {
                    return false;
                }
            }
            return true;
            
        }


    }
}
