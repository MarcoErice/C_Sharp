using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplierLib;

namespace MultiplierTestsLib
{
    [TestClass]
    public class FileConversionTests
    {
        [TestMethod]
        public void marco_erice_1978()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("marco;erice;1978");
            Assert.AreEqual("MARCO ERICE ÄR 39 ÅR GAMMAL.", actual);
        }
        [TestMethod]
        public void annai_erice_2016()
        {
            var sut = new FileConverter();
            string actual = sut.Transform("annai;erice;2016");
            Assert.AreEqual("ANNAI ERICE ÄR 1 ÅR GAMMAL.", actual);
        }
       
    }
}
