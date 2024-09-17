using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class exceptionclass
    {
        public static void exceptionhandling()
        {
            bool correctans = false;
            do
            {
                try
                {
                    Console.WriteLine("What sound do you make for a Lithuanian Cat go to you?.");
                    Console.WriteLine("1. Pishi-Pishi-Pishi");
                    Console.WriteLine("2. Stardenburden hardenbart");
                    Console.WriteLine("3. Nabia-Nabia-Nabia");
                    Console.WriteLine("4. Kats-Kats-Kats");
                    Console.WriteLine("Select your answer below.");
                    int answer = Int32.Parse(Console.ReadLine());

                    switch (answer)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Sorry But Thats for Persian Cats");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            Console.WriteLine("Sorry But Thats For German Cats");
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            Console.WriteLine("Sorry But Thats for Oppa(Korean) Cats");
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            Console.WriteLine("Correct!, you have now acquired a kitty through cat distribution system");
                            Console.WriteLine();
                            correctans = true;
                            break;
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
            } while (correctans == false);

            
        }
    }
}
