using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class abstractionclass
    {
        public abstract class Cats()
        {
            public abstract void whatdoesthecatsay();
            
        }

        public class Melon : Cats
        {
            override public void whatdoesthecatsay()
            {
                Console.WriteLine("Me Lon");
            }
        }

        public class French : Cats
        {
            override public void whatdoesthecatsay()
            {
                Console.WriteLine("Meow *french accent");
            }
        }
    }
}
