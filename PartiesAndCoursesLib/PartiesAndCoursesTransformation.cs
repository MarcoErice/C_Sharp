using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiesAndCoursesLib
{
    public class PartiesAndCoursesTransformation
    {
        public static string Transformation(string parties, string courses)
        {
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
                    Debug.WriteLine(lineTokens[0]);
                }
            }
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string sql = "SQL";
                if (lineTokens.Contains(sql))
                {
                    sqlAlumnies += lineTokens[0] + ", ";
                    Debug.WriteLine(lineTokens[0]);
                }
            }
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string mvc = "MVC";
                if (lineTokens.Contains(mvc))
                {
                    mvcAlumnies += lineTokens[0] + ", ";
                    Debug.WriteLine(lineTokens[0]);
                }
            }
            cSharpAlumnies = cSharpAlumnies.Substring(0, cSharpAlumnies.Length - 2);
            sqlAlumnies = sqlAlumnies.Substring(0, sqlAlumnies.Length - 2);
            mvcAlumnies = mvcAlumnies.Substring(0, mvcAlumnies.Length - 2);

            var courseTokens = courses.Split(';');

            var cSharpCourse = courseTokens[0];
            var cSharpEndDate = courseTokens[2];
            var cSharpStartDate = courseTokens[1];
            var cSharpDateDifferens = DateTime.Parse(cSharpEndDate) - DateTime.Parse(cSharpStartDate);

            var sqlCourse = courseTokens[3];
            var sqlEndDate = courseTokens[5];
            var sqlStartDate = courseTokens[4];
            var sqlDateDifferens = DateTime.Parse(sqlEndDate) - DateTime.Parse(sqlStartDate);

            var mvcCourse = courseTokens[6];
            var mvcEndDate = courseTokens[8];
            var mvcStartDate = courseTokens[7];
            var mvcDateDifferens = DateTime.Parse(mvcEndDate) - DateTime.Parse(mvcStartDate);

            var output = $"Kursen {cSharpCourse} pågår i {cSharpDateDifferens.TotalDays} dagar med följande deltagare:\n{cSharpAlumnies}\n\n" +
                $"Kursen {sqlCourse} pågår i {sqlDateDifferens.TotalDays} dagar med följande deltagare:\n{sqlAlumnies}\n\n" +
                $"Kursen {mvcCourse} pågår i {mvcDateDifferens.TotalDays} dagar med följande deltagare:\n{mvcAlumnies}";

            return output;
        }
    }
}
