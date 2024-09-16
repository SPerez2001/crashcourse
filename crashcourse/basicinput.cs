using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class basicinput
    {
        public static void output()
        {
            Console.WriteLine("My name is ");
            string name = Console.ReadLine();
            Console.WriteLine("Age is ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("How much money do i have?");
            double money = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature on the Weather today?");
            float weather = float.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("My Name is " + name);
            Console.ReadKey();
            Console.WriteLine("Age is " + age );
            Console.ReadKey();
            Console.WriteLine("Total Money is " + money);
            Console.ReadKey();
            Console.WriteLine("Temperature for today " + weather);
            Console.ReadKey();
        }
    }
}
