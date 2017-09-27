using System.Collections.Generic;
using System.Linq;

namespace StudentCountApp
{
    internal class School
    {
        private string nameOfSchool;

        public School(string nameOfSchool)
        {
            this.nameOfSchool = nameOfSchool;
        }

        public List<Class> Classes { get; internal set; }
            = new List<Class>();
        public int numberOfStudents
        {
            get
            {
                return this.Classes.Sum(Class => Class.numberOfStudents);
            }
        }
        public override string ToString()
        {
            return this.nameOfSchool;
        }
    }

}