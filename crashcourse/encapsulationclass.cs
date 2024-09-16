using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace crashcourse
{
    internal class encapsulationclass
    {
        private string name1;
        private string name2;
        private string question;
        private string answer1;
        private string script1;

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
                if (value == "yes") answer1 = value;
                else answer1 = "Madam Cher i invoke my rights";
            }
        }
        public string Script1
        {
            get { return script1; }
            set
            {
                if (answer1 == "yes") script1 = "oh ok ";
                else script1 = value;
            }
            //"No Im just Asking, parang tinanong mo ako kung kilala ko ba si sen. sherwin"
        }



        public encapsulationclass(string name1, string name2, string question, string answer1, string script1)
        {
            Name1 = name1;
            Name2 = name2;
            Question = question;
            Answer1 = answer1;
            Script1 = script1;

        }
        public void FullScript()
        {
            Console.WriteLine(name1 + ": " + question);
            Console.WriteLine(name2 + ": " + answer1);
            Console.WriteLine(name1 + ": " + script1);
        }
    }
}

