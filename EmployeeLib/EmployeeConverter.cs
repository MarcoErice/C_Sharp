using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class EmployeeConverter
    {
        private string name;
        public string Name {
            get
            {
                return name;
            }
                }

        public void Convert(string name)
        {
            string pattern = @"\""?([^\""]*)\""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
            string input = @"""Marco Erice"" 39 20200.00 076-2135921";

            Match m = Regex.Match(input, pattern);

            var fullName = m.Groups[1].Value;
        }
    }
}
