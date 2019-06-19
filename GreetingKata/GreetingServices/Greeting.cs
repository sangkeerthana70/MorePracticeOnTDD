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
            if(name == "Bob")
            {
                return "Hello, Bob.";
            }

            if(name == null)
            {
                return "Hello, my friend.";

            }

            return name;
        }


    }
}
