using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class OOPbasics
    {
        

        public class classobj()
        {
            public string celebn;
            public string celebmeme;
            public string popularity;
        }

        public class oopconstructor
        {
            public string celebname;
            public string celebmemes;
            public string relevant;
            public oopconstructor(string celebname, string celebmemes, string relevant)
            {
                this.celebname = celebname;
                this.celebmemes = celebmemes;
                this.relevant = relevant;

                Console.WriteLine("Celebrity Name: " + celebname);
                Console.WriteLine("The Meme from this celebrity: " + celebmemes);
                Console.WriteLine("Is this person still relevant today: " + relevant);
            }
        }

        public class oopobjectmethod
        {
            public string celebname;
            public int stage1;
            public int stage2;
            public int champions2021;
            public oopobjectmethod(string celebname, int stage1, int stage2, int champions2021)
            {
                this.celebname = celebname;
                this.stage1 = stage1;
                this.stage2 = stage2;
                this.champions2021 = champions2021;

            }

            public void whoisthat() 
            {
                Console.WriteLine("Valorant Tournament Player: " + celebname);
            }

            public void winrate() 
            {
                int wins = stage1 + stage2 + champions2021;
                double percent = (double)wins / 13  * 100;
                Console.WriteLine("From Champions 2021 to Stage 2 VCT Challengers Their Winrate is = " + String.Format("{0:0.00}", percent) + " %");
            }
        }

    }
}
