using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class arraystate
    {
        public static void accessarray()
        {
            bool istrue = false;
            string question = "ANNITAMAXWIN";
            Console.WriteLine(question);
            Console.WriteLine("Enter the Number for your raffle to win your prize");
            int answer = Int32.Parse(Console.ReadLine());
            string[] maxwin = {"IJBOl",
            "A trip to the Backrooms",
            "Despair and Lonelyness",
            "Genshin Impact Money"}; 

            Console.WriteLine("This is your prize: ");
            Console.WriteLine(maxwin[answer]);
        }
    }
}
