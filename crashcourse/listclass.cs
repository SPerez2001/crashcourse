using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class listclass
    {
        public static void collectionslist()
        {
            bool runn = true;
            do
            {
                int j = 5;
                List<string> memes = new List<string>();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("List your top " +  j  + " popular memes you've seen this 2024?");
                    string meme = Console.ReadLine();
                    memes.Add(meme);
                    j--;
                }
                Console.WriteLine();
                foreach (string names in memes) 
                {

                    Console.WriteLine(names);
                    Console.WriteLine();
                    
                }
                runn = false;
            } while (runn == true);
        }
    }
}
