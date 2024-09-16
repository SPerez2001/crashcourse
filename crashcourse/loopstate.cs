using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class loopstate
    {
        public static void whilestate()
        {
            bool istrue = false;
            string question = "Did you survive the pandemic that started in 2019?";
            int i = 0;
            while (istrue == false) 
            {
                Console.WriteLine(question);
                string answer = Console.ReadLine();
                if (answer == "no")
                {
                    Console.WriteLine("I will ask u again");
                    i++;
                    if (i == 3) 
                    {
                        question = "Then who is answering this telepromter? Again Did you Survive it?";
                    }
                }
                else 
                {
                    istrue = true;
                    if (istrue == true)
                    {
                        break;
                    }
                }

                
            }
            Console.WriteLine("damn are u good bruh?");
        }
        public static void forloopstate()
        {
            bool istrue = false;
            string question = "How many Songs you wanna get recommended?";
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            string s1 = "ちゃんみな - NG";
            string s2 = "2WORLDS // Madge x VALORANT";
            string s3 = "Fire Again ft. Ashnikko";
            
            for (int i = 0; i < Int32.Parse(answer); i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(s1);
                    
                }
                else if (i == 1)
                {
                    Console.WriteLine(s2);
                }
                else if (i == 2)
                {
                    Console.WriteLine(s3);
                }
            }
            Console.WriteLine("These are great songs actually");
        }
    }
}
