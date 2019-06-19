using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingServices
{
    public  class Greeting
    {
        public string GreetName(string name)
        {
            //if(name == "Bob")          
            //    return "Hello, Bob.";       

            if(name == null)
                return "Hello, my friend.";

            if (name == String.Empty)
                throw new ArgumentException("Input cannot be empty");

            if (name == name.ToUpper())
                return "HELLO " + name + "!";

            return "Hello" + ", " + name + ".";
        }

        public string GreetName(string[] names)
        {
 
            return "Hello, " + names[0] + " and " + names[1] + "!";
        }


    }
}
