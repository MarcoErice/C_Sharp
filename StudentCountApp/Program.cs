using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var aSchool = new School("EC Utbildning");
            
            var SPO16 = new Class(27);
            var SPO17 = new Class(32);
            aSchool.Classes.Add(SPO16);
            aSchool.Classes.Add(SPO17);
            Console.WriteLine($"{aSchool} {aSchool.numberOfStudents}");
        }
    }
}
