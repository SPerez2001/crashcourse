using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class asynchclass
    {

        public static void MemeDialogue1()
        {
            
                List<string> dialogue = new List<string>() { ".", ".", ".", ".", "." };
                Console.WriteLine("You played in a movie called the hunger games?");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("i am isnt that your life story?");
                foreach (var ch in dialogue)
                {
                    Console.Write(ch + " ");
                    System.Threading.Thread.Sleep(400);

                }
                Console.WriteLine();

        }
        public static void MemeDialogue2()
        {
           
                Console.WriteLine("you shouldnt say that, thats off putting");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("you should be off pudding");
                List<string> dialogue = new List<string>() { ".", ".", ".", ".", "." };
                foreach (var ch in dialogue)
                {
                    Console.Write(ch + " ");
                    System.Threading.Thread.Sleep(400);

                }
            Console.WriteLine();
        }

        public static void MemeDialogue3()
        {
            
                Console.WriteLine("cause you're fat");
                System.Threading.Thread.Sleep(800);
                List<string> dialogue = new List<string>() { ".", ".", ".", ".", "." };
                foreach (var ch in dialogue)
                {
                    Console.Write(ch + " ");
                    System.Threading.Thread.Sleep(400);

                }
            Console.WriteLine();
        }
    }
}
