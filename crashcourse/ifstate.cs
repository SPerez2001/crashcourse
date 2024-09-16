using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class ifstate
    {
        public static void elsestate()
        {
            Console.WriteLine("Do you think that she is going mad at every other hearing?");
            string answer = Console.ReadLine();

            if (answer == "true")
            {
                Console.WriteLine("Shimenet like my answer but boom badum boom boom i got that superbase");
            }
            else if (answer == "false")
            {
                Console.WriteLine("have you not seen the hearing? would u like to see the hearing? would u like to know where your money is heading");
            }
            else {
                Console.WriteLine("are u rich? cause u dont care enough where your money goes? hahahah");
            }
        }
    }
}
