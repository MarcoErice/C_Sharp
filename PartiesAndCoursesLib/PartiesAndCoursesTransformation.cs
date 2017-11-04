using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiesAndCoursesLib
{
    public class PartiesAndCoursesTransformation
    {
        public static string Transformation
            (string parties, string cSharpCourseData, 
            string sqlCourseData, string mvcCourseData)
        {
            string output = "";
            var partiesLines = parties.Split('\n');
            var cSharpAlumnies = "";
            var sqlAlumnies = "";
            var mvcAlumnies = "";
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string cSharp = "C#";
                if (lineTokens.Contains(cSharp))
                {
                    cSharpAlumnies += lineTokens[0] + ", ";
                    // Debug.WriteLine(lineTokens[0]);
                }
            }
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string sql = "SQL";
                if (lineTokens.Contains(sql))
                {
                    sqlAlumnies += lineTokens[0] + ", ";
                    // Debug.WriteLine(lineTokens[0]);
                }
            }
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string mvc = "MVC";
                if (lineTokens.Contains(mvc))
                {
                    mvcAlumnies += lineTokens[0] + ", ";
                    // Debug.WriteLine(lineTokens[0]);
                }
            }
            cSharpAlumnies = cSharpAlumnies.Substring(0, cSharpAlumnies.Length - 2);
            sqlAlumnies = sqlAlumnies.Substring(0, sqlAlumnies.Length - 2);
            mvcAlumnies = mvcAlumnies.Substring(0, mvcAlumnies.Length - 2);


            var cSharpTokens = cSharpCourseData.Split(';');
            var cSharpCourse = cSharpTokens[0];
            var cSharpEndDate = cSharpTokens[2];
            var cSharpStartDate = cSharpTokens[1];
            var cSharpDateDifferens = DateTime.Parse(cSharpEndDate) - DateTime.Parse(cSharpStartDate);

            var sqlTokens = sqlCourseData.Split(';');
            var sqlCourse = sqlTokens[0];
            var sqlEndDate = sqlTokens[2];
            var sqlStartDate = sqlTokens[1];
            var sqlDateDifferens = DateTime.Parse(sqlEndDate) - DateTime.Parse(sqlStartDate);

            var mvcTokens = mvcCourseData.Split(';');
            var mvcCourse = mvcTokens[0];
            var mvcEndDate = mvcTokens[2];
            var mvcStartDate = mvcTokens[1];
            var mvcDateDifferens = DateTime.Parse(mvcEndDate) - DateTime.Parse(mvcStartDate);

            var actual = $"Kursen {cSharpCourse} pågår i {cSharpDateDifferens.TotalDays} dagar med följande deltagare:\n{cSharpAlumnies}\n\n" +
                $"Kursen {sqlCourse} pågår i {sqlDateDifferens.TotalDays} dagar med följande deltagare:\n{sqlAlumnies}\n\n" +
                $"Kursen {mvcCourse} pågår i {mvcDateDifferens.TotalDays} dagar med följande deltagare:\n{mvcAlumnies}";

            return output;
        }
    }
}
