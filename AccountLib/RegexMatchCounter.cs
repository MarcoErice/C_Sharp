using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AccountLib
{
    public class RegexMatchCounter
    {
        
        private int counter;
        
        public object CountMatchingLines(string content, string regexPattern)
        {
            using(var reader = new StringReader(content))
            while (true)
            {
                var line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (Regex.Match(line, regexPattern).Success)
                    {
                        counter++;
                    }
            }
            return counter;
        }
    }
}
