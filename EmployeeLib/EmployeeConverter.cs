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
        private string myString;
        public string MyString {
            get
            {
                return myString;
            }
                }

        public void Convert(string name)
        {
            string pattern = @"\""?([^\""""]*)\""? \""?([^\""""]*)\""? (\d{2}) (\d{5}).(\d{2}) (\d{3}-\d{7})";
            string input = @"""Marco Erice"" 39 20200.00 076-2135921";

            Match m = Regex.Match(input, pattern);

            var firstName = m.Groups[1].Value;
            var lastName = m.Groups[2].Value;
            var bornYear = DateTime.Today.Year - int.Parse(m.Groups[3].Value);
            var salary1 = m.Groups[4].Value;
            var salary2 = m.Groups[5].Value;
            var phone = m.Groups[6].Value;


            this.myString = $"{lastName}, {firstName} " +
                $"(Lön: {salary1},{salary2} SEK) Telefon:{phone} " +
                $"Födelseår:{bornYear}";
        }
    }
}
