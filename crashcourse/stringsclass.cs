using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    class stringsclass
    {
        public static void Main() 
        {
            string meme1 = "Today-    " + "What is that? ..." + "What is that?.....";
            Console.WriteLine(meme1);
            Console.WriteLine("Contains: " + meme1.Contains("What"));
            Console.WriteLine("string[]: " + meme1[2]);
            Console.WriteLine("Index Of: " + meme1.IndexOf("Today"));
            Console.WriteLine("Substring: " + meme1.Substring(10));
        }
    }
}
