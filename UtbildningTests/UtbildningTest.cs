using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtbildningLib;

namespace UtbildningTests
{
    [TestClass]
    public class UtbildningTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Utbildning utbildning = new Utbildning("SPO16", 0, true);
            Utbildning kurs = new Utbildning("C#", 0, true);
            Utbildning dag1 = new Utbildning("intro", 6, false);
            Utbildning dag2 = new Utbildning("UnitTests1", 6, false);
            utbildning.Children.Add(kurs);
            kurs.Children.Add(dag1);
            kurs.Children.Add(dag2);

            Assert.AreEqual(utbildning.TotalHours, 6);


        }
    }
}
