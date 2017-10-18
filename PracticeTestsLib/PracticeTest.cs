using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestsLib
{
    [TestClass]
    public class PracticeTest
    {
        [TestMethod]
        public void ValidateInput()
        {
            // Arrange
            string text = "1978-09-22;Marco Erice;076-2135921.";

            // Act

            // Assert
            Assert.AreEqual("1978-09-22;Marco Erice;076-2135921.", text);
        }
        [TestMethod]
        public void ValidateInput2()
        {
            // Arrange
            var sut = new Practice();
            // Act
            var actual = ;
            // Assert
            Assert.AreEqual("1978-09-22;Marco Erice;076-2135921.", text);
        }
    }
}
