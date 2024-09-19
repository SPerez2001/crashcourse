using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crashcourse
{
    internal class Lesson20
    {
        public static void finalproj() 
        {
            bool prj = false;
            while (prj == false) 
            {
                try
                {
                    Console.WriteLine("Active Lessons While Running this Project: Lessons {1, 2, 3, 4, 5, 6, 7, 15");
                    Console.WriteLine("Lesson for today: ");
                    Console.WriteLine("8. Arrays");
                    Console.WriteLine("9. Functions");
                    Console.WriteLine("10. OOP");
                    Console.WriteLine("11. Inheritance");
                    Console.WriteLine("12. Encapsulation");
                    Console.WriteLine("13. Polymorphism");
                    Console.WriteLine("14. Abstraction");
                    Console.WriteLine("16. Collections");
                    Console.WriteLine("17. Delegates and Events");
                    Console.WriteLine("18. Asynchronous");
                    Console.WriteLine("19. Working with String");
                    Console.WriteLine("20. Exit");
                    int num = Int32.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 8:
                            Console.WriteLine();
                            Console.WriteLine("Do you want to know what u are in the DND chart alignment? Type yes or no");
                            string answer1 =Console.ReadLine();
                            string[] rando = {"Lawfuk Good",
                            "Neutral Good",
                            "Chaotic Good",
                            "Lawful Neutral",
                            "True Neutral",
                            "Chaotic Neutral",
                            "Lawful Evil",
                            "Neutral Evil",
                            "Chaotic Evil"};
                            Random rnd = new Random();
                            int nump = rnd.Next(0, 8);
                            Console.WriteLine("This is You: ");
                            Console.WriteLine(rando[nump]);
                            Console.WriteLine();
                            break;
                        case 9:
                            Console.WriteLine();
                            functionclass.main();
                            Console.WriteLine();
                            break;
                        case 10:
                            Console.WriteLine();
                            oopobjectclass oopclass = new oopobjectclass("Megan Thee Stallion");
                            oopclass.whoisthat();
                            oopclass.Drama();
                            Console.WriteLine();
                            break;
                        case 11:
                            Console.WriteLine();
                            inheretanceclass.FirstNumber first = new inheretanceclass.FirstNumber();
                            first.num1 = 1;

                            inheretanceclass.SecondNumber second = new inheretanceclass.SecondNumber();
                            second.num1 = 5;
                            Console.WriteLine();
                            break;
                        case 12:
                            Console.WriteLine();
                            encapsulationclass1 encap = new encapsulationclass1("Vice", "Bata", "Nag aaral kaba sa School", "Opo", "Spell PE", "P E");
                            encap.FullScript();
                            Console.WriteLine();
                            break;
                        case 13:
                            Console.WriteLine();
                            polymorphclass.Elf magic1 = new polymorphclass.Elf();
                            polymorphclass.Warlock magic2 = new polymorphclass.Warlock();

                            magic1.Whatdoesmagicdo();
                            magic2.Whatdoesmagicdo();
                            Console.WriteLine();
                            break;
                        case 14:
                            Console.WriteLine();
                            abstractionclass1.Raju raju = new abstractionclass1.Raju();
                            abstractionclass1.Farhan farhan = new abstractionclass1.Farhan();
                            raju.whatjobtheygot();
                            farhan.whatjobtheygot();
                            Console.WriteLine();
                            break;
                        case 16:
                            Console.WriteLine();
                            collectionclass.main();
                            collectionclass.main();
                            Console.WriteLine();
                            break;
                        case 17:
                            Console.WriteLine();
                            var yournum = new delegateclass1.PickedNum2() { NumberP1 = 7 };
                            var rando1 = new delegateclass1.RadomNumberWinner2();
                            var thechosen = new TheChosen();
                            rando1.WinnerPick1 += thechosen.OnWinnerPick1;
                            rando1.Random2(yournum);
                            Console.WriteLine();
                            break;
                        case 18:
                            Console.WriteLine();
                            asynchclass1.Dialogue();
                            Console.WriteLine();
                            break;
                        case 19:
                            Console.WriteLine();
                            Console.WriteLine("Write a phrase or a sentence.");
                            string sent = Console.ReadLine();
                            Console.WriteLine("This is the Phrase/Sentence you put: " + sent);
                            Console.WriteLine("Contains: " + sent.Contains("What"));
                            Console.WriteLine("string[]: " + sent[2]);
                            Console.WriteLine("Index Of: " + sent.IndexOf("Today"));
                            Console.WriteLine("Substring: " + sent.Substring(10));
                            Console.WriteLine();
                            break;
                        case 20:
                            Console.WriteLine();
                            Console.WriteLine("Nice, Finally we're done IJBOL");
                            Console.WriteLine();
                            prj = true;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine("No Lesson Number such as that or either its already on the code if you were reading it you would know ijbol");
                            Console.WriteLine();
                            break;
                    }
                }
                catch (Exception e) 
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }
                

            }
        }
        public class functionclass
        {
            public static void main()
            {

                Console.WriteLine("How many celebs you know from memes?");
                int answer = Int32.Parse(Console.ReadLine());
                int i = 0;
                string[] answers = new string[answer];
                while (i < answer)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Can you Name Them?");
                    string answer1 = Console.ReadLine();
                    answers[i] = answer1;
                    i++;
                }

                if (answer == 1)
                {
                    names(answers[0]);
                }
                else if (answer == 2)
                {
                    names(answers[0], answers[1]);
                }

            }
            static void names(string name1)
            {
                Console.WriteLine("Is " + name1 + "the only person you know? thats tragic....");
            }
            static void names(string name1, string name2)
            {
                Console.WriteLine("Is " + name1 + " and " + name2 +" the only celebrities you know? I'll give you a 1 star for being basic ijbol");
            }

        }
        public class oopobjectclass
        {
            public string celebname;
            public oopobjectclass(string celebname)
            {
                this.celebname = celebname;

            }

            public void whoisthat()
            {
                Console.WriteLine("Popular Singer : " + celebname);
            }

            public void Drama()
            {
                Console.WriteLine("She Clapback and posted a diss track called Hiss calling out Nicki Minaj Bullshit for defending her husband ");
                Console.WriteLine("by using the Megan's Law Reference That got Nicki Minaj tweaking like crazy");
            }
        }

        public class asynchclass1 
        {
            public static async void Dialogue()
            {
                await Task.Delay(2000);
                List<string> dialogue = new List<string>() { ".", ".", ".", ".", "." };
                Console.WriteLine("W'sss in the shaaaaaatttt");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("W'sss in the shat");
                System.Threading.Thread.Sleep(800);
                Console.WriteLine("This is my alter ego ANNITAMXWYN");
                foreach (var ch in dialogue)
                {
                    Console.Write(ch + " ");
                    System.Threading.Thread.Sleep(400);

                }
                Console.WriteLine();

            }
        }

        public class inheretanceclass 
        {
            public class FirstNumber()
            {
                public int num1 { get; set; }

                public void number()
                {
                    Console.WriteLine();
                    Console.WriteLine("First Number" + num1);
                }

            }

            public class SecondNumber : FirstNumber
            {
                public int num2 { get; set; }

                public void questionscript()
                {
                    Console.WriteLine();
                    number();
                    Console.WriteLine("Second Number: " + num2);
                    

                }
            }

        }

        public class encapsulationclass1 
        {
            private string name1;
            private string name2;
            private string question;
            private string answer1;
            private string script1;
            private string script2;

            public string Name1
            {
                get { return name1; }
                set { name1 = value; }
            }
            public string Name2
            {
                get { return name2; }
                set { name2 = value; }
            }

            public string Question
            {
                get { return question; }
                set { question = value; }
            }

            public string Answer1
            {
                get { return answer1; }
                set
                {
                    if (value == "Opo") answer1 = value;
                    else answer1 = "Hindi po";
                }
            }
            public string Script1
            {
                get { return script1; }
                set
                {
                    if (answer1 == "Hindi po") script1 = "Wala kang matatangap na 1000 pesos";
                    else script1 = value;
                }
                
            }

            public string Script2
            {
                    get { return script2; }
                    set { script2 = value; }
                
            }



            public encapsulationclass1(string name1, string name2, string question, string answer1, string script1, string script2)
            {
                Name1 = name1;
                Name2 = name2;
                Question = question;
                Answer1 = answer1;
                Script1 = script1;
                Script2 = script2;
            }
            public void FullScript()
            {
                Console.WriteLine(name1 + ": " + question);
                Console.WriteLine(name2 + ": " + answer1);
                Console.WriteLine(name1 + ": " + script1);
                Console.WriteLine(name2 + ": " + script2);
            }
        }

        public class polymorphclass 
        {
            public class Magic()
            {
                virtual public void Whatdoesmagicdo()
                {
                    Console.WriteLine("They are both the same, they create magic");
                }
            }

            public class Elf : Magic
            {
                override public void Whatdoesmagicdo()
                {
                    Console.WriteLine("They control Energy");
                }
            }

            public class Warlock : Magic
            {
                override public void Whatdoesmagicdo()
                {
                    Console.WriteLine("They use spells abilities called invocations");
                }
            }
        }

        public class collectionclass 
        {
            public static void main() 
            {
                bool runn = true;
                do
                {
                    int j = 5;
                    List<string> names = new List<string>();

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("List " + j + " people you know would save you from getting lobotimized?");
                        string name = Console.ReadLine();
                        names.Add(name);
                        j--;
                    }
                    Console.WriteLine();
                    foreach (string names1 in names)
                    {

                        Console.WriteLine(names1);
                        Console.WriteLine();

                    }
                    runn = false;
                } while (runn == true);
            }
        }

        public class abstractionclass1 
        {
            public abstract class Threelil()
            {
                public abstract void whatjobtheygot();

            }

            public class Raju : Threelil
            {
                override public void whatjobtheygot()
                {
                    Console.WriteLine("He's a WildLife Photographer");
                }
            }

            public class Farhan : Threelil
            {
                override public void whatjobtheygot()
                {
                    Console.WriteLine("He got a marketing Job");
                }
            }
        }

        public class delegateclass1
        {
            public class PickedNum2
            {
                public int NumberP1 { get; set; }

            }
           

            public class RadomNumberWinner2
            {
                public delegate void WinnerPickEventHandler(object source, EventArgs args);

                public event WinnerPickEventHandler WinnerPick1;

                public void Random2(PickedNum2 winner1)
                {
                    Random rnd = new Random();
                    int nump = rnd.Next(1, 30);
                    int extra1 = rnd.Next(1, 5);
                    int extra2 = rnd.Next(1, 8);
                    int total1 = winner1.NumberP1 + extra1 + extra2;
                    Console.WriteLine("Your Number is = " + winner1.NumberP1);
                    Console.WriteLine("Your Total Number is = " + total1);
                    if (total1 > nump)
                    {
                        string win = "You are the winner with " + total1 + " greater than " + nump;
                        OnWinnerPick1(win);
                    }
                    else
                    {
                        string win = "You lose with " + total1 + " lesser than " + nump;
                        OnWinnerPick1(win);
                    }

                }



                protected virtual void OnWinnerPick1(string win)
                {
                    WinnerPick1?.Invoke(win, EventArgs.Empty);
                }
            }


        }

        public class TheChosen
        {
            public void OnWinnerPick1(object source, EventArgs e)
            {
                Console.WriteLine(source);
            }
    }
}
}
