using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class operators
    {
        public static void expressions()
        {
            Console.WriteLine("Vacation Starter Pack for 10 pax");
            Console.WriteLine("StayCation House w/ Pool : ");
            int wpool = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Drinks : ");
            double dr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fresh Foods for 3 days : ");
            double food = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fruits : ");
            int fruits = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Liquor : ");
            double liq = Convert.ToDouble(Console.ReadLine());

            double summary  =  wpool + dr + food + fruits + liq;
            double sum = summary;
            Console.WriteLine("The Total Summary of expenses for the Vacation : " + sum);
            Console.WriteLine();
            double div = summary / 10;
            Console.WriteLine("The result for the total summary divided by 10 people " + div);
        }
    }
}
