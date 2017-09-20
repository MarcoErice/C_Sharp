using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLib
{
    public class Exam
    {
        private string courseName;
        private Dictionary<Student, string> StudentGradeDictionary = new Dictionary<Student, string>();

        public Exam(string courseName)
        {
            this.courseName = courseName;
        }

        public void Assign(Student student)
        {
            StudentGradeDictionary.Add(student, "");
        }

        public void Grade(Student student, string grade)
        {
            if (!StudentGradeDictionary.ContainsKey(student))
            {
                throw new UnassignedStudentException();
            }
            StudentGradeDictionary[student] = grade;
        }

        public Dictionary<string, int> GenerateStatistics()
        {
            var gradeCountDictionary = new Dictionary<string, int>
            {
                { "IG", 0 },
                { "G", 0 },
                { "VG", 0 }
            };
            foreach (var StudentGradeEntry in StudentGradeDictionary)
            {
                gradeCountDictionary[StudentGradeEntry.Value]++;
            }
            return gradeCountDictionary;
        }
    }
}