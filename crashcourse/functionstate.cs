using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class functionstate
    {
        public static void main() 
        {
            
            Console.WriteLine("How many memes do you want to know? Enter The number.");
            int answer = Int32.Parse(Console.ReadLine());
            int i = 0;
            string[] answers = new string[answer];
            while ( i < answer) 
            {
                Console.WriteLine(i);
                Console.WriteLine("Order Memes of all time to know the sources");
                Console.WriteLine("1. ANNITAMAXWIN");
                Console.WriteLine("2. UHMMM CHOW");
                Console.WriteLine("3. Kim theres people dying");
                Console.WriteLine("4. What is that?");
                Console.WriteLine("Enter the Number");
                string answer1 = Console.ReadLine();
                answers[i] = answer1;
                i++;
            }

            if (answer == 1)
            {
                grocery(answers[0]);
            }
            else if (answer == 2)
            {
                grocery(answers[0], answers[1]);
            }

        }
        static void grocery(string name1) 
        {
            if (name1 == "1") {
                Console.WriteLine("ANNITAMAXWIN is from drake when he lost all his money on his bbl");
            }
            else if (name1 == "2")
            {
                Console.WriteLine("UHMMM CHOW is from nicki minaj when she was on live on twitter");
            }
            else if (name1 == "3")
            {
                Console.WriteLine("Kim theres people dying is from kourtney when kim lost her ring on the beach");
            }
            else if (name1 == "4")
            {
                Console.WriteLine("What is that? is from cardi b when she was live and she saw something crawling on her wall");
            }
            
        }
        static void grocery(string name1, string name2)
        {
            if (name1 == "1" && name2 == "2")
            {
                Console.WriteLine("ANNITAMAXWIN is from drake when he lost all his money on his bbl");
                Console.WriteLine("UHMMM CHOW is from nicki minaj when she was on live on twitter");
            }
            else if (name1 == "2" && name2 == "3")
            {
                Console.WriteLine("UHMMM CHOW is from nicki minaj when she was on live on twitter");
                Console.WriteLine("Kim theres people dying is from kourtney when kim lost her ring on the beach");
            }
            else if (name1 == "3" && name2 == "4")
            {
                Console.WriteLine("Kim theres people dying is from kourtney when kim lost her ring on the beach");
                Console.WriteLine("What is that? is from cardi b when she was live and she saw something crawling on her wall");
            }
            else if (name1 == "4" && name2 == "1")
            {
                Console.WriteLine("What is that? is from cardi b when she was live and she saw something crawling on her wall");
                Console.WriteLine("ANNITAMAXWIN is from drake when he lost all his money on his bbl");
            }
        }
        
    }
}
