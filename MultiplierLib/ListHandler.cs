using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplierLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("Idag är det Onsdag");
            List.Add("Det är roligt med C#");
            List.Add("Andra året på YH");
            List.Add("Gäller och plugga hårt");
            List.Add("Trevliga klasskompisar");
        }

        public void RemoveThirdString()
        {
            List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
        }
    }
}