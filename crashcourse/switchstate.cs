using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class @switchstate
    {
        public static void casestate()
        {
            Console.WriteLine("What Does IJBOL mean?.");
            Console.WriteLine("1. its a korean word");
            Console.WriteLine("2. its a meme the genz would probably know");
            Console.WriteLine("3. It means I Just Burst Out Laughing");
            Console.WriteLine("Select your answer below.");
            string answer = Console.ReadLine();

            switch (answer) 
            {
                case "1":
                    Console.WriteLine("Sorry buddy but you're wrong");
                    break;
                case "2":
                    Console.WriteLine("Sorry buddy but you're wrong");
                    break;
                case "3":
                    Console.WriteLine("That is correct");
                    break;
            }
        }
    }
}
