using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using EmployeeLib;

namespace RegExTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void russin()
        {
            string pattern = @"\""?([^\""]*)\""? (\d{2}) (\d{5}.\d{2}) (\d{3}-\d{7})";
            string input = @"""Marco Erice"" 39 20200.00 076-2135921";

            Match m = Regex.Match(input, pattern);

            Assert.AreEqual("Marco Erice", m.Groups[1].Value);
            Assert.AreEqual("39", m.Groups[2].Value);
            Assert.AreEqual("20200.00", m.Groups[3].Value);
            Assert.AreEqual("076-2135921", m.Groups[4].Value);
        }
        [TestMethod]
        public void converter()
        {
            var sut = new EmployeeConverter();
            sut.Convert("Marco Erice 39 20200.00 076-2135921");

            Assert.AreEqual("Erice, Marco (Lön: 20200,00 SEK) " +
                "Telefon:076-2135921 Födelseår:1978", 
                sut.MyString);
            
        }
    }
}
