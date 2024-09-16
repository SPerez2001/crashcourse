using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class inheratanceoop
    {
        

        public class FirstPerson() 
        {
            public string name { get; set; }
            public string objectgone { get; set; }

            public string script { get; set; }

            public void introtomeme() 
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("1st Script: " + "My " + objectgone + " are gone");
                Console.WriteLine("Script: " + script);
            }

            public void aregone()
            {
                Console.WriteLine("Name: Kim Kardashian");
                Console.WriteLine("Answer: My " + objectgone + " are gone");
            }
        }
       
        public class SecondPerson : FirstPerson
        {
            public string questions { get; set; }

            public void questionscript() 
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Question : " + questions);
                aregone();
                Console.WriteLine("Script: " + script);
                
            }
        }

        public class ThirdPerson : SecondPerson 
        {
            public string statement { get; set; }

            public void statementscript() 
            {
                Console.WriteLine();
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Question : " + questions);
                aregone();
                Console.WriteLine("Statement: " + statement);
            }
        }

    }
    
}
