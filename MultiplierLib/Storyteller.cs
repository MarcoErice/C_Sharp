using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class Storyteller
    {
        public string TellStory(string nameOfChild, int ageOfChild, bool willBeScary)
        {
            
            string story = "";
            if (ageOfChild < 7)
            {
                story = $"Lyssna nu {nameOfChild}. Det var en gång en prinsessa ";
            }
            else
                story = $"Hallå {nameOfChild}! En gång fanns en kille ";
            
            

            string scary = "";
            if (willBeScary == true)
            {
                scary = $"som egentligen var en varulv";
            }
            else
                scary = $"som tyckte om att dansa";
            
            return story + scary;

        }
    }
}
