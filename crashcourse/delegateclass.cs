using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace crashcourse
{
    internal class delegateclass
    {
        public class PickedNum1
        {
            public int NumberP1 { get; set; }
            
        }
        public class PickedNum2
        {
            public int NumberP2 { get; set; }
        }

        public class  RadomNumberWinner 
        {
            public delegate void WinnerPickEventHandler(object source, EventArgs args);

            public event WinnerPickEventHandler WinnerPick;

            public void Random1(PickedNum1 winner1, PickedNum2 winner2)
            {
                Random rnd = new Random();
                int nump = rnd.Next(1, 10);
                int total1 = winner1.NumberP1 + nump;
                int total2 = winner2.NumberP2 + nump;
                Console.WriteLine("Your Total Number is = " + total1);
                Console.WriteLine("Your Total Number is = " + total2);
                if (total1 > total2)
                {
                    OnWinnerPick(total1);
                }
                else
                {
                    OnWinnerPick(total2);
                }

            }



            protected virtual void OnWinnerPick(int num)
            {
                WinnerPick?.Invoke(num, EventArgs.Empty);
            }
        }

        
    }
}
