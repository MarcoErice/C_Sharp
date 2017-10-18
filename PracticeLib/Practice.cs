using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLib
{
    public class Practice
    {
       
        public string FullText(string birthDate, string personName, string thePhone)
        {
            string convertedText = $"{birthDate}; {personName}; {thePhone}.";
            return convertedText;
        }
    }
}
