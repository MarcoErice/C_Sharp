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
    }
}
