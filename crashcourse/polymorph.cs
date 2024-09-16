using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class polymorph
    {
        public class Cat() 
        {
            virtual public void whatdoesthecatsay() 
            {
                Console.WriteLine("They are both the same");
            }
        }

        public class Cat1 : Cat 
        {
            override public void whatdoesthecatsay()
            {
                Console.WriteLine("Chipi Chipi Chapa Chapa");
            }   
        }

        public class Cat2 : Cat
        {
            override public void whatdoesthecatsay()
            {
                Console.WriteLine("Mr. Chief Face The Camera....");
            }"adasd"
        }
    }
}
