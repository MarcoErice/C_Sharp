using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Linq;

namespace PartiesAndCoursesTestsLib
{
    [TestClass]
    public class PartiesAndCoursesTests
    {
        [TestMethod]
        public void OneCourseTest()
        {
            var cSharpCourse = "C#;2018-01-01;2018-02-05";
            var tokens = cSharpCourse.Split(';');
            var aCourse = tokens[0];
            var endDate = tokens[2];
            var startDate = tokens[1];
            var dateDiffrens = DateTime.Parse(endDate) - DateTime.Parse(startDate);

            var actual = $"Kursen {aCourse} pågår i {dateDiffrens.TotalDays} dagar med följande deltagare:";
            var expected = "Kursen C# pågår i 35 dagar med följande deltagare;";

            Assert.AreEqual(expected, actual);
                        
        }

        [TestMethod]
        public void OneCourseTestWithParties()
        {
            var parties = "Alice;C#;SQL\nBob;SQL\nCarol;MVC;C#";
            var partiesLines = parties.Split('\n');
            var alumnies = "";
            foreach (var line in partiesLines)
            {
                var lineTokens = line.Split(';').ToList();
                string cSharp = "C#";
                if (lineTokens.Contains(cSharp))
                {
                    alumnies += lineTokens[0] +", ";
                    Debug.WriteLine(lineTokens[0]);
                }
            }
            alumnies = alumnies.Substring(0, alumnies.Length - 2);
            var cSharpCourse = "C#;2018-01-01;2018-02-05";
            var cSharpTokens = cSharpCourse.Split(';');
            var aCourse = cSharpTokens[0];
            var endDate = cSharpTokens[2];
            var startDate = cSharpTokens[1];
            var dateDiffrens = DateTime.Parse(endDate) - DateTime.Parse(startDate);

            var actual = $"Kursen {aCourse} pågår i {dateDiffrens.TotalDays} dagar med följande deltagare:\n{alumnies}";
            var expected = "Kursen C# pågår i 35 dagar med följande deltagare:\nAlice, Carol";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AllCourseTestWithParties()
        {
            var parties = "Alice;C#;SQL\nBob;SQL\nCarol;MVC;C#";
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
            var cSharpCourseData = "C#;2018-01-01;2018-02-05";
            var sqlCourseData = "SQL;2018-02-10;2018-03-25";
            var mvcCourseData = "MVC;2018-04-01;2018-05-15";

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

            
            var actual = $"Kursen {cSharpCourse} pågår i {cSharpDateDifferens.TotalDays} dagar med följande deltagare:\n{cSharpAlumnies}\n\n" +
                $"Kursen {sqlCourse} pågår i {sqlDateDifferens.TotalDays} dagar med följande deltagare:\n{sqlAlumnies}";

            var expected = "Kursen C# pågår i 35 dagar med följande deltagare:\nAlice, Carol\n\n" +
                "Kursen SQL pågår i 43 dagar med följande deltagare:\nAlice, Bob";

            Assert.AreEqual(expected, actual);

        }
    }
}
